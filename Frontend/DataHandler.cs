using System.Net.Http.Json;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Responses;
using Slot_Machine;
using WinFormsApp1;
using System.Text.Json.Serialization;

namespace Frontend
{

    [Table("users")]//Tabelle
    class UserData : BaseModel//Nutzerdaten-Modell
    {
        [PrimaryKey("id")]//Primary Key (ID, nicht schreibbar)
        public int id { get; set; }
        [Column("name")]//Spalte
        public string name { get; set; }
        [Column("vorname")]
        public string vorname { get; set; }
        [Column("email")]
        public string email { get; set; }
        [Column("password")]
        public string password { get; set; }
        [Column("birth_date")]
        public string birth_date { get; set; }

    }
    [Table("session")]
    class SessionData : BaseModel//Session-Daten Modell
    {
        [Column("id")]
        public string token { get; set; }
        [Column("user_id")]
        public int user_id { get; set; }
        [Column("ip_address")]
        public string ip_address { get; set; }
    }
    [Table("game_data")]//Spieldaten-Modell
    class GameData : BaseModel
    {
        [PrimaryKey("event_id")]
        public int id { get; set; }
        [Column("uid")]
        public int user_id { get; set; }
        [Column("slot_1")]
        public int slot_1 { get; set; }
        [Column("slot_2")]
        public int slot_2 { get; set; }
        [Column("slot_3")]
        public int slot_3 { get; set; }
        [Column("coins_used")]
        public int coins_used { get; set; }
        [Column("coins_recieved")]
        public int coins_recieved { get; set; }
        [Column("coins")]
        public int coins { get; set; }
    }
    class SessionToken //JSON-format Token-erhalten
    {
        [JsonPropertyName("_token")]
        public string _token { get; set; }
    }
    internal class DataHandler
    {
        //Supabase-Daten
        private readonly string key = "SupabaseKeyHere",
               url = "supabase.url.here";
        private readonly SupabaseOptions options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };//Supabase-Config-Optionen


        public async void login(string email, string password, Label label, Einloggen einloggen)
        {

            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            //Nutzerexistenz mit Passwort und ID
            ModeledResponse<UserData> data = await supabase.From<UserData>().Select("id,password").Where(x => x.email == email).Get();
            if (data.Model != null)//wenn Nutzerdaten existiert
            {
                string the_password = data.Model.password;

                if (BCrypt.Net.BCrypt.Verify(password, the_password))//wenn Passwort stimmt
                {
                    einloggen.user_id = data.Model.id;//ID ins Program eintragen
                    label.ForeColor = SystemColors.ControlText;
                    label.Text = "Erfolg!";

                }
                else//passwort stimmt nicht.
                {
                    label.ForeColor = Color.Red;
                    label.Text = "Credential ist falsch!";
                }
            }
            else //wenn Nutzerdaten nicht existiert.
            {
                label.ForeColor = Color.Red;
                label.Text = "Nutzer nicht gefunden!";
            }

        }
        public async void register(string name, string vorname, string email, string password, string birth_date, Label label, Registrieren registrieren)
        {

            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            //Nutzerexistenz surch E-Mail.
            ModeledResponse<UserData> data = await supabase.From<UserData>().Select("email").Where(x => x.email == email).Get();

            if (data.Model != null)//wenn Nutzer existiert
            {
                label.ForeColor = Color.Red;
                label.Text = "Nutzer existiert!";
                return;//Funktionende
            }
            UserData usermodel = new UserData()
            {
                name = name,
                vorname = vorname,
                email = email,
                password = BCrypt.Net.BCrypt.HashPassword(password),
                birth_date = birth_date
            };
            ModeledResponse<UserData> insert = await supabase.From<UserData>().Insert(usermodel);
            registrieren.user_id = insert.Model.id;
            label.ForeColor = SystemColors.ControlText;
            label.Text = "Erfolg!";
        }

        public async void create_session(Spielfeld game)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            if (game.user_id != null && (
                await supabase
                .From<SessionData>()
                .Where(x => x.user_id == game.user_id)
                .Get()
                ).Model != null)//wenn session schon existiert
            {
                game.run_message("Du bist auf einer andere Client eingeloggt.");
                game.exit();
                return;
            }

            //Token generieren
            game.session_token = (await new HttpClient().GetFromJsonAsync<SessionToken>("https://slot-machine-backend-laravel.vercel.app/login"))._token;

            //Public-IP erhalten
            string ip = (await new HttpClient().GetStringAsync("http://ipv4.icanhazip.com")).Replace("\\r\\n", "").Replace("\\n", "").Trim();
            SessionData session = new SessionData()
            {
                token = game.session_token,
                user_id = game.user_id,
                ip_address = ip
            };//Sessiondaten mit Token, UID und IP
            //supabase.From<SessionData>()
            //    .Where(x => x.token == jsondata._token)
            //    .Set(x => x.user_id, user_id);
            await supabase.From<SessionData>().Insert(session);//Sessiondaten speichern
            
        }

        public async void delete_session(int id, string token)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            await supabase.From<SessionData>()
                .Where(x => x.token==token)
                .Delete();//löschen, wo das Token ist (defekt aufgrund Datenbank)

        }

        public async void add_data(int id, string session_token, int a, int b, int c, int coins_used, int coins_recieved, int coins, Spielfeld form)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            if ((await supabase
                .From<SessionData>()
                .Where(x => x.user_id == id)
                .Get()
                ).Model != null)//ob Sessiondaten existiert.
            {
                GameData gamedata = new GameData()//Spieldatum
                {
                    user_id = id,
                    slot_1 = a,
                    slot_2 = b,
                    slot_3 = c,
                    coins_used = coins_used,
                    coins_recieved = coins_recieved,
                    coins = coins
                };
                supabase.From<GameData>().Insert(gamedata);//Spielddaten einsetzen
            }
            else//wenn Sessiondaten nicht existiert.
            {
                form.exit();
                form.run_message("Etwas stimmt mit dem Programm nicht.");
                throw new Exception("Etwas stimmt mit dem Programm nicht.");
            }
        }
        public async void load_data(Spielfeld spielfeld)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            if ((await supabase
                .From<GameData>()
                .Where(x => x.user_id == spielfeld.user_id)
                .Get()
                ).Model !=null)//ob Spieldaten existiert
            {
                GameData data = (await supabase
                .From<GameData>()
                .Where(x => x.user_id == spielfeld.user_id)
                .Get()
                ).Models.LastOrDefault();//letzte Ergebnis ist das Spielstand, basiert auf event_id

                spielfeld.guthaben = data.coins;//Spielguthaben setzen 
                spielfeld.einsatz = data.coins_used;//Einsatz setzen
            } else
            {
                return;
            }
        }
    }
}

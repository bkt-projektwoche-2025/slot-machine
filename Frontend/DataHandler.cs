using Newtonsoft.Json;
using System.Windows.Forms;
using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Responses;
using Slot_Machine;

namespace Frontend
{

    [Table("users")]
    class UserData : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }
        [Column("name")]
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
    [Table("sessions")]
    class SessionData : BaseModel
    {
        [PrimaryKey("id")]
        public string token { get; set; }
        [Column("user_id")]
        public int user_id { get; set; }
        [Column("ip_address")]
        public string ip_address { get; set; }

    }
    class SessionToken
    {
        public string _token;
    }
    internal class DataHandler
    {
        private readonly string key = "SupabaseKeyHere",
               url = "supabase.url.here";
        private readonly SupabaseOptions options = new Supabase.SupabaseOptions
        {
            AutoConnectRealtime = true
        };
        public static void LoadEnv(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('=', StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2)
                    continue;

                Environment.SetEnvironmentVariable(parts[0], parts[1]);
            }
        }
        public async void login(string email, string password, Label label, int id)
        {

            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();
            ModeledResponse<UserData> data = await supabase.From<UserData>().Select("id,password").Where(x => x.email == email).Get();
            if (data.Model != null)
            {
                string the_password = data.Model.password;
                if (BCrypt.Net.BCrypt.Verify(password, the_password))
                {

                    label.ForeColor = SystemColors.ControlText;
                    label.Text = "Erfolg!";
                    id = data.Model.id;

                }
                else
                {
                    label.ForeColor = Color.Red;
                    label.Text = "Credential ist falsch!";
                }
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = "Nutzer nicht gefunden!";
            }

        }
        public async void register(string name, string vorname, string email, string password, string birth_date, Label label)
        {

            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            ModeledResponse<UserData> data = await supabase.From<UserData>().Select("email").Where(x => x.email == email).Get();

            if (data.Model != null)
            {
                label.ForeColor = Color.Red;
                label.Text = "Nutzer existiert!";
                return;
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
            label.ForeColor = SystemColors.ControlText;
            label.Text = "Erfolg!";
        }

        public async void create_session(int id, string token, Form1 theform)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            if ((
                await supabase
                .From<SessionData>()
                .Where(x => x.user_id == id)
                .Get()
                ).Model!=null)
            {
                theform.run_message("Du bist auf einer andere Client eingeloggt.");
                theform.Close();
                return;
            }

            var httpClient = new HttpClient();
            using var httpResponse = await httpClient.GetAsync("https://slot-machine-backend-laravel.vercel.app/login", HttpCompletionOption.ResponseHeadersRead);
            httpResponse.EnsureSuccessStatusCode();
            if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            {
                var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                using var streamReader = new StreamReader(contentStream);
                using var jsonReader = new JsonTextReader(streamReader);

                JsonSerializer serializer = new JsonSerializer();

                try
                {
                    SessionToken jsondata = serializer.Deserialize<SessionToken>(jsonReader);
                            
                            
                    supabase.From<SessionData>()
                        .Where(x => x.token == jsondata._token)
                        .Set(x => x.user_id, id);
                    token = jsondata._token;

                }
                catch (JsonReaderException)
                {
                    Console.WriteLine("Invalid JSON.");
                }
            }
            else
            {
                Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
            }
        }

        public async void delete_session(int id, string token)
        {
            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();

            supabase.From<SessionData>()
                .Where(x => x.token == token && x.user_id == id)
                .Delete();

        }

        public async void add_data(int id, string session_token, int a, int b, int c, int guthabenstand)
        {

        }
    }
}

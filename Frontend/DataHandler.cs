using Supabase;
using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;
using Supabase.Postgrest.Responses;
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
        public async void login(string email, string password, Label label)
        {

            Client supabase = new Client(url, key, options);
            await supabase.InitializeAsync();
            ModeledResponse<UserData> data = await supabase.From<UserData>().Select("password").Where(x => x.email == email).Get();
            if (data.Model != null)
            {
                string the_password = data.Model.password;
                if (BCrypt.Net.BCrypt.Verify(password, the_password))
                {

                    label.ForeColor = SystemColors.ControlText;
                    label.Text = "Erfolg!";
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
                password = password,
                birth_date = birth_date
            };
            ModeledResponse<UserData> insert = await supabase.From<UserData>().Insert(usermodel);
            label.ForeColor = SystemColors.ControlText;
            label.Text = "Erfolg!";
        }

    }
}

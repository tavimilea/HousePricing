using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set;}
        [ForeignKey("Report")]
        public int? ReportFk { get; set; }

        public Report Report { get; set; }
        public string Password { get; set; }
        public User( string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}

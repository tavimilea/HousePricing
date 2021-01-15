namespace API.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }

        public Response(User user, string token)
        {
            Id = user.Id;
            Username = user.Username;
            Token = token;
        }
    }

    public class ResponseAuth {
        public string message { get; set; }
        public ResponseAuth(string msg)
        {
            this.message = msg;
        }
    }
}

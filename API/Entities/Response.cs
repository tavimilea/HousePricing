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
}

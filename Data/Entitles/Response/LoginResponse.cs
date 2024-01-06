using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles.Response
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Token Token { get; set; }
    }
}

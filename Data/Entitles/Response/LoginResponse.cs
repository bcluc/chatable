namespace Chatable.Data.Entitles.Response
{
    public class LoginResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Token { get; set; }
    }
}

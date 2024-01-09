using Chatable.Data.Entitles.Model;

namespace Chatable.DI
{
    public class CurrentUser
    {
        public User? currentUser {  get; set; }

        public Token? token { get; set; }
    }
}

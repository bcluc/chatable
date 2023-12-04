namespace Chatable.Data.Entitles
{
    public class User
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string LastTimeOnline { get; set; }
        public User() { }
        public User(string userId, string userName, string password, string fullName, string avatar, string lastTimeOnline)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            FullName = fullName;
            Avatar = avatar;
            LastTimeOnline = lastTimeOnline;
        }
        public bool IsSelected { get; set; }
    }
}

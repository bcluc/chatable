namespace Chatable.Data.Entitles
{
    public class User
    {
        public string UserName { get; set; }
        
        public string Password { get; set; }    
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string LastTimeOnline { get; set; }
        public User() { }
        public User(string userName, string fullName, string avatar, string lastTimeOnline)
        {
            UserName = userName;
            
            FullName = fullName;
            Avatar = avatar;
            LastTimeOnline = lastTimeOnline;
        }
        public bool IsSelected { get; set; }
    }
}

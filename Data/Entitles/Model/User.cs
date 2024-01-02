using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chatable.Data.Entitles.Model
{
    public class User
    {
        public string userName { get; set; }
        public string email { get; set; }
        public string fullName { get; set; }
        public string avatarUrl { get; set; }
        public string gender { get; set; }
        [DefaultValue("Nam")]
        private DateTime LastTimeOnline { get; set; }
        public DateTime? dob { get; set; }
        public User() { }
        public User(string userName, string fullName, string email, string? avatar, DateTime? dateOfBirth, string? gender)
        {
            this.userName = userName;
            this.fullName = fullName;
            this.email = email;
            if (avatar == null) { this.avatarUrl = getDefaultAvt(gender); }
            else { this.avatarUrl = avatar; }
            this.gender = gender;
            dob = dateOfBirth;
        }
        public bool IsSelected { get; set; }

        private string getDefaultAvt(string gender)
        {
            switch (gender)
            {
                case "Nam":
                    return Constant.defaultImgMale;
                case "Nữ":
                    return Constant.defaultImgFemale;
                default: return Constant.defaultImgMale;
            }
        }
        public DateTime getLastTimeOnl() { return LastTimeOnline; }
        public void setLastTimeOnl(DateTime lastTimeOnl)
        {
            LastTimeOnline = lastTimeOnl;
        }

        
    }
}

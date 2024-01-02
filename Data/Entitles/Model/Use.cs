using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Chatable.Data.Entitles.Model
{
    public class Use : Conversation
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }
        //public string Name { get; set; }
        //public string Avatar { get; set; }
        public string Gender { get; set; }
        [DefaultValue("Nam")]
        public DateTime LastTimeOnline { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedAt { get; set; } 
        public Use() { }
        public Use(string userName, string fullName, string email,  string gender, string lastTimeOnline, string dateOfBirth, string? conversationId)
        {
            UserName = userName;
            Name = fullName;
            Email = email;
            Avatar = getDefaultAvt(gender);
            Gender = gender;
            LastTimeOnline = DateTime.Now;
            DateOfBirth = DateTime.Parse(dateOfBirth);
            base.conversationId = conversationId;
            conversationType = "Peer";
        }
        //public bool IsSelected { get; set; }

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
    }
}

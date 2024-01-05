using System.ComponentModel;

namespace Chatable.Data.Entitles.Model
{
    public class Peer : Conversation
    {
        public string UserName { get; set; }
        public string Gender { get; set; }
        [DefaultValue("Nam")]
        public DateTime LastTimeOnline { get; set; }
        public DateTime CreatedAt { get; set; }
        public Peer() { }
        public Peer(string userName, string fullName, string gender, string lastTimeOnline, string? conversationId)
        {
            UserName = userName;
            Name = fullName;
            Avatar = getDefaultAvt(gender);
            Gender = gender;
            LastTimeOnline = DateTime.Now;
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

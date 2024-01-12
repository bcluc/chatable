using static MudBlazor.CategoryTypes;

namespace Chatable.Data.Entitles.Model
{
    public class ReactionMessage
    {
        public string SenderId { get; set; }
        public int Type { get; set; }
        public string SenderName { get; set; }
        public string SenderAvatar { get; set; }

        public ReactionMessage() { }

        public ReactionMessage(string senderId, int type, string senderName, string senderAvatar) 
        {
            SenderId = senderId;
            Type = type;
            SenderName = senderName;
            SenderAvatar = senderAvatar;
        }
    }
}

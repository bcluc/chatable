namespace Chatable.Data.Entitles.Response
{
    public class ReactionRespone
    {
        public string ConversationId { get; set; }
        public string SenderId { get; set; }
        public string MessageId { get; set; }
        public int Type { get; set; }
        public string SenderName { get; set; }
        public string SenderAvatar { get; set; }
    }
}

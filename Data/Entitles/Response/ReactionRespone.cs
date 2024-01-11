namespace Chatable.Data.Entitles.Response
{
    public class ReactionRespone
    {
        public string ConversationId { get; set; }
        public string SenderId { get; set; }
        public string MessageId { get; set; }
        public int Type { get; set; }
    }
}

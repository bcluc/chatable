using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles.Respond
{
    public class ConversationGetResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Conversation Data { get; set; }
    }
}

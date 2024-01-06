namespace Chatable.Data.Entitles.DTO
{
    public class MessageDTO
    {
        public string SenderId { get; set; }
        public string ConversationId { get; set; }
        public DateTime SendAt { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
        public MessageDTO(string senderId, string messageType, string content, DateTime sendAt, string conversationId)
        {
            SenderId = senderId;
            MessageType = messageType;
            Content = content;
            SendAt = sendAt;
            ConversationId = conversationId;
        }

    }
}

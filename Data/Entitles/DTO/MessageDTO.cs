namespace Chatable.Data.Entitles.DTO
{
    public class MessageDTO
    {
        public string SenderId { get; set; }
        public string ConversationId { get; set; }
        public DateTime SentAt { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderAvatar { get; set; }
        public MessageDTO(string senderId, string messageType, string content, DateTime sentAt, string conversationId, string senderName, string senderAvatar)
        {
            SenderId = senderId;
            MessageType = messageType;
            Content = content;
            SentAt = sentAt;
            ConversationId = conversationId;
            SenderName = senderName;
            SenderAvatar = senderAvatar;
        }

    }
}

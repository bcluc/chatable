namespace Chatable.Data.Entitles.Model
{
    public class Message
    {
        public string MessageId { get; set; }
        public string SenderId { get; set; }
        public string ConversationId { get; set; }
        public DateTime SendAt { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
        public Message() { }

        public Message(string messageId, string senderId, string conversationId, DateTime sendAt, string messageType, string content)
        {
            MessageId = messageId;
            SenderId = senderId;
            ConversationId = conversationId;
            SendAt = sendAt;
            MessageType = messageType;
            Content = content;
        }

        // contructor for get all messages
        public Message(string senderId, string messageType, string content, DateTime sendAt, string conversationId)
        {
            SenderId = senderId;
            MessageType = messageType;
            Content = content;
            SendAt = sendAt;
            ConversationId = conversationId;
        }
    }
}

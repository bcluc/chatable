namespace Chatable.Data.Entitles
{
    public class Message
    {
        public string MessageId { get; set; }
        public string SenderId { get; set; }
        public string ConversationId { get; set; }
        public DateTime SendAt { get; set; }
        public string MessageType { get; set; }
        public string TextContent { get; set; }
        public string ImageContent { get; set; }
        public string AudioContent { get; set; }
        public string VideoContent { get; set; }
        public Message() { }

        public Message(string messageId, string senderId, string conversationId, DateTime sendAt, string messageType, string textContent, string imageContent, string audioContent, string videoContent)
        {
            MessageId = messageId;
            SenderId = senderId;
            ConversationId = conversationId;
            SendAt = sendAt;
            MessageType = messageType;
            TextContent = textContent;
            ImageContent = imageContent;
            AudioContent = audioContent;
            VideoContent = videoContent;
        }
    }
}

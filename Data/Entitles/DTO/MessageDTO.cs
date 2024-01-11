namespace Chatable.Data.Entitles.DTO
{
    public class MessageDTO
    {
        public string SenderId { get; set; }
        public string GroupId { get; set; }
        public DateTime SentAt { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderAvatar { get; set; }
        public bool IsSeen { get; set; } = false;

        public MessageDTO(
            string senderId, 
            string groupId, 
            string messageType, 
            string content, 
            DateTime sentAt, 
            string senderName, 
            string senderAvatar, 
            bool isSeen
        )
        {
            SenderId = senderId;
            GroupId = groupId;
            MessageType = messageType;
            Content = content;
            SentAt = sentAt;
            SenderName = senderName;
            SenderAvatar = senderAvatar;
            IsSeen = isSeen;
        }

    }
}

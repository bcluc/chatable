﻿using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles.DTO
{
    public class MessageDTO
    {
        public string MessageId { get; set; }
        public string SenderId { get; set; }
        public string GroupId { get; set; }
        public DateTime SentAt { get; set; }
        public string MessageType { get; set; }
        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderAvatar { get; set; }
        public bool IsSeen { get; set; }
        public List<ReactionMessage> Reactions { get; set; }

        public MessageDTO() { }

        public MessageDTO(
            string messageId,
            string senderId,
            string groupId,
            string messageType,
            string content,
            DateTime sentAt,
            string senderName,
            string senderAvatar,
            bool isSeen,
            List<ReactionMessage> reactionMessages
        )
        {
            MessageId = messageId;
            SenderId = senderId;
            GroupId = groupId;
            MessageType = messageType;
            Content = content;
            SentAt = sentAt;
            SenderName = senderName;
            SenderAvatar = senderAvatar;
            IsSeen = isSeen;
            Reactions = reactionMessages;
        }

    }
}

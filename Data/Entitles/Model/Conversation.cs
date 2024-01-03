﻿using System.ComponentModel;

namespace Chatable.Data.Entitles.Model
{
    public class Conversation
    {

        public string Name = "Unknow";

        public string Avatar = Constant.defaultImgMale;

		public string? conversationId { get; set; }
        public LastMessageDTO? lastMessage { get; set; }
        public string conversationType { get; set; }
        public bool IsSelected { get; set; }
        public Conversation() { }

        public Conversation(string? id,  string conversationType, LastMessageDTO? lastMessage)
        {
            conversationId = id;
            this.lastMessage = lastMessage;
            this.conversationType = conversationType;
        }
        
    }
    public class LastMessageDTO
    {
        public string senderId { get; set; }
        public string messageType { get; set; }
        public string content { get; set; }
        public DateTime sendAt { get; set; }
        public string? groupId { get; set; }

		public LastMessageDTO(string senderId, string messageType, string content, DateTime sendAt, string? groupId)
		{
			this.senderId = senderId;
			this.messageType = messageType;
			this.content = content;
			this.sendAt = sendAt;
			this.groupId = groupId;
		}
	}
}

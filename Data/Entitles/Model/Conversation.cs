using System.ComponentModel;

namespace Chatable.Data.Entitles.Model
{
    public class Conversation
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string? Id { get; set; }
        public Message? LastMessage { get; set; }
        public string ConversationType { get; set; }
        public bool IsSelected { get; set; }
        public Conversation() { }
    }
}

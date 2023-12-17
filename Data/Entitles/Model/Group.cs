using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Chatable.Data.Entitles.Model
{
    public class Group : Conversation
    {
        public string GroupId { get; set; }
        //public string GroupName { get; set; }
        //public string? conversationId { get; set; }
        public string AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> MemberList { get; set; }
        public Group(string groupId, string groupName, string? conversationId, string adminId, string createdAt)
        {
            GroupId = groupId;
            //this.GroupName = groupName;
            Name = groupName;
            //Id = conversationId;
            Id = groupId;
            AdminId = adminId;
            Avatar = Constant.defaultImgGroup;
            CreatedAt = DateTime.Parse(createdAt);
            ConversationType = "Group";
        }
    }
}

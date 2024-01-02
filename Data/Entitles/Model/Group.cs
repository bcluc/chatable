using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Chatable.Data.Entitles.Model
{
    public class Group : Conversation
    {
        //public string GroupName { get; set; }
        public string AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> MemberList { get; set; }
        public Group(string groupId, string groupName, string adminId, string createdAt)
        {
            conversationId = groupId;
            Name = groupName;
            AdminId = adminId;
            Avatar = Constant.defaultImgGroup;
            CreatedAt = DateTime.Parse(createdAt);
            conversationType = "Group";
        }
    }
}

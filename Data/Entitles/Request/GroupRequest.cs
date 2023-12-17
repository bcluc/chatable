using System.ComponentModel.DataAnnotations;

namespace Chatable.Data.Entitles.Request
{
    public class GroupRequest
    {
        [Required]
        public string groupName { get; set; }
        [Required]
        public List<string> memberList { get; set; }

        public GroupRequest(string groupName, List<string> memberList)
        {
            this.groupName = groupName;
            this.memberList = memberList;
        }
    }
}

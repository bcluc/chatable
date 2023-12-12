using System.ComponentModel.DataAnnotations;

namespace Chatable.Data.Entitles
{
    public class Group
    {
        [Required]
        public string groupName { get; set; }
        [Required]
        public List<string> memberList { get; set; }

        public Group(string groupName, List<string> memberList)
        {
            this.groupName = groupName;
            this.memberList = memberList;
        }
    }
}

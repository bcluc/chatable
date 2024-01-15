using Chatable.Data.Entitles.Response;

namespace Chatable.Data.Entitles.DTO
{
    public class GroupDTO
    {
        public string GroupId { get; set; }
        public string GroupName { get; set; }
        public string Avatar { get; set; }
        public string AdminId { get; set; }
        public List<MemberResponse> ListMember { get; set; }
    }

}

using Chatable.Data.Entitles.Model;
using Chatable.DI;
using static MudBlazor.CategoryTypes;
using System.Xml.Linq;

namespace Chatable.Data.Entitles.DTO
{
    public class FriendRequestDTO
    {
        public string userId { get; set; }
        public string name { get; set; }
        public string sendAt { get; set; }
        public string status { get; set; }
        public string avatar {  get; set; }

        public FriendRequestDTO(string userId, string status, string sendAt, string avatar, string name)
        {
            this.userId = userId;
            this.status = status;
            this.sendAt = sendAt;
            this.avatar = avatar;
            this.name = name;
        }
    }
}

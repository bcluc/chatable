using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles.Respond
{
    public class GroupGetResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<Group> Data { get; set; }
    }
}

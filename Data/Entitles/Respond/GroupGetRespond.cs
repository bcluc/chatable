using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles.Respond
{
    public class GroupGetRespond
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public IList<Group> Data { get; set; }
    }
}

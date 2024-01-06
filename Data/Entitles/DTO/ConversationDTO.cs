namespace Chatable.Data.Entitles.DTO
{
    public class ConversationDTO
    {
        public string Id { get; set; }
        public string Avt {  get; set; }
        public string Name { get; set; }

        public ConversationDTO(string id, string avt, string name)
        {
            Id = id;
            Avt = avt;
            Name = name;
        }
    }
}

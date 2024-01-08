namespace Chatable.Data.Entitles.DTO
{
    public class FriendRequestDTO
    {
        public string senderId {  get; set; }
        public string receiverId { get; set; }
        public string sendAt { get; set; }
        public string status { get; set; }

        public FriendRequestDTO(string senderId, string receiverId, string status, string sendAt)
        {
            this.senderId = senderId;
            this.receiverId = receiverId;
            this.status = status;
            this.sendAt = sendAt;
        }
    }
}

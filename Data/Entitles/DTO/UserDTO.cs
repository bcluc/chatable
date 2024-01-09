namespace Chatable.Data.Entitles.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string CreateAt { get; set; }
        public string AvatarUrl { get; set; }


        public UserDTO(string userName, string fullName, string createAt, string avatarUrl)
        {
            UserName = userName;
            FullName = fullName;
            CreateAt = createAt;
            AvatarUrl = avatarUrl;
        }
    }
}

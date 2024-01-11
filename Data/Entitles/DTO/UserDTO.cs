namespace Chatable.Data.Entitles.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public bool IsFriend { get; set; }
        public string AvatarUrl { get; set; }
        public bool IsSelected { get; set; }

        public UserDTO(string userName, string fullName, string avatarUrl, bool isFriend)
        {
            UserName = userName;
            FullName = fullName;
            IsFriend = isFriend;
            AvatarUrl = avatarUrl;
        }
    }
}

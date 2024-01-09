namespace Chatable.Data.Entitles.DTO
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string CreateAt { get; set; }

        public UserDTO(string userName, string fullName, string createAt)
        {
            UserName = userName;
            FullName = fullName;
            CreateAt = createAt;
        }
    }
}

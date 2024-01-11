namespace Chatable.Data.Entitles.DTO
{
	public class RequestDTO
	{
		//id cuar nguoi send
		public string UserId { get; set; }
		public string Status { get; set; }
		public string SentAt { get; set; }
		public string Avatar { get; set; }
		public string Name { get; set; }

		public RequestDTO(string userId, string status, string sentAt, string avatar, string name)
		{
			UserId = userId;
			Status = status;
			SentAt = sentAt;
			Avatar = avatar;
			Name = name;
		}
	}
}

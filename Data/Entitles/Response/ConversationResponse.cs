using Chatable.Data.Entitles.DTO;

namespace Chatable.Data.Entitles.Response
{
	public class ConversationResponse
	{
		public string ConversationId { get; set; }
		public string ConversationType { get; set; }
		public MessageResponse LastMessage { get; set; }
		public String ConversationName { get; set; }
		public String ConversationAvatar { get; set; }
		public bool isFriend { get; set; }

		public ConversationResponse() { }
	}

}

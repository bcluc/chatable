namespace AgoraRTC.Models
{
    public class PeerInfo
    {
        public string Name { get; set; }
        public string AvatarUrl { get; set; }

        // Parameterized constructor
        public PeerInfo(string name, string avatarUrl)
        {
            Name = name;
            AvatarUrl = avatarUrl;
        }
    }

    
}

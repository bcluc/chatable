using System.Collections.ObjectModel;
using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles
{
    public static class Constant
    {
        public const string defaultImgMale = "img/default_male.jpg";
        public const string defaultImgFemale = "img/default_female.jpg";
        public const string defaultImgGroup = "img/default_group.jpg";
        public const string defaultBg = "img/pattern_bg.jpg";
        public const string imgWaitChat = "img/wait_chat.png";
        public const string waterMark = "img/waterMark.png";
        public const string gearOutline = "img/gear-outline.svg";
		public const string themeIcon = "img/theme_icon.svg";
        public const string lightMode = "img/lightMode.jpg";
        public const string darkMode = "img/darkMode.jpg";

        public const string uriHost = "https://localhost:7124/api/v1/";




        public static readonly IList<String> states = new ReadOnlyCollection<String>
        (new List<String> 
        {
        "Alabama", "Alaska", "American Samoa"
        });

        public static readonly List<Conversation> chats  = new List<Conversation>
        {
            new User("nhubaole", "Trần Lê Hoàng Lâm","","Nam","2023-11-19 07:58:48.084+00","2023-11-19 07:58:48.084+00","BC_nhubaole"),
            new User("nhihuynh", "Công chúa Elsa","","Nữ", "2023-12-04 17:03:22.2+00","2023-12-04 17:03:22.2+00", "BC_nhihuynh"),
            new Group("123","Group Local Test", "", "BC", "2023-12-04 17:03:22.2+00")
        };

        public static readonly IList<User> usersList = new List<User>
        {
        new User("nhubaole", "Trần Lê Hoàng Lâm","", "Name","2023-11-19 07:58:48.084+00","2023-11-19 07:58:48.084+00", "BC_nhubaole"),
        new User("nhihuynh", "Công chúa Elsa","", "Nữ", "2023-12-04 17:03:22.2+00","2023-12-04 17:03:22.2+00", "BC_nhihuynh"),
        };

        public static readonly User currentUser = new("Bùi Cường", "Bùi Cường", "", "Nam", "2023-12-05 11:27:29.397+00", "2023-12-05 11:27:29.397+00","BC");
        
        public static readonly Message visibleMessage = new("0", "BC", "1", DateTime.Now, "Text", "Say hi");

        public static readonly Group currentGroup = new Group("123", "Group Local Test", "", "BC", "2023-12-04 17:03:22.2+00");

        public static readonly User oppositeUser = new User("nhubaole", "Trần Lê Hoàng Lâm", "", "Nam", "2023-11-19 07:58:48.084+00", "2023-11-19 07:58:48.084+00", "BC_nhubaole");
       

    }

    
}

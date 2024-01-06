using System.Collections.ObjectModel;
using Chatable.Data.Entitles.Model;

namespace Chatable.Data.Entitles
{
    public class Constant
    {
        public const string defaultImgMale = "img/default_male.jpg";
        public const string defaultImgFemale = "img/default_female.jpg";
        public const string defaultImgGroup = "img/default_group.jpg";
        public const string defaultBg = "img/pattern_bg.jpg";
        public const string imgWaitChat = "img/wait_chat.png";
        public const string waterMark = "img/waterMark.png";
        public const string logoIcon = "img/logo-1.svg";
        public const string logoText = "img/logo-2.svg";
        public const string signature = "img/signature.svg";

        public const string gearOutline = "img/gear-outline.svg";
        public const string themeIcon = "img/theme_icon.svg";
        public const string lightMode = "img/lightMode.jpg";
        public const string darkMode = "img/darkMode.jpg";
        //public const string uriHost = "http://localhost:5275/api/v1/";
        public const string uriHost = "https://localhost:7124/api/v1/";



        public static readonly IList<String> states = new ReadOnlyCollection<String>
        (new List<String>
        {
        "Alabama", "Alaska", "American Samoa"
        });

        public static readonly List<Conversation> chats = new List<Conversation>
        {
            new Peer("nhubaole", "Trần Lê Hoàng Lâm","Nam","2023-11-19 07:58:48.084+00","BC_nhubaole"),
            new Peer("nhihuynh", "Công chúa Elsa","Nữ", "2023-12-04 17:03:22.2+00","BC_nhihuynh"),
            new Group("123","Group Local Test", "BC", "2023-12-04 17:03:22.2+00")
        };

        public static readonly IList<User> usersList = new List<User>
        {
        new User("nhubaole", "Trần Lê Hoàng Lâm","", "",DateTime.Now,"Nam"),
        new User("nhihuynh", "Công chúa Elsa","", "", DateTime.Now,"Nữ"),
        };

        private static User _currentUser = new User("unknow", "Unknow", "", defaultImgMale, DateTime.Now, "Nam");
        private static Token _token = new Token();

        public static readonly Message visibleMessage = new("0", "BC", "1", DateTime.Now, "Text", "Say hi");

        public static readonly Group currentGroup = new Group("123", "Group Local Test", "BC", "2023-12-04 17:03:22.2+00");

        public static readonly Peer oppositeUser = new Peer("nhubaole", "Trần Lê Hoàng Lâm", "Nam", "2023-11-19 07:58:48.084+00","BC_nhubaole");

        public static User currentUser {
            get { return _currentUser; }
            set { _currentUser = value; }
        }
        public static Token token
        {
            get { return _token; }
            set { _token = value; }
        }
    }
}

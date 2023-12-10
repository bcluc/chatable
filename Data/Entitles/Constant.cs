namespace Chatable.Data.Entitles
{
    public class Constant
    {
        public Constant() { }
        public string[] states =
    {
        "Alabama", "Alaska", "American Samoa", "Arizona",
        "Arkansas", "California", "Colorado", "Connecticut",
        "Delaware", "District of Columbia", "Federated States of Micronesia",
        "Florida", "Georgia", "Guam", "Hawaii", "Idaho",
        "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
        "Louisiana", "Maine", "Marshall Islands", "Maryland",
        "Massachusetts", "Michigan", "Minnesota", "Mississippi",
        "Missouri", "Montana", "Nebraska", "Nevada",
        "New Hampshire", "New Jersey", "New Mexico", "New York",
        "North Carolina", "North Dakota", "Northern Mariana Islands", "Ohio",
        "Oklahoma", "Oregon", "Palau", "Pennsylvania", "Puerto Rico",
        "Rhode Island", "South Carolina", "South Dakota", "Tennessee",
        "Texas", "Utah", "Vermont", "Virgin Island", "Virginia",
        "Washington", "West Virginia", "Wisconsin", "Wyoming",
    };

        public IList<User> Chats { get; set; } = new List<User>
    {
    new User("nhubaole", " Lê Bảo Như", "string","2023-11-19 07:58:48.084+00"),
    new User("nhihuynh", " Ý Nhi", "string", "2023-12-04 17:03:22.2+00"),
    };

        public User currentUser = new User("BC", " BC", "string", "2023-12-05 11:27:29.397+00");
     
    }
}

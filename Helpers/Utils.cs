using Chatable.Data.Entitles.Model;

namespace Chatable.Helpers
{
    public static class Utils
    {
        public class ReactionIcon
        {
            public string? icon { get; set; }
            public string? color { get; set; }
        }
        public static ReactionIcon MapToIcon(int typeReaction)
        {

            switch (typeReaction)
            {
                case 0:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-thumbs-up fa-lg",
                        color = "#0091FE"
                    };
                case 1:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-heart fa-lg",
                        color = "#E50915"
                    };
                case 2:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-face-laugh-beam fa-lg",
                        color = "#FFCB3D"
                    };
                case 3:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-face-surprise fa-lg",
                        color = "#FFCB3D"
                    };
                case 4:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-face-frown fa-lg",
                        color = "#FFCB3D"
                    };
                case 5:
                    return new ReactionIcon()
                    {
                        icon = "fa-solid fa-face-angry fa-lg",
                        color = "#E50915"
					};
            };
            return new ReactionIcon()
            {
                icon = "fa-solid fa-thumbs-up",
                color = "#0091FE"
            };
        }
    }
}

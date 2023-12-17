using System.ComponentModel.DataAnnotations;

namespace Chatable.Data.Entitles.Request
{
    public class LoginRequest
    {
        [Required(ErrorMessage = "Bạn cần nhập tên đăng nhập")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Bạn cần nhập mật khẩu")]
        public string password { get; set; }
    }
}

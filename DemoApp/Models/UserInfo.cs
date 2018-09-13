using System.ComponentModel.DataAnnotations;

namespace DemoApp.Models
{
    public class UserInfo
    {
        [Key]
        public int Id { get; set; }
        public string UserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Mobile { get; set; }
    }
}
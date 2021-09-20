using System.ComponentModel.DataAnnotations;

namespace ZwajApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }
        [StringLength(8, MinimumLength = 4, ErrorMessage = "يجب أن لا تقل كلمة السر عن أربعة حروف ولا تزيد عن ثمانية")]
        [Required]
        public string Password { get; set; }
    }
}
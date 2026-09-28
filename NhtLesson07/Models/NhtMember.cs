using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace NhtLesson07.Models
{
    // Model class Member

    //Author : Hai Tien
    public class NhtMember
    {
        public int Id { get; set; }
        [DisplayName("Tai Khoan")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tai khoan co do dai trong khoang 3-20 ky tu")]
        [Required(ErrorMessage = "Tai khoan khong duoc de trong")]
        public string NhtUsername { get; set; }
        [DisplayName("Mat Khau")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mat khau toi thieu 8 ky tu")]
        [Required(ErrorMessage = "Mat khau khong duoc de trong")]
        public string NhtPassword { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email khong duoc de trong")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email khong hop le")]
        public string NhtEmail { get; set; }

        [DisplayName("So Dien Thoai")]
        [Required(ErrorMessage = "ban chua nhap sdt")]
        [RegularExpression(@"^0\d{9,9}$", ErrorMessage = "SDT phai 10 ky tu so")]
        public string NhtPhone { get; set; }

    }
}

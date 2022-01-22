using System.ComponentModel.DataAnnotations;


namespace PartyInvites.Models
{
    public class GuestResponce
    {
        [Required(ErrorMessage ="Пожалуйста, введите своё имя")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Пожалуйста введите свой адресс электронной почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста введите свой номер телефона")]
        public string Phone{ get; set; }
        [Required(ErrorMessage = "Пожалуйста укажите примите ли участие")]
        public bool? WillAttend{ get; set; }
    }
}

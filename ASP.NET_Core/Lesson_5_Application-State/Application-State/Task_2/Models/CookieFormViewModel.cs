using System.ComponentModel.DataAnnotations;

namespace Task_2.Models
{
    public class CookieFormViewModel
    {
        [Required(ErrorMessage = "Поле значення є обов'язковим")]
        [Display(Name = "Значення для збереження")]
        public string CookieValue { get; set; } = string.Empty;

        [Required(ErrorMessage = "Вкажіть дату та час закінчення дії")]
        [Display(Name = "Дата та час закінчення (Expires)")]
        public DateTime ExpirationDate { get; set; } = DateTime.Now.AddMinutes(5);
    }
}

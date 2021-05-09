using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddTask.Models
{
    public class RegistrationBindingModel
    {
        [Required]
        [StringLength(15)]
        [Display(Name = "Имя")]
        public  string FName { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "Фамилия")]
        public  string LName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public  string Email { get; set; }

        [UIHint("DateTime-local")]
        [Required]
        [Display(Name = "Желаемая дата консультации")]
        public  DateTime Date { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShopYT.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введите имя")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна строки меньше 5 символов")]
        public string name { get; set; }

        [Display(Name = "Фвмилия")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна строки меньше 5 символов")]
        public string surname { get; set; }

        [Display(Name = "Адрес")]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна строки меньше 5 символов")]
        public string adress { get; set; }

        [Display(Name = "Телефон")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна строки меньше 5 символов")]
        public string phone { get; set; }

        [Display(Name = "емаил")]
        [DataType(DataType.EmailAddress)]
        [StringLength(5)]
        [Required(ErrorMessage = "Длинна строки меньше 5 символов")]
        public string eMail { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }
    }
}

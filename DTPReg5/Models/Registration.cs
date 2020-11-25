using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTPReg5.Models
{
    public class Registration
    {
        //Id офрмлення ДТП
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        //ПІП порушника
        [Required(ErrorMessage = "Поле ПІП повинно бути встановлено")]
        [Display(Name = "ПІП")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 50 символів")]
        public string PIP { get; set; }
        //Номер водійського посвідчення порушника
        [Required(ErrorMessage = "Поле Номер посвідчення повинно бути встановлено")]
        [Display(Name = "Номер посвідчення")]
        [StringLength(10, MinimumLength = 9, ErrorMessage = "Довжина рядка повинна бути від 9 до 10 символів")]
        public string NPos { get; set; }
        //Дата народження порушника
        [Required(ErrorMessage = "Поле Дата народження повинно бути встановлено")]
        [Display(Name = "Дата народження")]
        [RegularExpression("([0][1-9]|[2][0-9]|[3][0-1]|[1-9]|[1][0-9])/([0][1-9]|[1][0-2]|[1-9])/([1-2][0-9][0-9][0-9]|[0-9][0-9])", ErrorMessage = "Некоректно введена дата. Правильний флормат введення: ММ/ДД/РРРР")]
        public string Date_Birth { get; set; }
        //Марка автомобіля
        [Required(ErrorMessage = "Поле Марка автомобіля повинно бути встановлено")]
        [Display(Name = "Марка автомобіля")]
        public string Marka_Auto { get; set; }
        //Номерний знак автомобіля
        [Required(ErrorMessage = "Поле Номер автомобіля повинно бути встановлено")]
        [Display(Name = "Номер автомлбіля")]
        public string Nomer_Auto { get; set; }
        //Адреса порушення
        [Required(ErrorMessage = "Поле Адреса порушення повинно бути встановлено")]
        [Display(Name = "Адреса порушення")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Довжина рядка повинна бути від 3 до 70 символів")]
        public string Address { get; set; }
        //Дата порушення
        [Required(ErrorMessage = "Поле Дата повинно бути встановлено")]
        [Display(Name = "Дата порушення")]
        [RegularExpression("([0][1-9]|[2][0-9]|[3][0-1]|[1-9]|[1][0-9])/([0][1-9]|[1][0-2]|[1-9])/([1-2][0-9][0-9][0-9]|[0-9][0-9])", ErrorMessage = "Некоректно введена дата. Правильний флормат введення: ММ/ДД/РРРР")]
        public string Date_Por { get; set; }
    }
}
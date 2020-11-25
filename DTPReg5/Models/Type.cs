using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTPReg5.Models
{
    public class Type
    {
        //ID типу правопорушення
        public int Id { get; set; }
        //Тип правопорушення
        public string Name { get; set; }
        //Тип покарання за скоєне ДТП
        public string Punishment { get; set; }
    }
}
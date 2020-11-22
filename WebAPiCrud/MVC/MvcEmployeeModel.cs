using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApimvc.Models
{
    public class MvcEmployeeModel
    {
        public int EID { get; set; }


        [Required(ErrorMessage= "This Field is required")]
        public string EName { get; set; }
        public string Position { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> Salary { get; set; }
    }
}
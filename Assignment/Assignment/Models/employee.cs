using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Assignment.Models
{
    public class employee
    {
        [Required(ErrorMessage = "Please Enter an ID!")]
        //[Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Name!")]
        //[Display(Name = "Pr_Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Date!")]
        //[Display(Name = "Expire Date")]
        [DataType(DataType.Date)]
        public DateTime ExpireDob { get; set; }

        //[Display(Name = "Quantity")]
        public string Quantity { get; set; }

       // [Display(Name = "Price")]
        public int Price { get; set; }

    }
}
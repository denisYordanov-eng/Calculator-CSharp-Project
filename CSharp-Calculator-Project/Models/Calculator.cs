using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CSharp_Calculator_Project.Models
{
    public class Calculator
    {
        public Calculator()
        { 
            this.Result = 0;
        }
        [Required]
        public decimal LeftOperand { get; set; }
        [Required]
        public decimal RightOperand { get; set; }
        [Required]
        public string Operator { get; set; }

        public decimal Result { get; set; }
    }
}
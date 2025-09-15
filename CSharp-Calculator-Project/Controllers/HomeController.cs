using CSharp_Calculator_Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharp_Calculator_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public ActionResult Calculate (Calculator calculator)
        {
            calculator.Result = CalculateResult(calculator);

            return RedirectToAction("Index", calculator);
        }

        private decimal CalculateResult(Calculator calculator)
        {
            var result = 0.0m;
            string operatorSymbol = calculator.Operator;

            if (operatorSymbol == "+")
            {
                result = calculator.LeftOperand + calculator.RightOperand;
            }
            else if (operatorSymbol == "-")
            {
                result = calculator.LeftOperand - calculator.RightOperand;
            }else if(operatorSymbol == "*")
            {
                result = calculator.LeftOperand * calculator.RightOperand;
            }
            else if (operatorSymbol == "/")
            {
                if (calculator.LeftOperand == 0 || calculator.RightOperand == 0)
                {
                    result = 0;
                }
                else
                {
                    result = calculator.LeftOperand / calculator.RightOperand;
                }
            }
                return result;
        }
    }
}
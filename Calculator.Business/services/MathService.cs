using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator.Business.services
{
    public class MathService
    {
        public string MultiplicationAndDivision(string text)
        {
            var matches = Regex.Matches(text, @"(-?\d+)\s*([*\/])s*(-?\d+)", RegexOptions.None);
            foreach (Match item in matches)
            {
                var num1 = item.Groups[1].Value;
                var operation = item.Groups[2].Value;
                var num2 = item.Groups[3].Value;
                decimal result = 0;
                switch (operation)
                {
                    case "*":
                        result = Convert.ToInt32(num1) * Convert.ToInt32(num2);
                        break;
                    case "/":
                        result = Convert.ToInt32(num1) / Convert.ToInt32(num2);
                        break;
                    default:
                        break;
                }
                text = text.Replace(item.Value.ToString(), result.ToString());
                LogService.log(item.Value.ToString(), result.ToString());
            }
            return text;
        }
        public string AdditionAndSubtraction(string text)
        {
            var matches2 = Regex.Matches(text, @"(-?\d+)\s*([+\-])s*(-?\d+)", RegexOptions.None);
            foreach (Match item in matches2)
            {
                var num1 = item.Groups[1].Value;
                var operation = item.Groups[2].Value;
                var num2 = item.Groups[3].Value;
                decimal result = 0;
                switch (operation)
                {
                    case "+":
                        result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
                        break;
                    case "-":
                        result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
                        break;
                    default:
                        break;
                }
                text = text.Replace(item.Value.ToString(), result.ToString());
                LogService.log(item.Value.ToString(),result.ToString());
            }
            return text;
        }
        public string CheckResult(string text)
        {
            text = MultiplicationAndDivision(text);
            text = AdditionAndSubtraction(text);
            if (Regex.Matches(text, @"(-?\d+)\s*([+\-\*\/])s*(-?\d+)", RegexOptions.None).Count > 0)
                text = CheckResult(text);
            return text;
        }
    }
}

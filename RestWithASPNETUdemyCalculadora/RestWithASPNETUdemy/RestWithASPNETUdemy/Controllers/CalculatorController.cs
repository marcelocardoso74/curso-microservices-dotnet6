using Microsoft.AspNetCore.Mvc;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fisrtNumber}/{secondNumber}")]
        public IActionResult sum(string fisrtNumber, string secondNumber)
        {

            if(IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var sum = ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }

            return BadRequest("invalid imput");
        }

        [HttpGet("subtraction/{fisrtNumber}/{secondNumber}")]
        public IActionResult subtraction(string fisrtNumber, string secondNumber)
        {

            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var subtraction = ConvertToDecimal(fisrtNumber) - ConvertToDecimal(secondNumber);
                return Ok(subtraction.ToString());
            }

            return BadRequest("invalid imput");
        }

        [HttpGet("multiply/{fisrtNumber}/{secondNumber}")]
        public IActionResult multiply(string fisrtNumber, string secondNumber)
        {

            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var multiply = ConvertToDecimal(fisrtNumber) * ConvertToDecimal(secondNumber);
                return Ok(multiply.ToString());
            }

            return BadRequest("invalid imput");
        }

        [HttpGet("divide/{fisrtNumber}/{secondNumber}")]
        public IActionResult divide(string fisrtNumber, string secondNumber)
        {

            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber) )
            {
                if (ConvertToDecimal(secondNumber) == 0)
                {
                    return BadRequest("não posso dividir por zero");
                }
                var divide = ConvertToDecimal(fisrtNumber) / ConvertToDecimal(secondNumber);
                return Ok(divide.ToString());
            }

            return BadRequest("invalid imput");
        }

        [HttpGet("squareroot/{Number}")]
        public IActionResult squareroot(string Number)
        {

            if (IsNumeric(Number))
            {
                var squareRoot = Math.Sqrt((double)ConvertToDecimal(Number));
                return Ok(squareRoot.ToString());
            }

            return BadRequest("invalid imput");
        }

        [HttpGet("mean/{fisrtNumber}/{secondNumber}")]
        public IActionResult mean(string fisrtNumber, string secondNumber)
        {

            if (IsNumeric(fisrtNumber) && IsNumeric(secondNumber))
            {
                var mean = (ConvertToDecimal(fisrtNumber) + ConvertToDecimal(secondNumber)) / 2;
                return Ok(mean.ToString());
            }

            return BadRequest("invalid imput");
        }

        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalvalue;
            if(decimal.TryParse(strNumber, out decimalvalue))
            {
                return decimalvalue;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isnumber = double.TryParse(strNumber, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isnumber;
        }
    }
}

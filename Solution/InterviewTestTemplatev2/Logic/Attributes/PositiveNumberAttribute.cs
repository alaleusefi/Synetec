using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InterviewTestTemplatev2
{
    public class PositiveNumberAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var stringValue = value.ToString();

            decimal decimalValue;
            if(decimal.TryParse(stringValue, out decimalValue )== false)
                return new ValidationResult($"{validationContext.DisplayName} is not a valid decimal");

            if (decimalValue <= 0)
                return new ValidationResult($"{validationContext.DisplayName} needs to be greater than zero");

            return ValidationResult.Success;
        }
    }
}
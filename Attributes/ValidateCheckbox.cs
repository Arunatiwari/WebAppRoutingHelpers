using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppRoutingHelpers.Attributes
{
    public class ValidateCheckbox: ValidationAttribute
    {
        public void AddValidation(ClientModelValidationContext context) // Client Side
        {
            context.Attributes.Add("data-val-checkbox", ErrorMessage);
        }
        public override bool IsValid(object value) // Server Side
        {
            return (bool)value;
        }

    }
}

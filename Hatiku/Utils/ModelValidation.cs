using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatiku.Utils
{
    public static class ModelValidation
    {
        public static void Validate(object objectModel)
        {
            string errorMessage = "";
            List<ValidationResult> validationResults = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(objectModel);
            
            if(Validator.TryValidateObject(objectModel, validationContext, validationResults, true))
            {
                foreach(var item in validationResults)
                    errorMessage += $"- {item.ErrorMessage}\n";
                throw new Exception(errorMessage);
            }
        }
    }
}

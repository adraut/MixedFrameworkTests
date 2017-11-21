using System;

namespace Consumer.Core
{
    public class Validated
    {
        private Lib.Core.Validator _validator;

        public Validated()
        {
            _validator = new Lib.Core.Validator();
        }

        public System.ComponentModel.DataAnnotations.ValidationResult Validate()
        {
            return _validator.Validate();
        }
    }
}

using System;

namespace Consumer.Full
{
    public class FullyValidated
    {
        private Core.Validated _validated;

        public FullyValidated()
        {
            _validated = new Core.Validated();
        }

        public System.ComponentModel.DataAnnotations.ValidationResult Validate()
        {
            return _validated.Validate();
        }
    }
}

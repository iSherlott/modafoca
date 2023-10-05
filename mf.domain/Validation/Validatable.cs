using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mf.domain.Validation
{
    public class Validatable
    {
        public List<string> Errors { get; private set; } = new List<string>();
        public bool isValid { get; private set; } = true;
        public void addError(string error) 
        { 
            this.isValid = false;
            Errors.Add(error); 
        }
        public void addErrors(List<string> errors)
        {
            this.isValid = false;
            this.Errors.AddRange(errors);
        }
    }
}

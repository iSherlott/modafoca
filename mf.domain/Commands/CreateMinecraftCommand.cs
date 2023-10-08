using mf.domain.Commands.Contracts;
using mf.domain.Validation;

namespace mf.domain.Commands 
{
    public class CreateMinecraftCommand : ValidatableTypes, ICommand
    {

        public CreateMinecraftCommand(string name, Guid id)
        {
            this.name = name;
            this.id = id;
        }

        public string name { get; set; }
        public Guid id { get; set; }
        
        public bool isCommandvalid() 
        {
            ValidateStringNotEmpty(name, "Name");
            ValidateGuidNotEmpty(id, "Id");

            return this.isValid;
        }
    }
}

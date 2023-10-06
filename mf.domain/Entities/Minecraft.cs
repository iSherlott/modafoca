using System.ComponentModel.DataAnnotations.Schema;

namespace mf.domain.Entities
{
    [Table("users", Schema = "minecraft")]
    public class Minecraft : BaseEntity
    {
        public string name { get; private set; }
        public void setName(string name) { this.name = name; }
    }

}

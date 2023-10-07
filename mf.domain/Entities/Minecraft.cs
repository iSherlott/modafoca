using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf.domain.Entities
{
    [Table("users", Schema = "minecraft")]
    public class Minecraft : BaseEntity
    {
        [Required] 
        public new Guid id { get; set; }
        public string name { get; set; }
    }

}

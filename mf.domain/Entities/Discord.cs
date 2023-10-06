using System.ComponentModel.DataAnnotations.Schema;

namespace mf.domain.Entities
{
    [Table("users", Schema = "discord")]
    public class Discord : BaseEntity
    {
        public string username { get; private set; }
        public string? tag { get; private set; }
        public int wallet { get; private set; }
        public bool active { get; private set; }

        public void setUsername(string username) { this.username = username; }
        public void setTag(string tag) { this.tag = tag; }
        public void setWallet(int wallet) { this.wallet = wallet; }
        public void setActive(bool active) { this.active = active; }
    }
}

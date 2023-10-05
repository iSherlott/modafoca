using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mf.domain.Entities
{
    public class Minecraft : BaseEntity
    {
        public string name { get; private set; }
        public void setName(string name) { this.name = name; }
    }

}

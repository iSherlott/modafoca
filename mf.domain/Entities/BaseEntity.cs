using mf.domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mf.domain.Entities
{
    public class BaseEntity : Validatable
    {
        public Guid id { get; private set; }
        public DateTime created { get; private set; }
        public DateTime update { get; private set; }
        public BaseEntity()
        {
        }

        public void setId(Guid id) { this.id = id; }
        public void setCreated(DateTime created) { this.created = created; }
        public void setUpdate(DateTime update) {  this.update = update; }
    }
}

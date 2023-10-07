using mf.domain.Validation;

namespace mf.domain.Entities
{
    public class BaseEntity : Validatable
    {
        public Guid id { get; set; }
        public DateTime created { get; private set; }
        public DateTime? update { get; private set; }
        public BaseEntity()
        {
            created = DateTime.Now;
            update = null; 
        }

        public void setCreated(DateTime created) { this.created = created; }
        public void setUpdate(DateTime update) {  this.update = update; }


    }
}

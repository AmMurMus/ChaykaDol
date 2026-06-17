using System.Collections.Generic;

namespace ChaykaDol.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AgeRange { get; set; }
        public string Building { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}
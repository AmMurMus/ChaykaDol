using System;

namespace ChaykaDol.Models
{
    public class HealthRequest
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public string Complaint { get; set; }
        public string Diagnosis { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Child Child { get; set; }
    }
}
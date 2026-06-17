using System;

namespace ChaykaDol.Models
{
    public class Child
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string ParentPhone { get; set; }
        public string Status { get; set; }
        public string RoomNumber { get; set; }
        public int GroupId { get; set; }
        public virtual Group Group { get; set; }
    }
}
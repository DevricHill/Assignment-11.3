using System.ComponentModel.DataAnnotations;

namespace Assignment_11._3.Model
{
    public class Food
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public DateOnly TimeCreate { get; set; }
        public DateOnly? TimeExpiring { get; set; }
    }
}

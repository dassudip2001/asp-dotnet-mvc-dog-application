using System;
namespace Employee.Models
{
    public record Employee
    {
   
        public int ID { get; init; }
        
        public String Name { get; init; }

        public String Description { get; set; }

        public String Email { get; set; }

        public DateTime CreatedDate { get; set; } =DateTime.Now;

    }
    
}
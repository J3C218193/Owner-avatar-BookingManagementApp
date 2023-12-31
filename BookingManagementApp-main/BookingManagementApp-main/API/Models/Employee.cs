using System.ComponentModel.DataAnnotations.Schema;
namespace API.Models;
{
    public class Employee 
    {
        
        public Guid Guid { get; set; }
        public string NIK {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public DateTime HiringDate {  get; set; }
        public string Email { get; set; }
        public string phoneNumber {  get; set; }        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        
    }
}

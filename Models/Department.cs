using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace webapp.Models
{
    public class Department
    {
        public int Id { get; set; }

       
        
        [MinLength(2, ErrorMessage = "full name mustn't be less than 2 characters")]
        [MaxLength(20, ErrorMessage = "full name mustn'texceed 20 characters")]
        public string Name { get; set; }
        [MinLength(2, ErrorMessage = " Description mustn't be less than 2 characters")]
        [MaxLength(50, ErrorMessage = "Description mustn'texceed 20 characters")]
        public string Description { get; set; }

        //nevigation property
        [ValidateNever]
        public List<Employee> Employees { get; set; }
    }
}

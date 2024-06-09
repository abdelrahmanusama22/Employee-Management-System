using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Employee
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage ="You have to provide a valid full name")]
        [MinLength(8,ErrorMessage ="full name mustn't be less than 8 characters")]
        [MaxLength(50,ErrorMessage = "full name mustn'texceed 50 characters")]
        public String FullName { get; set; }

        [DisplayName("Job")]
        [Required(ErrorMessage ="you have to provide a valid position")]
        [MinLength(2, ErrorMessage = "full name mustn't be less than 2 characters")]
        [MaxLength(20, ErrorMessage = "full name mustn'texceed 20 characters")]
        public String Position { get; set; }

        [DisplayName("amount")]
        [Range(5000,50000,ErrorMessage ="salary must be between 5000 EGP and 50000 EGP")]
        public decimal  Salary { get; set; }

        [Range(0,100,ErrorMessage = "Appraisal must be between 0  and 100 ")]
        public byte Appraisal { get; set; }

        [DisplayName("birthdate")]
        public DateTime birthdate { get; set; }


        [DisplayName("joinDateTime")]
        public DateTime joinDateTime { get; set; }
        public bool IsActive { get; set; }
        [DisplayName("Department")]
        [Range(0,int.MaxValue , ErrorMessage = "Select Department ")]

        public int DepartmentId { get; set; }
        [ValidateNever]
        public Department Department { get; set; }
    }
}

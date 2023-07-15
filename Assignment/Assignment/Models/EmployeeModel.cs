using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name must be fill up")]
        [MinLength(3, ErrorMessage = "Must contain at least 3 characters")]
        [MaxLength(40, ErrorMessage = "More than 40 character is not allow")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "The First Name can only contain letters and spaces.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name must be fill up")]
        [MinLength(3, ErrorMessage = "Must contain at least 3 characters")]
        [MaxLength(40, ErrorMessage = "More than 40 character is not allow")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "The Last Name can only contain letters and spaces.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "Enter a valid phone number")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        public int Type { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        [Range(5000, double.MaxValue, ErrorMessage = "Salary can't be negative number and less than 5000")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        public int Designation { get; set; }

        [Required(ErrorMessage = "Must be fill up")]
        public int Department { get; set; }
    }
}
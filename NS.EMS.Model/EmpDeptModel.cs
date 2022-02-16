using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NS.EMS.Model
{
    public class EmpDeptModel
    {
        [Key]
       
        public int EID { get; set; }
        
        [Required(ErrorMessage = "The Name is required.")]
        public string EmployeeName { get; set; }
        [Required(ErrorMessage = "The Email is required.")]
        [EmailAddress(ErrorMessage = "Email is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "The Gender is required.")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "The Mobile is required.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter PhoneNumber as 0123456789, 012-345-6789, (012)-345-6789.")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "The Department Id is required.")]

        public int DeptId { get; set; }  
        public string DeptName { get; set; }


        
       

    }
  
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{   
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class User
    {
    }
    //Validate user model
    public class EmployeeMetaData
    {    
        [Display(Name ="First name")]
        [Required (AllowEmptyStrings =false, ErrorMessage ="Please provide first name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide last name")]
        public string LastName { get; set; }
        [Display(Name = "Contact Number")]
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^((0|(\(0\)))?|(00|(\(00\)))?(\s?|-?)(27|\(27\))|((\+27))|(\(\+27\))|\(00(\s?|-?)27\))( |-)?(\(?0?\)?)( |-)?\(?(1[0-9]|2[1-4,7-9]|3[1-6,9]|4[0-9]|5[1,3,6-9]|7[1-4,6,8,9]|8[0-9])\)?(\s?|-?)((\d{3}(\s?|-?)\d{4}$)|((\d{4})(\s?|-?)(\d{3})$)|([0-2](\s?|-?)(\d{3}(\s?|-?)\d{3}$)))", ErrorMessage ="Enter a valid contact number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter a valid email")]
        public string Email { get; set; }
        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}
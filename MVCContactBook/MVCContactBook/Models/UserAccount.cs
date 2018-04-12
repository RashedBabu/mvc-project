using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCContactBook.Models
{
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage ="Frist name is Required")]
        public string FristName { get; set; }

        [Required(ErrorMessage = "Last name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email ID is Required")]

        public string EmailID { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
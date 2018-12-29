using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace E3403.Models {
    public class Account {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "This checkbox is required")]
        public bool? IAgree { get; set; }

        [Required(ErrorMessage = "Any Date is required")]
        public DateTime? AnyDate { get; set; }
        [Required(ErrorMessage = "States is required")]
        public string States { get; set; }

        [Required(ErrorMessage = "E-mail is required")]
        [RegularExpression("\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Invalid E-Mail")]
        public string Email { get; set; }
    }
}
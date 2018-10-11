using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace _18OCT10.Models
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string phoneNum { get; set; }

        [Required(ErrorMessage = "Please enter your E-Mail.")]
        public string eMail { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string address { get; set; }

        [Required(ErrorMessage = "Please enter your driving license forename.")]
        public string drvLic1 { get; set; }

        [Required(ErrorMessage = "Please enter your driving license lastname.")]
        public string drvLic2 { get; set; }

        [Required(ErrorMessage = "Please enter your driving license birthday.")]
        public string drvLic3 { get; set; }

        [Required(ErrorMessage = "Please enter your driving license date of acquisition.")]
        public string drvLic4a { get; set; }

        [Required(ErrorMessage = "Please enter your driving license date of expire.")]
        public string drvLic4b { get; set; }

        [Required(ErrorMessage = "Please enter your driving license authority of acquisition.")]
        public string drvLic4c { get; set; }

        [Required(ErrorMessage = "Please enter your driving license unique ID.")]
        public string drvLic4d { get; set; }

        [Required(ErrorMessage = "Please enter your driving license personal ID.")]
        public string drvLic5 { get; set; }

        [Required(ErrorMessage = "Please enter your driving license type.")]
        public string drvLic9 { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DeclanStudyGroup.Models
{
    public class MyClass
    {

        [Display(Name = "StudentNum")]
        public String StudentNum { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Email")]
        public String Email { get; set; }

        [Display(Name = "MyLink")]
        public String MyLink { get; set; }

        [Display(Name = "Delete")]
        public String Delete { get; set; }

    }
}
using System.ComponentModel.DataAnnotations; // Add to project

//Ensure that CodeLens is activated
//Select >> Tools >> Options >> Text Editor >> All Languages >> CodeLens
namespace S1L04.Models
{
    public class PersonModel
    {
        //Quick property - type "prop" press tab x2
        //Complete the property details
        //This is the "Model" of "data source"
        [Display(Name = "Student number")] //Add as decorator
        public string StuNumber { get; set; }

        [Display(Name = "First Name")] //Add as decorator
        public string FirstName { get; set; }

        [Display(Name = "Last Name")] //Add as decorator
        public string LastName { get; set; }

        [Display(Name = "Email address")] //Add as decorator
        public string Email { get; set; }

        [Display(Name = "Link to personal page")] //Add as decorator
        public string myLink { get; set; }
    }
}
using System.Collections.Generic;
using System.Web.Mvc;


namespace S1L04.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StuNumber = "u0001", FirstName = "Name 1", 
                LastName = "Surname 1", 
                Email = "person1@tuks.co.za",                 
                myLink = "~/HTML/Person01.html"
                });
            people.Add(new Models.PersonModel {
                StuNumber = "u0002",
                FirstName = "Name 2",
                LastName = "Surname 2",
                Email = "person2@tuks.co.za",
                myLink = "~/HTML/Person02.html"
            });
            people.Add(new Models.PersonModel {
                StuNumber = "u0003",
                FirstName = "Name 3",
                LastName = "Surname 3",
                Email = "person3@tuks.co.za",
                myLink = "~/HTML/Person03.html"
            });
            people.Add(new Models.PersonModel {
                StuNumber = "u0004",
                FirstName = "Name 4",
                LastName = "Surname 4",
                Email = "person4@tuks.co.za",
                myLink = "~/HTML/Person04.html"
            });
            people.Add(new Models.PersonModel {
                StuNumber = "u0005",
                FirstName = "Name 5",
                LastName = "Surname 5",
                Email = "person5@tuks.co.za",
                myLink = "~/HTML/Person05.html"
            });

            return View(people);

        }

        public ActionResult Person01()
            {

            return View();
            }

        }
}
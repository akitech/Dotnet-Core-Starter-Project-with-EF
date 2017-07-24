using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Internship.Models;
using System.Linq;
using Internship.Services;

namespace Internship.UnitTests
{
    [TestClass]
    public class UserTests
    {
        public UserTests()
        {
            InternshipContext.SetConnectionString("Server=(localdb)\\mssqllocaldb;Database=Internship_v2;Trusted_Connection=True;");
        }

        [TestMethod]
        public void CreateUser_Test()
        {
            var user = new User();
            //user.FirstName = "Tika";
            //user.LastName = "Pahadi";
            //user.Email = "tika.pahadi@selu.edu";

            //user.CurrentAddress = new Address();
            //user.CurrentAddress.AddressLine1 = "100 Royal Lane";
            //user.CurrentAddress.Zip = 70001;
            //user.CurrentAddress.City = "Dallas";
            //user.CurrentAddress.State = "TX";
            //user.CurrentAddress.Country = "USA";

            //user.PermanentAddress = new Address();
            //user.PermanentAddress.AddressLine1 = "500 Chandler Street";
            //user.PermanentAddress.Zip = 6120;
            //user.PermanentAddress.City = "Cancun";
            //user.PermanentAddress.State = "Quintana Roo";
            //user.PermanentAddress.Country = "Mexico";

            try
            {
                using(var service = new UserService(new InternshipContext()))
                {
                    service.Create(user);
                    service.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //Failed
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void GetUserByEmail_Test()
        {
            using (var service = new UserService(new InternshipContext()))
            {
                //testing method
                var user = service.GetUserByEmailAddress("tika.pahadi@selu.edu");

                //What is happening in the background:
                var user2 = new UserService(new InternshipContext())
                    .Where(x => x.Email == "tika.pahadi@selu.edu")
                    .IncludeAddress() //Basically, Fetch Address from another table
                    .FirstOrDefault();


                //testing
                //Assert.AreEqual(user.FirstName, "Tika");
                //Assert.AreEqual(user.CurrentAddress.Zip, 70001);

                //Assert.AreEqual(user2.FirstName, "Tika");
                //Assert.AreEqual(user2.Add.Zip, 70001);
                }


        }


    }
}

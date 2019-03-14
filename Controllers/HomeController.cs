using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ViewModelFun.Models;


namespace ViewModelFun
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult String()
        {
            Message someMessage = new Message()
            {
                message = "This is my random string message."
            };
            return View(someMessage);
        }
        
        [HttpGet("/numbers")]
        public IActionResult Numbers()
        {
            int[] array = {1,2,43,123,40,99,0};
            Models.Number numlist = new Models.Number(array);
            return View(numlist);
        }

        [HttpGet("/user")]
        public IActionResult User()
        {
            User aUser = new User()
            {
                FirstName = "Your First Name",
                LastName = " Your Last Name"
            };
            return View(aUser);

        }

        [HttpGet("/users")]
        public IActionResult Users()
        {
            string[] array = {"RandomName1", "RandomName2", "RandomName3", "RandomName4", "RandomName5"};
            Models.Users userlist = new Models.Users(array);
            return View(userlist);
        }
    }
}

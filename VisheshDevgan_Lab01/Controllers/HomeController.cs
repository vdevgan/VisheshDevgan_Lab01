using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using VisheshDevgan_Lab01.Models;


namespace VisheshDevgan_Lab01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            //Ternary Statement
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good Afternoon";

            return View("View");
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
     
        }
    
        [HttpPost]
        public ViewResult RsvpForm(ParticipantsResponse participantsResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(participantsResponse);
                return View("Thanks", participantsResponse);
            }
            else
            {
                //There is a validation error in the form
                return View();
            }      
        }
    
        public ViewResult ShowResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    
    
    }
}


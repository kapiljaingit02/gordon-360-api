using System.Web.Http;
using Gordon360.Models;
using Gordon360.Services;
using Gordon360.Repositories;
using Gordon360.Models.ViewModels;
using Gordon360.AuthorizationFilters;
using Gordon360.Static.Names;
using System;
using Gordon360.Exceptions.ExceptionFilters;
using Gordon360.Exceptions.CustomExceptions;
using System.Collections.Generic;
using System.Security.Claims;
using Newtonsoft.Json.Linq;
using Gordon360.Static.Data;
using System.Linq;

namespace Gordon360.ApiControllers
{
    [Authorize]
    [CustomExceptionFilter]
    [RoutePrefix("api/student-news")]
    public class StudentNewsController : ApiController
    {
        private IRoleCheckingService _roleCheckingService;

        IAccountService _accountService;

        public StudentNewsController()
        {
            IUnitOfWork _unitOfWork = new UnitOfWork();
            _accountService = new AccountService(_unitOfWork);
            _roleCheckingService = new RoleCheckingService(_unitOfWork);
        }
        
        /// <summary>
        ///     Get today's student news
        /// </summary>
        /// <returns>
        ///     A JSON object containing today's student news
        /// </returns>
        // Get today's student news
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetStudentNews()
        {
            // string result = "{  \"studentNews\": [    {      \"subject\": \"Selling Christmas Gala Ticket\",      \"submittedBy\": \"SeHee Hyung\",      \"description\": \"If you want to buy Christmas Gala ticket, email SeHee Hyung\",      \"dateSubmitted\": \"12/2/2019\"    },    {      \"subject\": \"Need more meme videos\",      \"submittedBy\": \"Michael Xiao\",      \"description\": \"Plz send me your meme videos so I can make meme compilation thx bye\",      \"dateSubmitted\": \"12/1/2019\"    },    {      \"subject\": \"We need help\",      \"submittedBy\": \"Student News Team\",      \"description\": \"Who do we talk to so we can pull student news items\",      \"dateSubmitted\": \"11/28/2019\"    },    {      \"subject\": \"Beep Beep\",      \"submittedBy\": \"TomSka\",      \"description\": \"I'm a sheep\",      \"dateSubmitted\": \"12/3/2019\"    },    {      \"subject\": \"Road Work Ahead\",      \"submittedBy\": \"Vine\",      \"description\": \"Uh, yeah, I sure hope it does!\",      \"dateSubmitted\": \"03/20/2016\"    },    {      \"subject\": \"I baked you a pie\",      \"submittedBy\": \"TomSka\",      \"description\": \"It's pie flavored\",      \"dateSubmitted\": \"01/02/2003\"    },    {      \"subject\": \"Dropped my GPA\",      \"submittedBy\": \"Nathaniel Rudenberg\",      \"description\": \"Hi all, I seem to have dropped my GPA somewhere between Lane and Jenks. It's a shiny 4.0 and I would love to have it. Please let me know if you find it!\",      \"dateSubmitted\": \"01/19/2017\"    },    {      \"subject\": \"I'm mad\",      \"submittedBy\": \"Patrick Star\",      \"description\": \"Can't see my forehead\",      \"dateSubmitted\": \"02/17/2001\"    },    {      \"subject\": \"Free food? Yeoss please!\",      \"submittedBy\": \"Geoff\",      \"description\": \"You: 'Would you like a free pizza?'\nJeff:\n'Yes' Geoff:\n'Yeoss'\",      \"dateSubmitted\": \"12/3/2019\"    }  ]}";
            // JObject response = JObject.Parse(result);
            
            IEnumerable<StudentNewsItemModel> result = null;
            if (Data.StudentNewsData != null)
            {
                System.Diagnostics.Debug.WriteLine(Data.StudentNewsData);
                result = Data.StudentNewsData;
            }
        
            return Ok(result);
        }

        /// <summary>
        ///     Submit a student news item
        /// </summary>
        /// <returns>
        ///     An HTTP result
        /// </returns>
        [HttpPost]
        [Route("submit")]
        public IHttpActionResult SubmitStudentNews([FromBody] StudentNewsItemModel newsItem)
        {
            System.Diagnostics.Debug.WriteLine(newsItem.news);
            List<StudentNewsItemModel> items;
            if (Data.StudentNewsData != null)
            {
                items = Data.StudentNewsData.ToList();
            }
            else
            {
                items = new List<StudentNewsItemModel>();
            }
            items.Add(newsItem);
            Data.StudentNewsData = items;

            return Ok();
        }
    }
}

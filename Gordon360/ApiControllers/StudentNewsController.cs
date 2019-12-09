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
            string result = "Hello World :P";

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}

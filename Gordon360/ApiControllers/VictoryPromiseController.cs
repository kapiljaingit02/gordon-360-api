using System;
using System.Security.Claims;
using System.Linq;
using Gordon360.Static.Data;
using Gordon360.Static.Names;
using System.Web.Http;
using Gordon360.Exceptions.ExceptionFilters;
using Gordon360.Repositories;
using Gordon360.Services;
using Gordon360.Exceptions.CustomExceptions;
using System.Collections.Generic;
using Gordon360.Models.ViewModels;
using System.Collections;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;

namespace Gordon360.ApiControllers
{
    [Authorize]
    [CustomExceptionFilter]
    [RoutePrefix("api/vpscore")]
    public class VictoryPromiseController : ApiController
    {
        private IVictoryPromiseService _victoryPromiseService;

        public VictoryPromiseController()
        {
            var _unitOfWork = new UnitOfWork();
            _victoryPromiseService = new VictoryPromiseService(_unitOfWork);
        }
        public VictoryPromiseController(IVictoryPromiseService victoryPromiseService)
        {
            _victoryPromiseService = victoryPromiseService;
        }

        [HttpGet]
        [Route("{id}")]
        public IHttpActionResult Get(int id)
        {
            var result = _victoryPromiseService.GetVPScores(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
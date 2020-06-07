using System.Linq;
using System.Security.Claims;
using System.Web.Http;
using Gordon360.Exceptions.ExceptionFilters;
using Gordon360.Repositories;
using Gordon360.Services;

namespace Gordon360.Controllers.Api
{
    [RoutePrefix("api/wellness")]
    [CustomExceptionFilter]
    [Authorize]
    public class WellnessController : ApiController
    {
        private IProfileService _profileService;
        private IAccountService _accountService;
        private IRoleCheckingService _roleCheckingService;

        private IWellnessService _WellnessService;

        public WellnessController()
        {
            var _unitOfWork = new UnitOfWork();
            _WellnessService = new WellnessService(_unitOfWork);
            _profileService = new ProfileService(_unitOfWork);
            _accountService = new AccountService(_unitOfWork);
            _roleCheckingService = new RoleCheckingService(_unitOfWork);
        }

        public WellnessController(IVictoryPromiseService victoryPromiseService)
        {
             _WellnessService = WellnessService;
        }

        /// <summary>
        ///  Gets current status os student
        /// </summary>
        /// <returns>A boolean</returns>
        [HttpGet]
        [Route("")]
        public IHttpActionResult Get()
        {
            var authenticatedUser = this.ActionContext.RequestContext.Principal as ClaimsPrincipal;
            var username = authenticatedUser.Claims.FirstOrDefault(x => x.Type == "user_name").Value;

            var id = _accountService.GetAccountByUsername(username).GordonID;

            var result = _WellnessService.GetStatus(id);

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
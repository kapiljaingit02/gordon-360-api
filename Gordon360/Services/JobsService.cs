using System;
using System.Collections.Generic;
using System.Linq;
using Gordon360.Models.ViewModels;
using Gordon360.Repositories;
using Gordon360.Services.ComplexQueries;
using System.Data.SqlClient;
using System.Data;
using Gordon360.Exceptions.CustomExceptions;
using Gordon360.AuthorizationFilters;
using Gordon360.Static.Names;
using Gordon360.Static.Data;
using Gordon360.Static.Methods;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Diagnostics;

/// <summary>
/// We use this service to retrieve job info
/// </summary>
namespace Gordon360.Services
{
    public class JobsService : IJobsService
    {

        // See UnitOfWork class
        private IUnitOfWork _unitOfWork;

        public JobsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<JobsViewModel> Get(int id)
        {
            var result = RawSqlQuery<JobsViewModel>.query("STUDENT_JOBS_PER_ID_NUM @ID_NUM", new SqlParameter("ID_NUM", SqlDbType.Int) { Value = id });

            if (result == null)
            {
                throw new ResourceNotFoundException() { ExceptionMessage = "Record was not found." };
            }

            return result;
        }
    }
}
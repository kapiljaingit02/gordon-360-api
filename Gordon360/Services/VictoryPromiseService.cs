using System.Collections.Generic;
using System;
using System.Linq;
using System.Web.Mvc;
using Gordon360.Models;
using Gordon360.Models.ViewModels;
using Gordon360.Repositories;
using Gordon360.Exceptions.CustomExceptions;
using Gordon360.AuthorizationFilters;
using Gordon360.Static.Names;
using Gordon360.Static.Data;
using System.Data.SqlClient;
using Gordon360.Services.ComplexQueries;
using System.Diagnostics;

namespace Gordon360.Services
{
    public class VictoryPromiseService : IVictoryPromiseService
    {
        // See UnitOfWork class
        private IUnitOfWork _unitOfWork;

        public VictoryPromiseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<VictoryPromiseViewModel> GetVPScores(int id)
        {
            var idParam = new SqlParameter("@ID", id );
            var result = RawSqlQuery<VictoryPromiseViewModel>.query("VICTORY_PROMISE_BY_STUDENT_ID @ID", idParam); //run stored procedure
            Debug.WriteLine("RESULTTTTTTT: " + result); // debug message
            

            if (result == null)
            {
                return null;
            }

            foreach (var i in result)
            {
                var please = i.ToString();
                Debug.WriteLine("Each is " + please);
            }

            return result;
        }
    }
}
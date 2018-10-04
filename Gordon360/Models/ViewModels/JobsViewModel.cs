using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gordon360.Models.ViewModels
{
    public class JobsViewModel
    {
        public string Job_Title { get; set; }
        public string Job_Department { get; set; }
        public string Job_Department_Name { get; set; }
        public System.DateTime Job_Start_Date { get; set; }
        public Nullable<System.DateTime> Job_End_Date { get; set; }
        public Nullable<System.DateTime> Job_Expected_End_Date { get; set; }

        public static implicit operator JobsViewModel(STUDENT_JOBS_PER_ID_NUM_Result jobs)
        {
            JobsViewModel vm = new JobsViewModel
            {
                Job_Title = jobs.Job_Title,
                Job_Department = jobs.Job_Department,
                Job_Department_Name = jobs.Job_Department_Name,
                Job_Start_Date = jobs.Job_Start_Date,
                Job_End_Date = jobs.Job_End_Date,
            };

            return vm;
        }
    }
}
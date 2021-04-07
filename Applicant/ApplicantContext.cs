using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CollegeApplicants 
{
    class ApplicantContext:DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApplicants
{
    class Applicant
    {
        public int ApplicantId { get; set; }
        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string Patronimic { get; set; }
        public string YearOfBirth { get; set; }
        public string YearOfGraduation { get; set; }
        public string GraduatedSchool { get; set; }
        public string ChosenSpeciality { get; set; }
        public string CodeOfClass { get; set; }
        public string EGEGrade { get; set; }



    }
}

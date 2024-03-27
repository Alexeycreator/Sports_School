using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp.Db
{
    class HospitalCard
    {
        public int HospitalCardId { get; set; }
        public string Fullname { get; set; }
        public string AddmissionToCompetitions { get; set; }
        public string Deseases { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}

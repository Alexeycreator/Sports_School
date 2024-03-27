using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp.Db
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Fullname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public string Achievements { get; set; }
        public int CoachingStaffId { get; set; }
        public CoachingStaff CoachingStaff { get; set; }
        public int KindOfSportId { get; set; }
        public KindOfSport KindOfSport { get; set; }
        public List<HospitalCard> HospitalCards { get; set; }
    }
}

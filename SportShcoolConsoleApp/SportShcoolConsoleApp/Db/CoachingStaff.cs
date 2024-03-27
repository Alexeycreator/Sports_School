using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp.Db
{
    class CoachingStaff
    {
        public int CoachingStaffId { get; set; }
        public string JobTitle { get; set; }
        public string Fullname { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Photo { get; set; }
        public string Phone { get; set; }
        public List<Student> Students { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp.Db
{
    class KindOfSport
    {
        public int KindOfSportId { get; set; }
        public int Fullname { get; set; }
        public string Name { get; set; }
        public int StudentId { get; set; }
        public List<Student> Students { get; set; }
    }
}

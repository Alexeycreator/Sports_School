using SportShcoolConsoleApp.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportShcoolConsoleApp
{
    class ActionsDb
    {
        public void CreateElement()
        {
            //using(ApplicationDbContext applicationDbContext = new ApplicationDbContext())
            //{
            //    CoachingStaff coachingStaff = new CoachingStaff { Fullname = "Костиков Виктор Николаевич", Age = 50, Sex = "м", JobTitle = "тренер", Phone = "+79201213123", Photo = "нет" };
            //    Student student = new Student { Name = "Алексей", Fullname = "Рушев Алексей Михайлович", Photo = "нет", Sex = "м", Phone = "+79209165221", Age = 23, Achievements="нет" };
            //    coachingStaff.Students.Add(student);
            //    applicationDbContext.coachingStaffs.AddRange(coachingStaff);
            //    applicationDbContext.SaveChanges();
            //}
        }
        public void DeleteElement()
        {

        }
        public void UpdateElement()
        {

        }
        public void ReadElement()
        {
            using (ApplicationDbContext applicationDbContext = new ApplicationDbContext())
            {

            }
        }
    }
}

using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.Domain.EnumerableTypes
{
    public class TimeTable
    {
        public TeacherList TeacherList { get; set; }
        public SubjectList SubjectList { get; set; }
        public TeachersSubjects TeachersSubjects { get; set; }

        public TimeTable()
        {
            TeacherList = new TeacherList();
            SubjectList = new SubjectList();
            TeachersSubjects = new TeachersSubjects();
        }

    }
}
using System;
using System.Xml.Serialization;
using InstituteDepartment.Domain.Main;

namespace InstituteDepartment.Domain.EnumerableTypes
{
    [Serializable, XmlRoot]
    public class TimeTable
    {
        [XmlElement]
        public TeacherList TeacherList { get; set; }

        [XmlElement]
        public SubjectList SubjectList { get; set; }

        [XmlElement]
        public TeachersSubjects TeachersSubjects { get; set; }


        public TimeTable()
        {
            TeacherList = new TeacherList();
            SubjectList = new SubjectList();
            TeachersSubjects = new TeachersSubjects();
        }
    }
}
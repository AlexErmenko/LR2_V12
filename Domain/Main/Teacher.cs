using System;
using System.Collections.Generic;
using System.ComponentModel;
using InstituteDepartment.Domain.Helpers;

namespace InstituteDepartment.Domain.Main
{
    [Serializable]
    public class Teacher
    {
        public Teacher()
        {
            TeacherNumber = Guid.NewGuid();
            FirstName = "";
            MiddleName = "";
            LastName = "";
        }

        [DisplayName("Номер преподавателя")]
        public Guid TeacherNumber { get; set; }

        [DisplayName("Фамилия")]
        public string MiddleName { get; set; }

        [DisplayName("Имя")]
        public string FirstName { get; set; }

        [DisplayName("Отчество")]
        public string LastName { get; set; }

        public BindingList<AcademicDegree> AcademicDegrees { get; set; } = new()
        {
            new AcademicDegree(1,
                "отсут."),
            new AcademicDegree(2,
                "к.т.н."),
            new AcademicDegree(3,
                "д.т.н.")
        };

        public BindingList<Position> Positions { get; set; } = new()
        {
            new Position(1,
                "профессор"),
            new Position(2,
                "доцент"),
            new Position(3,
                "старший преподаватель"),
            new Position(4,
                "преподаватель"),
            new Position(5,
                "ассистент")
        };


        [DisplayName("Должность")]
        public int CurrentPosition { get; set; }

        [DisplayName("Учёная степень")]
        public int CurrentAcademicDegree { get; set; }

        /*
        public override string ToString()
        {
            return $"{MiddleName} {FirstName?[0]}.{LastName?[0]}.";
        }*/
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using InstituteDepartment.Domain.EnumerableTypes;
using InstituteDepartment.Domain.Helpers;

namespace InstituteDepartment.Domain.Main
{
    [Serializable]
    public partial class TeachersSubjects
    {
        [DisplayName("Преподаватель")]
        public Guid IdTeacher { get; set; }

        [DisplayName("Предмет")]
        public Guid IdSubject { get; set; }

        
        public TeacherList TeacherList { get; set; }

        public SubjectList SubjectList { get; set; }


        [DisplayName("Тип занятия")]
        public int CurrentTypeLesson { get; set; }


        public ObservableListSource<TypeLesson> TypeOfLesson { get; set; } = new ObservableListSource<TypeLesson>()
        {
            new TypeLesson(1, "лекция"), new TypeLesson(2, "лабор.работа"), new TypeLesson(3, "практич.занятие")
        };

        [DisplayName("Номер группы")]
        public string GroupNumber { get; set; }
    }
}
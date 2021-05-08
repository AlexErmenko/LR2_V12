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

        public TeachersSubjects()
        {
            TypeOfLesson = new ObservableListSource<TypeLesson>()
            {
                new TypeLesson(1, "лекция"), new TypeLesson(2, "лабор.работа"), new TypeLesson(3, "практич.занятие")
            };
        }


        [DisplayName("Преподаватель")]
        public Guid IdTeacher { get; set; }


        [DisplayName("Предмет")]
        public Guid IdSubject { get; set; }

        
        public Teacher TeacherList { get; set; }

        public Subject SubjectList { get; set; }


        [DisplayName("Тип занятия")]
        public int CurrentTypeLesson { get; set; }


        public ObservableListSource<TypeLesson> TypeOfLesson { get; set; }

        [DisplayName("Номер группы")]
        public string GroupNumber { get; set; }

        /// <inheritdoc />
        public override string ToString()
        {
            return
                $"{nameof(IdTeacher)}: {IdTeacher}, {nameof(IdSubject)}: {IdSubject}, {nameof(TeacherList)}: {TeacherList}, {nameof(SubjectList)}: {SubjectList}, {nameof(CurrentTypeLesson)}: {CurrentTypeLesson}, {nameof(TypeOfLesson)}: {TypeOfLesson}, {nameof(GroupNumber)}: {GroupNumber}";
        }
    }
}
using System;
using System.ComponentModel;

namespace InstituteDepartment.Domain.Main
{
    [Serializable]
    public partial class Subject
    {
        private int _semesterNumber = 1;

        public Subject()
        {
            SubjectNumber = Guid.NewGuid();
            SubjectName = string.Empty;
            SpecialtyCode = string.Empty;
            SemesterNumber = 1;
            CountLabWorksHours = 0;
            CountPracticeWorksHours = 0;
            CountLectureHours = 0;
        }

        [DisplayName("Кол-во часов для лабораторных работ")]
        public int CountLabWorksHours { get; set; }


        [DisplayName("Кол-во лекционных часов")]
        public int CountLectureHours { get; set; }

        [DisplayName("Кол-во часов для практических занятий")]
        public int CountPracticeWorksHours { get; set; }

        [DisplayName("Номер семестра")]
        public int SemesterNumber
        {
            get => _semesterNumber;
            set
            {
                if (_semesterNumber > 10)
                    throw new ArgumentOutOfRangeException("Semestr number can`t be larget that 10");
                _semesterNumber = value;
            }
        }
        [DisplayName("Код специальности")] public string SpecialtyCode { get; set; }
        [DisplayName("Название предмета")] public string SubjectName { get; set; }
        [DisplayName("Номер предмета")] public Guid SubjectNumber { get; set; }
    }
}
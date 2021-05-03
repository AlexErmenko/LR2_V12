using System;
using System.ComponentModel;

namespace InstituteDepartment.Domain.Helpers
{
    [Serializable]
    public class TypeLesson
    {
        public TypeLesson(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        [DisplayName("Тип занятия")]
        public string Name { get; set; }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
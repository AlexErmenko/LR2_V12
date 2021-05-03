using System;
using System.ComponentModel;

namespace InstituteDepartment.Domain.Helpers
{
    [Serializable]
    public class AcademicDegree
    {
        public AcademicDegree()
        {
        }

        public AcademicDegree(int id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; set; }

        [DisplayName("Учёная степень")]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
using System;
using System.ComponentModel;

namespace InstituteDepartment.Domain.Helpers
{
    [Serializable]
    public class Position
    {
        public int Id { get; set; }
        
        [DisplayName("Должность")]
        public string Name { get; set; }

        public Position(int id,
            string name)
        {
            Id = id;
            Name = name;
        }

        public Position()
        {
            
        }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
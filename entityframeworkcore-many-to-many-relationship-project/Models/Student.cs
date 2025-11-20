using System.Text.Json.Serialization;

namespace entityframeworkcore_many_to_many_relationship_project.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        /// Many-to-Many Relationship
        public List<Subject>? Subjects { get; set; } // navigation property
    }
}

using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class Course : BaseEntity
    {
        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(280)]
        public string ShortDescription { get; set; } = string.Empty;
        public string LongDescription { get; set; } = string.Empty;
        public string TargetAudience { get; set; } = string.Empty;
        public string Goals { get; set; } = string.Empty;
        public string Requisits { get; set; } = string.Empty;
        public Level Level { get; set; }
    }

    public enum Level
    {
        Basic = 1,
        Intermediate = 2,
        Advanced = 3,
    }
}

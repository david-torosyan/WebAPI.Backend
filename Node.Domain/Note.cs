using System.ComponentModel.DataAnnotations;

namespace API.Domain
{
    public class Note
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
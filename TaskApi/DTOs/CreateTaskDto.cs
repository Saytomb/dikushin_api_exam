using System.ComponentModel.DataAnnotations;

namespace TaskManagerAPI.DTOs
{
    public class CreateTaskDto
    {
        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        [RegularExpression("Pending|InProgress|Completed")]
        public string Status { get; set; } = "Pending";
    }
}

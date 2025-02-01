using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public bool IsCompleted { get; set; } = false;
    }
}

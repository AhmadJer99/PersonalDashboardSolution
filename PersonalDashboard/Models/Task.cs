using System;

namespace PersonalDashboard.Models
{
    public class Task
    {
        public int TaskId {  get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }
        public DateTime DueDate { get; set; }
        public string status { get; set; }
    }
}
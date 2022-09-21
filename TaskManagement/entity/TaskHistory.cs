using System;

namespace TaskManagement.entity
{
    public class TaskHistory
    {
        public int Id { get; set; }
        public Period Period { get; set; }
        public string Reporter { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }
    }
}

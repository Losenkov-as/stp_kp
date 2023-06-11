using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorApp.Models
{
    public class AppHistory
    {
        public int Id { get; set; }

        public Maintenance Maintenance { get; set; }
        public DateTime DateOfCreate { get; set; }
        public DateTime DateOfTreatment { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfEnd { get; set; }
        public string Machine { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Author { get; set; }
        public string Dispatcher { get; set; }
        public string Executor { get; set; }
        public string TaskType { get; set; }
        public string CommentOfExecutor { get; set; }
        public string CommentOfDispatcher { get; set; }
        public string CommentOfAuthor { get; set; }
        public bool IsDeleting { get; set; }
    }
}
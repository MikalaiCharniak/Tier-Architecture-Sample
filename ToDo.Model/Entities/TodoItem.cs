﻿namespace ToDo.Model.Entities
{ 
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public byte[] Icon { get; set; }
    }
}
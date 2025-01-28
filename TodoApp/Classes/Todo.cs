using System;

namespace TodoApp.Classes;

public class Todo
{
    public int Id{get; set;}
    public string Description {get; set;} = string.Empty;
    public bool Completed{get; set; } = false;
}

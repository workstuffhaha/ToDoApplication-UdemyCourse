using System;

namespace TodoApp.Classes;

public class TodoFactory
{
    // perform CRUD operations
    // if the access specifier is not mentioned then it is private by default.
    List<Todo> todos = new() {new Todo{Id=1, Completed=true, Description="first task"}};

    public List<Todo> Get() => todos.GetRange(0, todos.Count());

    // with the help of razor we can add c# to our html
    public bool Update(bool completed, Todo todop) 
    {
        try
        {
            todop.Completed=completed;

        }
        catch { return false; }
        
        return true;
    }

    public void Delete(Todo todop) => todos.Remove(todop);

    public void Add(string desc)
    {
        //first check if the desc has stuff
        if(desc.Length==0)
        {
            throw new ArgumentException("illegal to-do description");
        }

        try
        {
            // fake create an unique id
            var id = todos.Count().Equals(0) ?  1 : (todos.Max(t=>t.Id)+1);
            var todo = new Todo{ Id=id, Completed=false, Description=desc};
            todos.Add(todo);

        }
        catch 
        {
            throw;
        }

        desc=string.Empty;
    }


}

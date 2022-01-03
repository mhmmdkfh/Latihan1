using Latihan1.Models;

namespace Latihan1.Data
{
    public class AddTodoPayload
    {
        public AddTodoPayload(Todo todo)
        {
            Todo = todo;
        }

        public Todo Todo { get; }
    }
}

using HotChocolate;
using Latihan1.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan1.Data
{
    public class Mutation
    {
        //Create
        public async Task<AddTodoPayload> AddTodoAsync(
           AddTodoInput input,
           [Service] GraphQLContext context)
        {
            var todo = new Todo
            {
                Task = input.Task,
                Completed = input.Completed,
                Created = input.Created
            };

            context.Todos.Add(todo);
            await context.SaveChangesAsync();

            return new AddTodoPayload(todo);
        }

        //Insert
        public async Task<AddTodoPayload> UpdateTodoAsync(
           AddTodoInput input,
           [Service] GraphQLContext context)
        {
            var todo = context.Todos.Where(t => t.Id == input.Id).FirstOrDefault();
            if(todo != null)
            {
                todo.Task = input.Task;
                todo.Completed = input.Completed;

                context.Todos.Update(todo);
                await context.SaveChangesAsync();
            }

            return new AddTodoPayload(todo);
        }

        //Delete
        public async Task<AddTodoPayload> DeleteTodoAsync(
            IdTodo input,
            [Service] GraphQLContext context)
        {
            var todo = context.Todos.Where(t => t.Id == input.Id).FirstOrDefault();
            if( todo != null)
            {
                context.Todos.Remove(todo);
                await context.SaveChangesAsync();
            }

            return new AddTodoPayload(todo);
        }

            

    }
}

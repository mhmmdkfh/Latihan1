using HotChocolate;
using Latihan1.Models;
using System.Linq;

namespace Latihan1.Data
{
    public class Query
    {
        public IQueryable<Todo> GetTodos([Service] GraphQLContext context) =>
            context.Todos;
    }
}

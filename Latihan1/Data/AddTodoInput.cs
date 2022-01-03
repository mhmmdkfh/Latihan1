using System;

namespace Latihan1.Data
{
    public record AddTodoInput
    (
        int? Id,
        string Task,
        int Completed,
        DateTime? Created
    );
}

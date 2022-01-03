using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;

#nullable disable

namespace Latihan1.Models
{
    public partial class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public int? Completed { get; set; }
        [GraphQLType(typeof(NonNullType<DateTimeType>))]
        public DateTime? Created { get; set; }
    }
}

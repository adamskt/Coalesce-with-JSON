using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using IntelliTect.Coalesce.DataAnnotations;

namespace Json.Test.Data.Models
{
    public abstract class FieldWork
    {
        [ListText]
        public long FieldWorkId { get; set; }

        public DateTimeOffset FieldCompletionDateTime { get; set; }

        public ICollection<Inspection> Inspections { get; set; }

    }
}
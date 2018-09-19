using IntelliTect.Coalesce.DataAnnotations;

namespace Json.Test.Data.Models
{
    public class AuditMetaData
    {
        [ListText]
        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }
    }
}
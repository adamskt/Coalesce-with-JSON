using System.ComponentModel.DataAnnotations.Schema;
using IntelliTect.Coalesce.DataAnnotations;
using Newtonsoft.Json;

namespace Json.Test.Data.Models
{
    public abstract class Inspection
    {
        [ListText]
        public long InspectionId { get; set; }

        public FieldWork ParentFieldWork { get; set; }

        [Hidden]
        public string _MetaData { get; set; }

        [NotMapped]
        public AuditMetaData MetaData {
            get => _MetaData == null ? null : JsonConvert.DeserializeObject<AuditMetaData>(_MetaData);
            set => _MetaData = JsonConvert.SerializeObject(value);
        }
    }
}
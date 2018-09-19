using System.ComponentModel.DataAnnotations;

namespace Json.Test.Data.Models
{
    public class ElectricMeterExchange : FieldWork
    {
        [StringLength(20)]
        [MaxLength(20)]
        public string MeterVoltage { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;

namespace Json.Test.Data.Models
{
    public class PostInstallAudit : Inspection
    {

        public bool? PostInstallQuestion1 { get; set; } 

        public bool? PostInstallQuestion2 { get; set; }
    }
}
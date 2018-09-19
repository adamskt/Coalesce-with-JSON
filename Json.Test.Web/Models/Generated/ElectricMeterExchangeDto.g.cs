using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Security.Claims;

namespace Json.Test.Web.Models
{
    public partial class ElectricMeterExchangeDtoGen : GeneratedDto<Json.Test.Data.Models.ElectricMeterExchange>
    {
        public ElectricMeterExchangeDtoGen() { }

        public string MeterVoltage { get; set; }
        public long? FieldWorkId { get; set; }
        public System.DateTimeOffset? FieldCompletionDateTime { get; set; }
        public System.Collections.Generic.ICollection<Json.Test.Web.Models.InspectionDtoGen> Inspections { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Json.Test.Data.Models.ElectricMeterExchange obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.MeterVoltage = obj.MeterVoltage;
            this.FieldWorkId = obj.FieldWorkId;
            this.FieldCompletionDateTime = obj.FieldCompletionDateTime;
            var propValInspections = obj.Inspections;
            if (propValInspections != null)
            {
                this.Inspections = propValInspections
                    .Select(f => f.MapToDto<Json.Test.Data.Models.Inspection, InspectionDtoGen>(context, tree?[nameof(this.Inspections)])).ToList();
            }

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Json.Test.Data.Models.ElectricMeterExchange entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            entity.MeterVoltage = MeterVoltage;
            entity.FieldWorkId = (FieldWorkId ?? entity.FieldWorkId);
            entity.FieldCompletionDateTime = (FieldCompletionDateTime ?? entity.FieldCompletionDateTime);
        }
    }
}

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
    public partial class LiveAuditDtoGen : GeneratedDto<Json.Test.Data.Models.LiveAudit>
    {
        public LiveAuditDtoGen() { }

        public bool? LiveAuditQuestion1 { get; set; }
        public bool? LiveAuditQuestion2 { get; set; }
        public long? InspectionId { get; set; }
        public Json.Test.Web.Models.FieldWorkDtoGen ParentFieldWork { get; set; }
        public string _MetaData { get; set; }
        public Json.Test.Web.Models.AuditMetaDataDtoGen MetaData { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Json.Test.Data.Models.LiveAudit obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.LiveAuditQuestion1 = obj.LiveAuditQuestion1;
            this.LiveAuditQuestion2 = obj.LiveAuditQuestion2;
            this.InspectionId = obj.InspectionId;
            this._MetaData = obj._MetaData;

            this.ParentFieldWork = obj.ParentFieldWork.MapToDto<Json.Test.Data.Models.FieldWork, FieldWorkDtoGen>(context, tree?[nameof(this.ParentFieldWork)]);


            this.MetaData = obj.MetaData.MapToDto<Json.Test.Data.Models.AuditMetaData, AuditMetaDataDtoGen>(context, tree?[nameof(this.MetaData)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Json.Test.Data.Models.LiveAudit entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            entity.LiveAuditQuestion1 = LiveAuditQuestion1;
            entity.LiveAuditQuestion2 = LiveAuditQuestion2;
            entity.InspectionId = (InspectionId ?? entity.InspectionId);
            entity._MetaData = _MetaData;
        }
    }
}

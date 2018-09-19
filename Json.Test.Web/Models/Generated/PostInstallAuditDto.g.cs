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
    public partial class PostInstallAuditDtoGen : GeneratedDto<Json.Test.Data.Models.PostInstallAudit>
    {
        public PostInstallAuditDtoGen() { }

        public bool? PostInstallQuestion1 { get; set; }
        public bool? PostInstallQuestion2 { get; set; }
        public long? InspectionId { get; set; }
        public Json.Test.Web.Models.FieldWorkDtoGen ParentFieldWork { get; set; }
        public string _MetaData { get; set; }
        public Json.Test.Web.Models.AuditMetaDataDtoGen MetaData { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Json.Test.Data.Models.PostInstallAudit obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.PostInstallQuestion1 = obj.PostInstallQuestion1;
            this.PostInstallQuestion2 = obj.PostInstallQuestion2;
            this.InspectionId = obj.InspectionId;
            this._MetaData = obj._MetaData;

            this.ParentFieldWork = obj.ParentFieldWork.MapToDto<Json.Test.Data.Models.FieldWork, FieldWorkDtoGen>(context, tree?[nameof(this.ParentFieldWork)]);


            this.MetaData = obj.MetaData.MapToDto<Json.Test.Data.Models.AuditMetaData, AuditMetaDataDtoGen>(context, tree?[nameof(this.MetaData)]);

        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Json.Test.Data.Models.PostInstallAudit entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            entity.PostInstallQuestion1 = PostInstallQuestion1;
            entity.PostInstallQuestion2 = PostInstallQuestion2;
            entity.InspectionId = (InspectionId ?? entity.InspectionId);
            entity._MetaData = _MetaData;
        }
    }
}

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
    public partial class AuditMetaDataDtoGen : GeneratedDto<Json.Test.Data.Models.AuditMetaData>
    {
        public AuditMetaDataDtoGen() { }

        public string Question1 { get; set; }
        public string Question2 { get; set; }
        public string Question3 { get; set; }
        public string Question4 { get; set; }

        /// <summary>
        /// Map from the domain object to the properties of the current DTO instance.
        /// </summary>
        public override void MapFrom(Json.Test.Data.Models.AuditMetaData obj, IMappingContext context, IncludeTree tree = null)
        {
            if (obj == null) return;
            var includes = context.Includes;

            // Fill the properties of the object.

            this.Question1 = obj.Question1;
            this.Question2 = obj.Question2;
            this.Question3 = obj.Question3;
            this.Question4 = obj.Question4;
        }

        /// <summary>
        /// Map from the current DTO instance to the domain object.
        /// </summary>
        public override void MapTo(Json.Test.Data.Models.AuditMetaData entity, IMappingContext context)
        {
            var includes = context.Includes;

            if (OnUpdate(entity, context)) return;

            entity.Question1 = Question1;
            entity.Question2 = Question2;
            entity.Question3 = Question3;
            entity.Question4 = Question4;
        }
    }
}

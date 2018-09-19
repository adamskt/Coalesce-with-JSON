
using IntelliTect.Coalesce;
using IntelliTect.Coalesce.Api;
using IntelliTect.Coalesce.Api.Controllers;
using IntelliTect.Coalesce.Api.DataSources;
using IntelliTect.Coalesce.Mapping;
using IntelliTect.Coalesce.Mapping.IncludeTrees;
using IntelliTect.Coalesce.Models;
using IntelliTect.Coalesce.TypeDefinition;
using Json.Test.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Json.Test.Web.Api
{
    [Route("api/LiveAudit")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class LiveAuditController
        : BaseApiController<Json.Test.Data.Models.LiveAudit, LiveAuditDtoGen, Json.Test.Data.AppDbContext>
    {
        public LiveAuditController(Json.Test.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<Json.Test.Data.Models.LiveAudit>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<LiveAuditDtoGen>> Get(
            long id,
            DataSourceParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<LiveAuditDtoGen>> List(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<LiveAuditDtoGen>> Save(
            LiveAuditDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource,
            IBehaviors<Json.Test.Data.Models.LiveAudit> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<LiveAuditDtoGen>> Delete(
            long id,
            IBehaviors<Json.Test.Data.Models.LiveAudit> behaviors,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);

        /// <summary>
        /// Downloads CSV of LiveAuditDtoGen
        /// </summary>
        [HttpGet("csvDownload")]
        [Authorize]
        public virtual Task<FileResult> CsvDownload(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => CsvDownloadImplementation(parameters, dataSource);

        /// <summary>
        /// Returns CSV text of LiveAuditDtoGen
        /// </summary>
        [HttpGet("csvText")]
        [Authorize]
        public virtual Task<string> CsvText(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource)
            => CsvTextImplementation(parameters, dataSource);

        /// <summary>
        /// Saves CSV data as an uploaded file
        /// </summary>
        [HttpPost("csvUpload")]
        [Authorize]
        public virtual Task<IEnumerable<ItemResult>> CsvUpload(
            IFormFile file,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource,
            IBehaviors<Json.Test.Data.Models.LiveAudit> behaviors,
            bool hasHeader = true)
            => CsvUploadImplementation(file, dataSource, behaviors, hasHeader);

        /// <summary>
        /// Saves CSV data as a posted string
        /// </summary>
        [HttpPost("csvSave")]
        [Authorize]
        public virtual Task<IEnumerable<ItemResult>> CsvSave(
            string csv,
            IDataSource<Json.Test.Data.Models.LiveAudit> dataSource,
            IBehaviors<Json.Test.Data.Models.LiveAudit> behaviors,
            bool hasHeader = true)
            => CsvSaveImplementation(csv, dataSource, behaviors, hasHeader);

        // Methods from data class exposed through API Controller.
    }
}

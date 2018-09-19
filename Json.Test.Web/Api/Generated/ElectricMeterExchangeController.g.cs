
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
    [Route("api/ElectricMeterExchange")]
    [Authorize]
    [ServiceFilter(typeof(IApiActionFilter))]
    public partial class ElectricMeterExchangeController
        : BaseApiController<Json.Test.Data.Models.ElectricMeterExchange, ElectricMeterExchangeDtoGen, Json.Test.Data.AppDbContext>
    {
        public ElectricMeterExchangeController(Json.Test.Data.AppDbContext db) : base(db)
        {
            GeneratedForClassViewModel = ReflectionRepository.Global.GetClassViewModel<Json.Test.Data.Models.ElectricMeterExchange>();
        }

        [HttpGet("get/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ElectricMeterExchangeDtoGen>> Get(
            long id,
            DataSourceParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => GetImplementation(id, parameters, dataSource);

        [HttpGet("list")]
        [Authorize]
        public virtual Task<ListResult<ElectricMeterExchangeDtoGen>> List(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => ListImplementation(parameters, dataSource);

        [HttpGet("count")]
        [Authorize]
        public virtual Task<ItemResult<int>> Count(
            FilterParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => CountImplementation(parameters, dataSource);

        [HttpPost("save")]
        [Authorize]
        public virtual Task<ItemResult<ElectricMeterExchangeDtoGen>> Save(
            ElectricMeterExchangeDtoGen dto,
            [FromQuery] DataSourceParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource,
            IBehaviors<Json.Test.Data.Models.ElectricMeterExchange> behaviors)
            => SaveImplementation(dto, parameters, dataSource, behaviors);

        [HttpPost("delete/{id}")]
        [Authorize]
        public virtual Task<ItemResult<ElectricMeterExchangeDtoGen>> Delete(
            long id,
            IBehaviors<Json.Test.Data.Models.ElectricMeterExchange> behaviors,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => DeleteImplementation(id, new DataSourceParameters(), dataSource, behaviors);

        /// <summary>
        /// Downloads CSV of ElectricMeterExchangeDtoGen
        /// </summary>
        [HttpGet("csvDownload")]
        [Authorize]
        public virtual Task<FileResult> CsvDownload(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => CsvDownloadImplementation(parameters, dataSource);

        /// <summary>
        /// Returns CSV text of ElectricMeterExchangeDtoGen
        /// </summary>
        [HttpGet("csvText")]
        [Authorize]
        public virtual Task<string> CsvText(
            ListParameters parameters,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource)
            => CsvTextImplementation(parameters, dataSource);

        /// <summary>
        /// Saves CSV data as an uploaded file
        /// </summary>
        [HttpPost("csvUpload")]
        [Authorize]
        public virtual Task<IEnumerable<ItemResult>> CsvUpload(
            IFormFile file,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource,
            IBehaviors<Json.Test.Data.Models.ElectricMeterExchange> behaviors,
            bool hasHeader = true)
            => CsvUploadImplementation(file, dataSource, behaviors, hasHeader);

        /// <summary>
        /// Saves CSV data as a posted string
        /// </summary>
        [HttpPost("csvSave")]
        [Authorize]
        public virtual Task<IEnumerable<ItemResult>> CsvSave(
            string csv,
            IDataSource<Json.Test.Data.Models.ElectricMeterExchange> dataSource,
            IBehaviors<Json.Test.Data.Models.ElectricMeterExchange> behaviors,
            bool hasHeader = true)
            => CsvSaveImplementation(csv, dataSource, behaviors, hasHeader);

        // Methods from data class exposed through API Controller.
    }
}

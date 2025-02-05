using HardkorowyKodsu.Contract.Dto.Query;
using HardkorowyKodsu.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HardkorowyKodsu.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DatabaseInfoController : ControllerBase
    {
        private readonly IDatabaseInfoRepository _databaseInfoRepository;

        public DatabaseInfoController(IDatabaseInfoRepository databaseInfoRepository)
        {
            _databaseInfoRepository = databaseInfoRepository;
        }

        [HttpGet("{databaseName?}")]
        public async Task<ActionResult<List<TableDetailsOutputDto>>> GetAllTables(string databaseName = "")
        {
            try
            {
                var tables = await _databaseInfoRepository.GetAllTablesAndViews(databaseName);

                if (tables == null)
                    return NotFound($"Database with the given name:{databaseName} has not been found");
                else
                    return Ok(tables);
            }
            catch (Exception exc)
            {
                return StatusCode(500, $"Internal server error: {exc.Message}");
            }
        }

        [HttpGet("{tableName?}")]
        public async Task<ActionResult<List<ColumnDetailsOutputDto>>> GetAllColumns(string tableName = "")
        {
            try
            {
                var columns = await _databaseInfoRepository.GetAllColumns(tableName);

                if (columns == null)
                    return NotFound($"Database table with the given name:{tableName} has not been found");
                else
                    return Ok(columns);
            }
            catch (Exception exc)
            {
                return StatusCode(500, $"Internal server error: {exc.Message}");
            }
        }
    }
}

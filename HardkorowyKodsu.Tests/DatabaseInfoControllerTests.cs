using HardkorowyKodsu.Contract.Dto.Query;
using HardkorowyKodsu.Tests.Utilities;
using HardkorowyKodsu.WebApi.Controllers;
using HardkorowyKodsu.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace HardkorowyKodsu.Tests
{
    public class DatabaseInfoControllerTests
    {
        private readonly Mock<IDatabaseInfoRepository> _mockRepo;
        private readonly DatabaseInfoController _databaseInfoController;

        public DatabaseInfoControllerTests()
        {
            _mockRepo = new Mock<IDatabaseInfoRepository>();
            _databaseInfoController = new DatabaseInfoController(_mockRepo.Object);
        }

        [Fact]
        public async Task GetAllColumns_ReturnsExpectedColumns()
        {
            //Arrange
            _mockRepo.Setup(repo => repo.GetAllColumns(""))
                .ReturnsAsync(new List<ColumnDetailsOutputDto>
                {
                    new ColumnDetailsOutputDto("tableCatalog1", "tableSchema1", "tableName1", "columnName1", "isNullable1", "dataType1"),
                    new ColumnDetailsOutputDto("tableCatalog2", "tableSchema2", "tableName2", "columnName2", "isNullable2", "dataType2"),
                    new ColumnDetailsOutputDto("tableCatalog3", "tableSchema3", "tableName3", "columnName3", "isNullable3", "dataType3")
                });

            //Act
            var result = await _databaseInfoController.GetAllColumns();
            var resultType = result.Result as OkObjectResult;
            var resultDto = resultType?.Value as List<ColumnDetailsOutputDto>;

            //Assert
            Assert.NotNull(resultDto);
            Assert.IsType<List<ColumnDetailsOutputDto>>(resultDto);
            Assert.Equal(3, resultDto.Count);

            _mockRepo.Verify(repo => repo.GetAllColumns(""), Times.Once);
        }

        [Fact]
        public async Task GetAllColumns_ReturnsEmptyList_WhenNoColumnsExist()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetAllColumns("")).ReturnsAsync(new List<ColumnDetailsOutputDto>());

            // Act
            var result = await _databaseInfoController.GetAllColumns();
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var resultDto = Assert.IsType<List<ColumnDetailsOutputDto>>(okResult.Value);

            // Assert
            Assert.Empty(resultDto);
        }

        [Fact]
        public async Task GetAllColumns_Returns500_OnException()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetAllColumns("")).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _databaseInfoController.GetAllColumns();

            // Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result.Result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public async Task GetAllTables_ReturnsExpectedColumns()
        {
            //Arrange
            _mockRepo.Setup(repo => repo.GetAllTablesAndViews(""))
                .ReturnsAsync(new List<TableDetailsOutputDto>
                {
                    new TableDetailsOutputDto("tableName1", "tableType1", "tableSchema1", "tableCatalog1"),
                    new TableDetailsOutputDto("tableName2", "tableType2", "tableSchema2", "tableCatalog2"),
                    new TableDetailsOutputDto("tableName3", "tableType3", "tableSchema3", "tableCatalog3")
                });

            //Act
            var result = await _databaseInfoController.GetAllTables("");
            var resultType = result.Result as OkObjectResult;
            var resultDto = resultType?.Value as List<TableDetailsOutputDto>;

            //Assert
            Assert.NotNull(resultDto);
            Assert.IsType<List<TableDetailsOutputDto>>(resultDto);
            Assert.Equal(3, resultDto.Count);

            _mockRepo.Verify(repo => repo.GetAllTablesAndViews(""), Times.Once);
        }

        [Fact]
        public async Task GetAllTables_ReturnsEmptyList_WhenNoColumnsExist()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetAllTablesAndViews("")).ReturnsAsync(new List<TableDetailsOutputDto>());

            // Act
            var result = await _databaseInfoController.GetAllTables();
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var resultDto = Assert.IsType<List<TableDetailsOutputDto>>(okResult.Value);

            // Assert
            Assert.Empty(resultDto);
        }

        [Fact]
        public async Task GetAllTables_Returns500_OnException()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetAllTablesAndViews("")).ThrowsAsync(new Exception("Database error"));

            // Act
            var result = await _databaseInfoController.GetAllTables();

            // Assert
            var statusCodeResult = Assert.IsType<ObjectResult>(result.Result);
            Assert.Equal(500, statusCodeResult.StatusCode);
        }
    }
}
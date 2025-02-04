using AutoMapper;
using HardkorowyKodsu.Contract.Dto.Query;
using HardkorowyKodsu.WebApi.Models;
using Microsoft.Data.SqlClient.DataClassification;

namespace HardkorowyKodsu.WebApi.Infrastructure
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TableDetails, TableDetailsOutputDto>()
                .ForMember(dest => dest.TableCatalog, opt => opt.MapFrom(src => src.Table_Catalog))
                .ForMember(dest => dest.TableSchema, opt => opt.MapFrom(src => src.Table_Schema))
                .ForMember(dest => dest.TableName, opt => opt.MapFrom(src => src.Table_Name))
                .ForMember(dest => dest.TableType, opt => opt.MapFrom(src => src.Table_Type));

            CreateMap<ColumnDetails, ColumnDetailsOutputDto>()
                .ForMember(dest => dest.TableCatalog, opt => opt.MapFrom(src => src.Table_Catalog))
                .ForMember(dest => dest.TableSchema, opt => opt.MapFrom(src => src.Table_Schema))
                .ForMember(dest => dest.TableName, opt => opt.MapFrom(src => src.Table_Name))
                .ForMember(dest => dest.ColumnName, opt => opt.MapFrom(src => src.Column_Name))
                .ForMember(dest => dest.IsNullable, opt => opt.MapFrom(src => src.IS_NULLABLE))
                .ForMember(dest => dest.DataType, opt => opt.MapFrom(src => src.DATA_TYPE));
        }
    }
}

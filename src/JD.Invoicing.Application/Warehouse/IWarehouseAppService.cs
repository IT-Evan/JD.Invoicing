using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JD.Invoicing.Warehouse.Dto;

namespace JD.Invoicing.Warehouse
{
    public interface IWarehouseAppService : IAsyncCrudAppService<//定义了CRUD方法
             WarehouseDto, //用来展示商品
             int, //Warehouse实体的主键
             PagedResultRequestDto, //获取商品的时候用于分页
             CreateUpdateWarehouseDto, //用于创建商品
             CreateUpdateWarehouseDto> //用于更新商品
    {
    }
}
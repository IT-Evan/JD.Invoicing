using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JD.Invoicing.Customer.Dto;

namespace JD.Invoicing.Customer
{
    public interface ICustomerAppService : IAsyncCrudAppService<//定义了CRUD方法
             CustomerDto, //用来展示商品
             int, //Customer实体的主键
             PagedResultRequestDto, //获取商品的时候用于分页
             CreateUpdateCustomerDto, //用于创建商品
             CreateUpdateCustomerDto> //用于更新商品
    {
    }
}
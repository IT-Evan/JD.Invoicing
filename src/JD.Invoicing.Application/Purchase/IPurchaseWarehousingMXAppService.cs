using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Purchase
{
    public interface IPurchaseWarehousingMXAppService : IAsyncCrudAppService<//定义了CRUD方法
             PurchaseWarehousingMXDto, //用来展示采购信息
             int, //实体的主键
             PagedResultRequestDto, //获取采购信息的时候用于分页
             CreateUpdatePurchaseWarehousingMXDto, //用于创建采购信息
             CreateUpdatePurchaseWarehousingMXDto> //用于更新采购信息
    {
    }
}
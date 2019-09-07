using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JD.Invoicing.Goods.Dto;

namespace JD.Invoicing.Goods
{
    public interface IGoodsAppService : IAsyncCrudAppService<//定义了CRUD方法
             GoodsDto, //用来展示商品
             int, //Goods实体的主键
             PagedResultRequestDto, //获取商品的时候用于分页
             CreateUpdateGoodsDto, //用于创建商品
             CreateUpdateGoodsDto> //用于更新商品
    {
    }
}
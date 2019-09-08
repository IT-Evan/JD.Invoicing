JD.Invoicing

介绍

ASP.NET Core教程示例 - 进销存管理系统.

软件架构

ABP / ASP.NET Core / MVC / EF Core / SQLServer / Bootstrap / jQuery / Log4Net / AutoMapper / xUnit / Shouldly

安装教程

1. 打开项目:
Visual Studio打开JD.Invoicing.sln.
2. 创建数据库:
Visual Studio/工具/NuGet包管理器/程序包管理器控制台, 依次执行两条命令.
1). PM> Add-Migration 'Initial'.
2). PM> Update-Database.
可以打开SQL Server, 查看数据库.
3. 运行项目:
F5运行即可.
用户:admin
密码:123qwe

使用说明

项目功能菜单:
1. 主页: 
仪表板/工作台.
2. 数据管理: 
商品信息
客商信息
仓库信息
3. 运营管理: 
1).采购管理
采购订单
采购入库
采购退货
2).销售管理
销售开单
销售退回
3).库存管理
报损单
报益单
库存信息
库存盘点
仓库调拨
损益报表
4. 报表: 
采购统计报表
采购分析报表
采购明细报表
销售统计报表
销售分析报表
销售明细报表
毛利统计报表
毛利分析报表
毛利明细报表
5. 系统设置: 
租户管理
用户管理
角色管理
6. 关于: 
系统相关介绍

参与贡献

1. Fork 本仓库
2. 新建 Feat_xxx 分支
3. 提交代码
4. 新建 Pull Request

![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210052_e07ee082_2265734.png "JD.Invoicing1.png")
![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210100_77827259_2265734.png "JD.Invoicing2.png")
![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210110_ba68abe8_2265734.png "JD.Invoicing3.png")
![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210117_5e0219b2_2265734.png "JD.Invoicing4.png")
![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210125_ca0c33f6_2265734.png "JD.Invoicing5.png")
![输入图片说明](https://images.gitee.com/uploads/images/2019/0908/210133_dc7465d8_2265734.png "JD.Invoicing6.png")
(function () {
    $(function () {

        var _goodsService = abp.services.app.goods;
        var _$modal = $('#GoodsCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshModuleList();
        });

        $('.delete-goods').click(function () {
            var goodsId = $(this).attr("data-goods-id");
            var goodsName = $(this).attr('data-goods-name');
            deleteGoods(goodsId, goodsName);
        });


        $('.edit-goods').click(function (e) {
            var goodsId = $(this).attr("data-goods-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Goods/EditGoodsModal?goodsId=' + goodsId,

                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#GoodsEditModal div.modal-content').html(content);
                },

                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var goods = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _goodsService.create(goods).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();

        });


        function refreshGoodsList() {
            location.reload(true); //reload page to see new user!

        }

        function deleteGoods(goodsId, goodsName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'JD'), goodsName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _goodsService.delete({
                            id: goodsId

                        }).done(function () {
                            refreshGoodsList();

                        });
                    }
                }
            );
        }
    });
})();
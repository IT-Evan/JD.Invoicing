(function () {
    $(function () {

        var _warehouseService = abp.services.app.warehouse;
        var _$modal = $('#WarehouseCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshWarehouseList();
        });

        $('.delete-warehouse').click(function () {
            var warehouseId = $(this).attr("data-warehouse-id");
            var warehouseName = $(this).attr('data-warehouse-name');
            deleteWarehouse(warehouseId, warehouseName);
        });


        $('.edit-warehouse').click(function (e) {
            var warehouseId = $(this).attr("data-warehouse-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Warehouse/EditWarehouseModal?warehouseId=' + warehouseId,

                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#WarehouseEditModal div.modal-content').html(content);
                },

                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var warehouse = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _warehouseService.create(warehouse).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();

        });


        function refreshWarehouseList() {
            location.reload(true); //reload page to see new user!

        }

        function deleteWarehouse(warehouseId, warehouseName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), warehouseName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _warehouseService.delete({
                            id: warehouseId

                        }).done(function () {
                            refreshWarehouseList();

                        });
                    }
                }
            );
        }
    });
})();
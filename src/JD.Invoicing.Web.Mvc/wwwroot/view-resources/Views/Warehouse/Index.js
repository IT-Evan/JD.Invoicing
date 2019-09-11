(function () {
    $(function () {

        var _WarehouseService = abp.services.app.Warehouse;
        var _$modal = $('#WarehouseCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshWarehouseList();
        });

        $('.delete-Warehouse').click(function () {
            var WarehouseId = $(this).attr("data-Warehouse-id");
            var WarehouseName = $(this).attr('data-Warehouse-name');
            deleteWarehouse(WarehouseId, WarehouseName);
        });


        $('.edit-Warehouse').click(function (e) {
            var WarehouseId = $(this).attr("data-Warehouse-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Warehouse/EditWarehouseModal?WarehouseId=' + WarehouseId,

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

            var Warehouse = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _WarehouseService.create(Warehouse).done(function () {
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

        function deleteWarehouse(WarehouseId, WarehouseName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), WarehouseName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _WarehouseService.delete({
                            id: WarehouseId

                        }).done(function () {
                            refreshWarehouseList();

                        });
                    }
                }
            );
        }
    });
})();
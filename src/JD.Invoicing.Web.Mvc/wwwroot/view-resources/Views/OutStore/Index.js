(function () {
    $(function () {

        var _storeService = abp.services.app.store;
        var _$modal = $('#StoreCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshStoreList();
        });

        $('.delete-store').click(function () {
            var storeId = $(this).attr("data-store-id");
            var storeName = $(this).attr('data-store-name');
            deleteStore(storeId, storeName);
        });


        $('.edit-store').click(function (e) {
            var storeId = $(this).attr("data-store-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Store/EditStoreModal?storeId=' + storeId,

                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#StoreEditModal div.modal-content').html(content);
                },

                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var store = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _storeService.create(store).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();

        });


        function refreshStoreList() {
            location.reload(true); //reload page to see new user!

        }

        function deleteStore(storeId, storeName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), storeName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _storeService.delete({
                            id: storeId

                        }).done(function () {
                            refreshStoreList();

                        });
                    }
                }
            );
        }
    });
})();
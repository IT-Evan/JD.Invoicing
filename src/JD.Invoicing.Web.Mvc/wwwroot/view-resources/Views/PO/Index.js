(function () {
    $(function () {

        var _POService = abp.services.app.PO;
        var _$modal = $('#POCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshPOList();
        });

        $('.delete-PO').click(function () {
            var POId = $(this).attr("data-PO-id");
            var POName = $(this).attr('data-PO-name');
            deletePO(POId, POName);
        });


        $('.edit-PO').click(function (e) {
            var POId = $(this).attr("data-PO-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'PO/EditPOModal?POId=' + POId,

                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#POEditModal div.modal-content').html(content);
                },

                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var PO = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _POService.create(PO).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();

        });


        function refreshPOList() {
            location.reload(true); //reload page to see new user!

        }

        function deletePO(POId, POName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), POName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _POService.delete({
                            id: POId

                        }).done(function () {
                            refreshPOList();

                        });
                    }
                }
            );
        }
    });
})();
(function () {
    $(function () {

        var _CustomerService = abp.services.app.Customer;
        var _$modal = $('#CustomerCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshCustomerList();
        });

        $('.delete-Customer').click(function () {
            var CustomerId = $(this).attr("data-Customer-id");
            var CustomerName = $(this).attr('data-Customer-name');
            deleteCustomer(CustomerId, CustomerName);
        });


        $('.edit-Customer').click(function (e) {
            var CustomerId = $(this).attr("data-Customer-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Customer/EditCustomerModal?CustomerId=' + CustomerId,

                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#CustomerEditModal div.modal-content').html(content);
                },

                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var Customer = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _CustomerService.create(Customer).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!

            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });


        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();

        });


        function refreshCustomerList() {
            location.reload(true); //reload page to see new user!

        }

        function deleteCustomer(CustomerId, CustomerName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), CustomerName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _CustomerService.delete({
                            id: CustomerId

                        }).done(function () {
                            refreshCustomerList();

                        });
                    }
                }
            );
        }
    });
})();
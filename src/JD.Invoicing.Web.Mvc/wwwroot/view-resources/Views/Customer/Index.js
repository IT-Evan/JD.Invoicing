(function () {
    $(function () {

        var _customerService = abp.services.app.customer;
        var _$modal = $('#CustomerCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
        });

        $('#RefreshButton').click(function () {
            refreshCustomerList();
        });

        $('.delete-customer').click(function () {
            var customerId = $(this).attr("data-customer-id");
            var customerName = $(this).attr('data-customer-name');
            deleteCustomer(customerId, customerName);
        });


        $('.edit-customer').click(function (e) {
            var customerId = $(this).attr("data-customer-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Customer/EditCustomerModal?customerId=' + customerId,

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

            var customer = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js         

            abp.ui.setBusy(_$modal);
            _customerService.create(customer).done(function () {
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

        function deleteCustomer(customerId, customerName) {
            abp.message.confirm(
                abp.utils.formatString(abp.localization.localize('AreYouSureWantToDelete', 'Invoicing'), customerName),

                function (isConfirmed) {
                    if (isConfirmed) {
                        _customerService.delete({
                            id: customerId

                        }).done(function () {
                            refreshCustomerList();

                        });
                    }
                }
            );
        }
    });
})();
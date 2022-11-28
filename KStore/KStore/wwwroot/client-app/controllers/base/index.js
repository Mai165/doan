var BaseController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.add-to-cart', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            $.ajax({
                url: '/Cart/AddToCart',
                type: 'post',
                data: {
                    productId: id,
                    quantity: 1,
                    color: 0,
                    size: 0
                },
                success: function (response) {
                    kstore.notify(resources["AddCartOK"], 'success');
                    loadHeaderCart();
                }
            });
        });

        $('body').on('click', '.remove-cart', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            $.ajax({
                url: '/Cart/RemoveFromCart',
                type: 'post',
                data: {
                    productId: id
                },
                success: function (response) {
                    kstore.notify(resources["RemoveCartOK"], 'success');
                    loadHeaderCart();
                }
            });
        });

        $('body').on('click', '.add-to-wish', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            var colorId = parseInt($('#ddlColorId').val());
            var sizeId = parseInt($('#ddlSizeId').val());
            $.ajax({
                url: '/UserInfo/AddToWish',
                type: 'post',
                dataType: 'json',
                data: {
                    productId: id,
                },
                success: function () {
                    kstore.notify('Product was added successful', 'success');
                    loadHeaderWish();
                }
            });
        });

        $('body').on('click', '.remove-wish', function (e) {
            e.preventDefault();
            var id = $(this).data('id');
            $.ajax({
                url: '/UserInfo/RemoveFromWish',
                type: 'post',
                data: {
                    productId: id
                },
                success: function (response) {
                    kstore.notify(resources["RemoveWishOK"], 'success');
                    loadHeaderWish();
                }
            });
        });
    }

    function loadHeaderCart() {
        $("#headerCart").load("/AjaxContent/HeaderCart");
    }
    function loadHeaderWish() {
        $("#headerWish").load("/AjaxContent/HeaderWish");
    }


}
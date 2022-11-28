﻿var ProductDetailController = function () {
    this.initialize = function () {
        registerEvents();
    }

    function registerEvents() {
        $('#btnAddToCart').on('click', function (e) {
            e.preventDefault();
            var id = parseInt($(this).data('id'));
            var colorId = parseInt($('#ddlColorId').val());
            var sizeId = parseInt($('#ddlSizeId').val());
            $.ajax({
                url: '/Cart/AddToCart',
                type: 'post',
                dataType: 'json',
                data: {
                    productId: id,
                    quantity: parseInt($('#txtQuantity').val()),
                    color: colorId,
                    size: sizeId
                },
                success: function () {
                    kstore.notify('Product was added successful', 'success');
                    loadHeaderCart();
                }
            });
        });

        $('#btnAddToWish').on('click', function (e) {
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
                    loadHeaderCart();
                }
            });
        });
    }

    function loadHeaderCart() {
        $("#headerCart").load("/AjaxContent/HeaderCart");
        $("#headerWish").load("/AjaxContent/HeaderWish");
    }
}
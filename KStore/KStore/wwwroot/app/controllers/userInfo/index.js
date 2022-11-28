var userInfoController = function () {

    this.initialize = function () {
        registerEvents();
    }
    function registerEvents() {
        $('.all-cart').on('click', function () {
            $('.wishlist-item .add-to-cart').each(function () {
                this.click();
            })
        });
    }

}

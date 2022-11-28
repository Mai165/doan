﻿var BaseController = function () {

    this.initialize = function () {
        loadAnnouncement();
        registerEvents();
    }

    function registerEvents() {
        $('body').on('click', '.btn-edit', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            $.ajax({
                type: "GET",
                url: "/Admin/Role/GetById",
                data: { id: that },
                dataType: "json",
                beforeSend: function () {
                    kstore.startLoading();
                },
                success: function (response) {
                    var data = response;
                    $('#hidId').val(data.Id);
                    $('#txtName').val(data.Name);
                    $('#txtDescription').val(data.Description);
                    $('#modal-add-edit').modal('show');
                    kstore.stopLoading();

                },
                error: function (status) {
                    kstore.notify('Có lỗi xảy ra', 'error');
                    kstore.stopLoading();
                }
            });
        });

      
    };

    function loadAnnouncement() {
        $.ajax({
            type: "GET",
            url: "/admin/announcement/GetAllPaging",
            data: {
                page: kstore.configs.pageIndex,
                pageSize: kstore.configs.pageSize
            },
            dataType: "json",
            beforeSend: function () {
                kstore.startLoading();
            },
            success: function (response) {
                var template = $('#announcement-template').html();
                var render = "";
                if (response.RowCount > 0) {
                    $('#announcementArea').show();
                    $.each(response.Results, function (i, item) {
                        render += Mustache.render(template, {
                            Content: item.Content,
                            Id: item.Id,
                            Title: item.Title,
                            FullName: item.FullName,
                            Avatar:item.Avatar
                        });
                    });
                    render += $('#announcement-tag-template').html();
                    $("#totalAnnouncement").text(response.RowCount);
                    if (render != undefined) {
                        $('#annoncementList').html(render);
                    }
                }
                else {
                    $('#announcementArea').hide();
                    $('#annoncementList').html('');
                }
                kstore.stopLoading();
            },
            error: function (status) {
                console.log(status);
            }
        });
    };

    
}
var reportController = function () {
    this.initialize = function () {
        loadBestSell();
        registerEvents();
    }

    function LoadChart(xValues, yValues, xAxes, isShow) {
        $('#myChart').remove();
        $('#report-revenues').append('<canvas id="myChart"></canvas>');
        if (!isShow) return;
        var barColors = [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)',
            'rgba(153, 102, 255, 0.2)',
            'rgba(255, 159, 64, 0.2)'
        ];

        new Chart("myChart", {
            type: "horizontalBar",
            data: {
                labels: xValues,
                datasets: [{
                    backgroundColor: barColors,
                    data: yValues
                }]
            },
            options: {
                legend: { display: false },
                title: {
                    display: true,
                    text: "Top 5 product best sell"
                },
                scales: {
                    xAxes: xAxes,
                    yAxes: [{
                        barThickness: 50
                    }]
                }
            }
        });
    }

    function registerEvents() {
        $('#txtFromDate, #txtToDate').datepicker({
            autoclose: true,
            format: 'dd/mm/yyyy'
        });

        $("#btn-search").on('click', function () {
            loadBestSell();
        });
    }

    function loadBestSell() {
        $.ajax({
            type: "GET",
            url: "/Admin/Report/GetProductReport",
            data: {
                startDate: $('#txtFromDate').val(),
                endDate: $('#txtToDate').val(),
                top: 6,
            },
            beforeSend: function () {
                kstore.startLoading();
            },
            dataType: "json",
            beforeSend: function () {
                kstore.startLoading();
            },
            success: function (response) {
                //page 1
                var xA = [];
                var yA = [];
                var render = "";
                var template = $('#table-template').html();
                $.each(response.Result, function (i, item) {
                    xA.push(item.ProductViewModel.Name)
                    yA.push(item.TotalPrice)
                });
                var xAxes = [{ ticks: { min: 0, max: Math.max(...yA) + Math.max(...yA) / 10 } }]
                LoadChart(xA, yA, xAxes, response.Result.length > 0);
                var str = `Total revenue:  ${kstore.formatNumber(response.TotalRevenue, 0)}`;
                $('#total-data').text(str);

                //page2
                $.each(response.ResultALl, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.ProductID,
                        Name: item.ProductViewModel.Name,
                        TotalQuantity: item.TotalQuantity,
                        TotalPrice: kstore.formatNumber(item.TotalPrice, 0),
                    });

                });
                if (render != '') {
                    $('#tbl-content').html(render);
                }
                kstore.stopLoading();
            },
            error: function (status) {
                console.log(status);
                kstore.stopLoading();
            }
        });
    }
}
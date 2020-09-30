$(document).ready(function () {


    $("#get-mountain-bike").on("click", function () {
        //alert("get mountain bike");
        $.ajax({
            url: '/Product/GetByCategoriesMounth',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                console.log(data);
                $(data.products).each(function(i,mountainbike) {
                    $('#mountaintableBody').append($("<tr>")
                        .append($("<td>").append(mountainbike.product_name))
                        .append($("<td>").append(mountainbike.brand_id))
                        .append($("<td>").append(mountainbike.category_id))
                        .append($("<td>").append(mountainbike.list_price)));
                });
            },
            error: function() {
                alert("Not Working GetMountainBike");
            }
        });

        $("#table-show-hide").on("click",
            function() {
                $("#mountaintableBody").toggle(1000);
            });

    });





    $("#get-road-bike").on("click", function () {
        //alert("get mountain bike");
        $.ajax({
            url: '/Product/GetByCategoriesRoad',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                console.log(data);
                $(data.products).each(function (i, roadbike) {
                    $('#roadtablebody').append($("<tr>")
                        .append($("<td>").append(roadbike.product_name))
                        .append($("<td>").append(roadbike.brand_id))
                        .append($("<td>").append(roadbike.category_id))
                        .append($("<td>").append(roadbike.list_price)));
                });
            },
            error: function () {
                alert("Not Working GetRoadBike");
            }
        });

        $("#table-show-hide-road").on("click",
            function () {
                $("#roadtablebody").toggle(1000);
            });

    });


    $("#get-kid-bike").on("click", function () {
        //alert("get mountain bike");
        $.ajax({
            url: '/Product/GetByCategoriesKid',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                console.log(data);
                $(data.products).each(function (i, kidbike) {
                    $('#kidtablebody').append($("<tr>")
                        .append($("<td>").append(kidbike.product_name))
                        .append($("<td>").append(kidbike.brand_id))
                        .append($("<td>").append(kidbike.category_id))
                        .append($("<td>").append(kidbike.list_price)));
                });
            },
            error: function () {
                alert("Not Working GetKidBike");
            }
        });

        $("#table-show-hide-kid").on("click",
            function () {
                $("#kidtablebody").toggle(1000);
            });

    });



    //devam...
    //paginationMountain


    var table = '#mountaintable';
    $('#maxRows').on('change',
        function() {
            $('.pagination').html('');
            var trnum = 0;
            var maxRows = parseInt($(this).val())
            var totalRows = $(table + ' tbody tr').length;
            $(table + ' tr:gt(0)').each(function() {
                trnum++;
                if (trnum > maxRows) {
                    $(this).hide();
                }
                if (trnum <= maxRows) {
                    $(this).show();
                }
            })
            if (totalRows > maxRows) {
                var pagenum = Math.ceil(totalRows / maxRows)
                for (var i = 1; i <= pagenum;) {
                    $('.pagination').append('<li class="page-item page-link" data-page="' +
                        i +
                        '">\<span>' +
                        i++ +
                        '<span class="sr-only ">(current)</span></span>\</li>').show();
                }
            }

            $('.pagination li:first-child').addClass('active');
            $('.pagination li').on('click',
                function() {
                    var pageNum = $(this).attr('data-page');
                    var trIndex = 0
                    $('.pagination li').removeClass('active');
                    $(this).addClass('active');
                    $(table + ' tr:gt(0)').each(function() {
                        trIndex++;
                        if (trIndex > (maxRows * pageNum) || trIndex <= ((maxRows * pageNum) - maxRows)) {
                            $(this).hide();
                        } else {
                            $(this).show();
                        }
                    });
                });
        });
    $(function() {
        $('table tr:eq(0)').prepend('<th>ID</th>');
        var id = 0;
        $('table tr:gt(0)').each(function() {
            id++
            $(this).prepend('<td>' + id + '</td>');
        });
    });





});













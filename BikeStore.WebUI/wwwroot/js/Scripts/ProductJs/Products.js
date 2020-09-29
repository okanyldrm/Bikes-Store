$(document).ready(function () {


    $("#get-mountain-bike").on("click", function () {
        //alert("get mountain bike");
        $.ajax({
            url: '/Product/GetByCategories',
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

        $("#table-show-hide").on("click", function() {
            $("#mountaintableBody").toggle();
        })
    });


});













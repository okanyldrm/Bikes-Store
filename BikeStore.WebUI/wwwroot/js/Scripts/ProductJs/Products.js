$(document).ready(function () {


    $("#mountainbike-tab").on("click", function () {
        $.ajax({
            url: '/Product/GetAll',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                console.log(data);


                //$.each(data.products, function (i,item) {
                //    //console.log(item.product_name);
                //    $("#AllProduct").append("<table class='table'><thead class='thead-dark'><tr><td>Product Name</td></tr></thead> <tbody><tr><td>" + item.product_name + "</td> </tr> </tbody></table>");
                //});
            }
        });
    });


});













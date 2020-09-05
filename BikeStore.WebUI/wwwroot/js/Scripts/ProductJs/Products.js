$(document).ready(function () {


    $("#GetProduct").on("click", function () {
        $.ajax({
            url: '/Product/GetAll',
            type: 'GET',
            dataType: 'json',
            success: function (data) {
                $.each(data.products, function (i,item) {
                    //console.log(item.product_name);
                    $("#AllProduct").append("<table class='table'><thead class='thead-dark'><tr><td>Product Name</td></tr></thead> <tbody><tr><td>" + item.product_name + "</td> </tr> </tbody></table>");
                });
            }
        });
    });


    $('#Hide-Show').on("click",
        function () {
            $("#AllProduct").toggle(500);
        });



    $("#tab").pagination({
        items: 5,
        contents: 'contents',
        previous: 'Previous',
        next: 'Next',
        position: 'bottom',
    });





});













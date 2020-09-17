


$(document).ready(function() {

    $.ajax({
        url: '/Home/GetChildrenBicycles/2',
        type: 'GET',
        dataType: 'json',
        success: function (data) {
            $.each(data.products, function (i, item) {
                //console.log(item.product_name);
               
                $("#Productbychildren").append("<table class='table'><thead class='thead-dark'><tr><td>Product Name</td><td>Model Year</td></tr></thead> <tbody><tr><td>" + item.product_name + "</td> <td>" + item.model_year + "</td> </tr> </tbody></table>");
            });
        }
    });



});
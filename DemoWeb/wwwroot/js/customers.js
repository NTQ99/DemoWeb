$(document).ready(function () {
    $(".get-btn").click(getData);
    $(".post-btn").click(postData);
});

// Lấy dữ liệu khách hàng từ server
function getData() {
    $.ajax({
        url: 'https://localhost:44384/api/customer',
        type: "GET",
        success: function (res) {
            $("tbody").append(`<tr>
                <td>${res[0]}</td>
                <td>${res[1]}</td>
                <td>${res[2]}</td>
                <td>${res[3]}</td>
            </tr>`)
        }
    })
}

//Dẩy dữ liệu khách hàng lên server
function postData() {
    $.ajax({
        url: 'https://localhost:44384/api/customer',
        type: "POST",
        data: "2",
        dataType: 'json',
        contentType: 'application/json',
        success: function (res) {
            alert(res);
        }
    })
}
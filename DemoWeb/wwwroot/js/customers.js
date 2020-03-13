$(document).ready(function () {
    $(".get-btn").click(getData);
    $(".post-btn").click(postData);
});

// Lấy dữ liệu khách hàng từ server
function getData() {
    $.ajax({
        url: 'https://localhost:44384/api/customer',
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

}
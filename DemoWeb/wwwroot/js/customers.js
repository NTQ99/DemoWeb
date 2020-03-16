$(document).ready(function () {
    $(".get-btn").click(getData);
    $(".post-btn").click(postData);
});

/**
 * Lay du lieu khach hang
 * */
function getData() {
    $.ajax({
        url: 'https://localhost:44384/api/customer',
        type: "GET",
        success: function (res) {
            res.forEach(function (value, index) {
            console.log(value);
                $("tbody").append(`<tr>
                    <td>${value.id}</td>
                    <td>${value.name}</td>
                    <td>${value.addr}</td>
                    <td>${value.phone}</td>
                </tr>`)
            });
        }
    })
}

/**
 * Gui du lieu khach hang
 * */
function postData() {
    $.ajax({
        url: 'https://localhost:44384/api/customer',
        type: "POST",
        contentType: "application/json",
        data: JSON.stringify({
            "name": "Nguyen Van GHJH",
            "addr": "HN",
            "phone": "0123456789"
        }),
        success: function (res) {
            alert(res);
        }
    })
}
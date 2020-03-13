$(document).ready(function () {
    $(".add-btn").click(addAlert);
});

function addAlert() {
    $.ajax({
        url: 'https://localhost:44384/api/demo',
        success: function (res) {
            $("tbody").append(`<tr>
                <th>${res[0]}</th>
                <th>${res[1]}</th>
                <th>${res[2]}</th>
            </tr>`)
        }
    })
}
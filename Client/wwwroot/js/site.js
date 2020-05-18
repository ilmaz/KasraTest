"use strict"

var connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build();



//ClientAddScore function
connection.on("ClientAddScore", function (hubResponse) {
    if (hubResponse === 1) {
        GetAllScore();
    }
});


//connect to the EndPoint
connection.start().then(function () {
    $('#sendButton').show();
}).catch(function (err) {
    return console.error(err.toString());
});


//add score click
$("#addScoreButton").click(function () {
    if ($('#scoreInput').val()) {
        var score = parseFloat($('#scoreInput').val());
        connection.invoke("ServerAddScore", score).catch(function (err) {
            return console.error(err.toString());
        });
    }
});

//add score click
$("#getScoreButton").click(function () {
    GetAllScore();
});

function GetAllScore() {
    $.get('/home/getall',
        function (data) {
            $("#scoreList").html(JSON.stringify(data));
        });
}
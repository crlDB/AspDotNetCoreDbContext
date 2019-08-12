"use strict";
//! App
//! version : 1.0.0
//! author  : De Bels Carl
//! license : MIT
//! date    : Q1-2019
Object.defineProperty(exports, "__esModule", { value: true });
require("../img/core2.0.png");
require("../css/site.css");
require("../../node_modules/bootstrap/dist/css/bootstrap.css");
// ophalen data
$('#btn1').click(function () {
    var data = {
        cmdNbr: 1
    };
    $.ajax({
        url: "home/creatrec1",
        data: JSON.stringify(data),
        type: 'POST',
        dataType: 'json',
        processData: false,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $("#list1").prepend("<li class=\"list-group-item\">" + data.ctxCtor + "/" + data.countRec + "</li>");
        }
    });
});
$('#btn2').click(function () {
    var data = {
        cmdNbr: 2
    };
    $.ajax({
        url: "home/creatrec2",
        data: JSON.stringify(data),
        type: 'POST',
        dataType: 'json',
        processData: false,
        contentType: 'application/json; charset=utf-8',
        success: function (data) {
            $("#list1").prepend("<li class=\"list-group-item\">" + data.ctxCtor + "/" + data.countRec + "</li>");
        }
    });
});
//# sourceMappingURL=App.js.map
//! App
//! version : 1.0.0
//! author  : De Bels Carl
//! license : MIT
//! date    : Q1-2019

import "../img/core2.0.png";
import "../css/site.css";
import "../../node_modules/bootstrap/dist/css/bootstrap.css";



// ophalen data
$('#btn1').click(() => {

    let data: toServer1 = {
        cmdNbr: 1
    };


    $.ajax({
        url: "home/creatrec1",
        data: JSON.stringify(data),
        type: 'POST',
        dataType: 'json',
        processData: false,
        contentType: 'application/json; charset=utf-8',
        success: (data: toClient1) => {

            $("#list1").prepend(`<li class="list-group-item">${data.ctxCtor}/${data.countRec}</li>`);


          

        }
    });
});

$('#btn2').click(() => {

    let data: toServer1 = {
        cmdNbr: 2
    };
    

    $.ajax({
        url: "home/creatrec2",
        data: JSON.stringify(data),
        type: 'POST',
        dataType: 'json',
        processData: false,
        contentType: 'application/json; charset=utf-8',
        success: (data: toClient1) => {

            $("#list1").prepend(`<li class="list-group-item">${data.ctxCtor}/${data.countRec}</li>`);

        }
    });
});

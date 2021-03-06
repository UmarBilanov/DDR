﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
//for details on configuring this project to bundle and minify static web assets.

$("#QueryStringEmployee").bind("click", function () {
    var url = "/Employees/Index" + window.location.search;
    window.location.href = url;
});

$("#QueryStringCrew").bind("click", function () {
    var url = "/Crews/Index" + window.location.search;
    window.location.href = url;
});

$("#QueryStringDrill").bind("click", function () {
    var url = "/Drills/Index" + window.location.search;
    window.location.href = url;
});

$("#QueryStringHole").bind("click", function () {
    var url = "/Holes/Index" + window.location.search;
    window.location.href = url;
});

$("#QueryStringEquipment").bind("click", function () {
    var url = "/Equipments/Index" + window.location.search;
    window.location.href = url;
});

$("#btnQueryStringBack").bind("click", function () {
    var QueryStringLength = window.location.search.length;
    if (QueryStringLength >= 10) {
        var url = "./?" + window.location.search.substring(window.location.search.length - 10, window.location.search.length);
        window.location.href = url;
    } else {
        var url = "./";
        window.location.href = url;
    }
});

$("#btnQueryStringBackToHoles").bind("click", function () {
    var url = "/Holes" + window.location.search;
    window.location.href = url;
});

$("#btnQueryStringBackToHome").bind("click", function () {
    var url = "/Index" + window.location.search;
    window.location.href = url;
});

$("#IndexFull").bind("click", function () {
    var QueryStringLength = window.location.search.length;
    if (QueryStringLength >= 10) {
        var url = "../CreateDailyReports/IndexFull?" + window.location.search.substring(window.location.search.length - 10, window.location.search.length);
        window.location.href = url;
    } else {
        var url = "../CreateDailyReports/IndexFull";
        window.location.href = url;
    }
});
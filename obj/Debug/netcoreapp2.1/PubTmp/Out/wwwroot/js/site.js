﻿
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
var apiBaseUrl = document.location.origin;
// Write your Javascript code.


var today = new Date();
function formatDate(date) {
    var d = new Date(date),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2) month = '0' + month;
    if (day.length < 2) day = '0' + day;

    return [year, month, day].join('-');
}

document.getElementById("TodayDate").value = formatDate(today);

function setDatePickerButtons() {
    const reportDate = document.querySelector('#TodayDate');
    const downBtn = document.querySelector('#report-date-down');
    const upBtn = document.querySelector('#report-date-up');

    upBtn.onclick = () => reportDate.stepUp(1);
    downBtn.onclick = () => reportDate.stepDown(1);
};


$("#HoleID").bind('change', function () {
    var HoleID = this.value;
    if (HoleID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("Drill").innerHTML = this.responseText
            document.getElementById("Drill").innerHTML = $('#DetailsDrill')[0].outerText;

            document.getElementById("Dip").innerHTML = this.responseText
            document.getElementById("Dip").innerHTML = $('#DetailsDip')[0].outerText;

            document.getElementById("StartDate").innerHTML = this.responseText
            document.getElementById("StartDate").innerHTML = $('#DetailsStartDate')[0].outerText;

            document.getElementById("Az").innerHTML = this.responseText
            document.getElementById("Az").innerHTML = $('#DetailsAz')[0].outerText;

            document.getElementById("Status").innerHTML = this.responseText
            document.getElementById("Status").innerHTML = $('#DetailsStatus')[0].outerText;

            document.getElementById("HoleDepth").innerHTML = this.responseText
            document.getElementById("HoleDepth").innerHTML = $('#DetailsHoleDepth')[0].outerText;

        }
    };
    xhttp.open("GET", apiBaseUrl + "/Holes/Details?id=" + HoleID, true);
    xhttp.send();

});
$("#HoleID").trigger('change');

$("#CasingToDay, #CasingToNight").on("keydown keyup", function () {
    sumCasingTT();
});

//$(".Date, .HoleID").bind('change', function () {
//    var Date = this.value;
//    var HoleID = this.value;

//    if (Date == null && HoleID == null)
//        return;

//    var xhttp = new XMLHttpRequest();
//    xhttp.onreadystatechange = function () {
//        if (this.readyState == 4 && this.status == 200) {
//            if (Date == $('#HoleId')[0].outerText && HoleID == $('#HoleId')[0].outerText)
//            {
//                 = this.responseText
//                var link = $('#DetailsDrill')[0].outerText;
//            }
//        }
//    };
//    xhttp.open("GET", apiBaseUrl + "/CreateDailyReports", true);
//    xhttp.open("GET", apiBaseUrl + "/CreateDailyReports" + xhttp.send(), true);

//});
//$(".Date, .HoleID").trigger('change');

$("#OperatorID").bind('change', function () {
    var OperatorID = this.value;
    if (OperatorID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("Name").innerHTML = this.responseText
            document.getElementById("Name").innerHTML = $('#DetailsName')[0].outerText;

            document.getElementById("Surname").innerHTML = this.responseText
            document.getElementById("Surname").innerHTML = $('#DetailsSurname')[0].outerText;

            document.getElementById("Fullname").innerHTML = this.responseText
            document.getElementById("Fullname").innerHTML = $('#DetailsFullname')[0].outerText;

            document.getElementById("Position").innerHTML = this.responseText
            document.getElementById("Position").innerHTML = $('#DetailsPosition')[0].outerText;

        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + OperatorID, true);
    xhttp.send();

});
$("#OperatorID").trigger('change');

$("#Helper1ID").bind('change', function () {
    var Helper1ID = this.value;
    if (Helper1ID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("Helper1Name").innerHTML = this.responseText
            document.getElementById("Helper1Name").innerHTML = $('#DetailsName')[0].outerText;

            document.getElementById("Helper1Surname").innerHTML = this.responseText
            document.getElementById("Helper1Surname").innerHTML = $('#DetailsSurname')[0].outerText;

            document.getElementById("Helper1Fullname").innerHTML = this.responseText
            document.getElementById("Helper1Fullname").innerHTML = $('#DetailsFullname')[0].outerText;

            document.getElementById("Helper1Position").innerHTML = this.responseText
            document.getElementById("Helper1Position").innerHTML = $('#DetailsPosition')[0].outerText;

        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper1ID, true);
    xhttp.send();

});
$("#Helper1ID").trigger('change');

$("#Helper2ID").bind('change', function () {
    var Helper2ID = this.value;
    if (Helper2ID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("Helper2Name").innerHTML = this.responseText
            document.getElementById("Helper2Name").innerHTML = $('#DetailsName')[0].outerText;

            document.getElementById("Helper2Surname").innerHTML = this.responseText
            document.getElementById("Helper2Surname").innerHTML = $('#DetailsSurname')[0].outerText;

            document.getElementById("Helper2Fullname").innerHTML = this.responseText
            document.getElementById("Helper2Fullname").innerHTML = $('#DetailsFullname')[0].outerText;

            document.getElementById("Helper2Position").innerHTML = this.responseText
            document.getElementById("Helper2Position").innerHTML = $('#DetailsPosition')[0].outerText;

        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper2ID, true);
    xhttp.send();

});
$("#Helper2ID").trigger('change');

$("#Helper3ID").bind('change', function () {
    var Helper3ID = this.value;
    if (Helper3ID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("Helper3Name").innerHTML = this.responseText
            document.getElementById("Helper3Name").innerHTML = $('#DetailsName')[0].outerText;

            document.getElementById("Helper3Surname").innerHTML = this.responseText
            document.getElementById("Helper3Surname").innerHTML = $('#DetailsSurname')[0].outerText;

            document.getElementById("Helper3Fullname").innerHTML = this.responseText
            document.getElementById("Helper3Fullname").innerHTML = $('#DetailsFullname')[0].outerText;

            document.getElementById("Helper3Position").innerHTML = this.responseText
            document.getElementById("Helper3Position").innerHTML = $('#DetailsPosition')[0].outerText;

        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper3ID, true);
    xhttp.send();

});
$("#Helper3ID").trigger('change');

$("#CrewIDDay").bind('change', function () {
    var CrewID = this.value;
    if (CrewID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            document.getElementById("DayOperator").innerHTML = this.responseText
            document.getElementById("DayOperator").innerHTML = $('#DetailsOperator')[0].outerText;

            document.getElementById("DayHelper1").innerHTML = this.responseText
            document.getElementById("DayHelper1").innerHTML = $('#DetailsHelper1')[0].outerText;

            document.getElementById("DayHelper2").innerHTML = this.responseText
            document.getElementById("DayHelper2").innerHTML = $('#DetailsHelper2')[0].outerText;

            document.getElementById("DayHelper3").innerHTML = this.responseText
            document.getElementById("DayHelper3").innerHTML = $('#DetailsHelper3')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Crews/Details?id=" + CrewID, true);
    xhttp.send();
    

    var Operator = $('#DayOperator')[0].outerText;;
    if (Operator == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("DayOperatorName").innerHTML = this.responseText
            document.getElementById("DayOperatorName").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Operator, true);
    xhttp.send();

    var Helper1 = $('#DayHelper1')[0].outerText;;
    if (Helper1 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("DayHelper1Name").innerHTML = this.responseText
            document.getElementById("DayHelper1Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper1, true);
    xhttp.send();

    var Helper2 = $('#DayHelper2')[0].outerText;;
    if (Helper2 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("DayHelper2Name").innerHTML = this.responseText
            document.getElementById("DayHelper2Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper2, true);
    xhttp.send();

    var Helper3 = $('#DayHelper3')[0].outerText;;
    if (Helper3 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("DayHelper3Name").innerHTML = this.responseText
            document.getElementById("DayHelper3Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper3, true);
    xhttp.send();
    
});
$("#CrewIDDay").trigger('change');

$("#CrewIDNight").bind('change', function () {
    var CrewID = this.value;
    if (CrewID == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("NightOperator").innerHTML = this.responseText
            document.getElementById("NightOperator").innerHTML = $('#DetailsOperator')[0].outerText;

            document.getElementById("NightHelper1").innerHTML = this.responseText
            document.getElementById("NightHelper1").innerHTML = $('#DetailsHelper1')[0].outerText;

            document.getElementById("NightHelper2").innerHTML = this.responseText
            document.getElementById("NightHelper2").innerHTML = $('#DetailsHelper2')[0].outerText;

            document.getElementById("NightHelper3").innerHTML = this.responseText
            document.getElementById("NightHelper3").innerHTML = $('#DetailsHelper3')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Crews/Details?id=" + CrewID, true);
    xhttp.send();

    var Operator = $('#NightOperator')[0].outerText;;
    if (Operator == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("NightOperatorName").innerHTML = this.responseText
            document.getElementById("NightOperatorName").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Operator, true);
    xhttp.send();

    var Helper1 = $('#NightHelper1')[0].outerText;;
    if (Helper1 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("NightHelper1Name").innerHTML = this.responseText
            document.getElementById("NightHelper1Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper1, true);
    xhttp.send();

    var Helper2 = $('#NightHelper2')[0].outerText;;
    if (Helper2 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("NightHelper2Name").innerHTML = this.responseText
            document.getElementById("NightHelper2Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper2, true);
    xhttp.send();

    var Helper3 = $('#NightHelper3')[0].outerText;;
    if (Helper3 == null)
        return;

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {

            document.getElementById("NightHelper3Name").innerHTML = this.responseText
            document.getElementById("NightHelper3Name").innerHTML = $('#DetailsFullname')[0].outerText;
        }
    };
    xhttp.open("GET", apiBaseUrl + "/Employees/Details?id=" + Helper3, true);
    xhttp.send();

});
$("#CrewIDNight").trigger('change');



$(document).ready(function () {
    //this calculates values automatically 
    sumCasingFT();
    $("#CasingFromDay, #CasingFromNight").on("keydown keyup", function () {
        sumCasingFT();
    });
});

function sumCasingFT() {
    var num1 = document.getElementById('CasingFromDay').value;
    var num2 = document.getElementById('CasingFromNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('CasingFromTotal').value = result;
    }
}

$(document).ready(function () {
    //this calculates values automatically 
    sumCasingTT();
    $("#CasingToDay, #CasingToNight").on("keydown keyup", function () {
        sumCasingTT();
    });
});

function sumCasingTT() {
    var num1 = document.getElementById('CasingToDay').value;
    var num2 = document.getElementById('CasingToNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('CasingToTotal').value = result;
    }
}

$(document).ready(function () {
    //this calculates values automatically 
    sumPreStart();
    $("#PreStartDay, #PreStartNight").on("keydown keyup", function () {
        sumPreStart();
    });

    sumCondition();
    $("#ConditionDay, #ConditionNight").on("keydown keyup", function () {
        sumCondition();
    });

    sumDrilling();
    $("#DrillingDay, #DrillingNight").on("keydown keyup", function () {
        sumDrilling();
    });

    sumReaming();
    $("#ReamingDay, #ReamingNight").on("keydown keyup", function () {
        sumReaming();
    });

    sumReamingCasing();
    $("#ReamingCasingDay, #ReamingCasingNight").on("keydown keyup", function () {
        sumReamingCasing();
    });

    sumBitChange();
    $("#BitChangeDay, #BitChangeNight").on("keydown keyup", function () {
        sumBitChange();
    });

    sumRepairs();
    $("#RepairsDay, #RepairsNight").on("keydown keyup", function () {
        sumRepairs();
    });

    sumBlast();
    $("#BlastDay, #BlastNight").on("keydown keyup", function () {
        sumBlast();
    });

    sumWaterDelay();
    $("#WaterDelayDay, #WaterDelayNight").on("keydown keyup", function () {
        sumWaterDelay();
    });

    sumAwaitingPartsMaterials();
    $("#AwaitingPartsMaterialsDay, #AwaitingPartsMaterialsNight").on("keydown keyup", function () {
        sumAwaitingPartsMaterials();
    });

    sumAwaitingMechanicElectrician();
    $("#AwaitingMechanicElectricianDay, #AwaitingMechanicElectricianNight").on("keydown keyup", function () {
        sumAwaitingMechanicElectrician();
    });

    sumAwaitingDozer();
    $("#AwaitingDozerDay, #AwaitingDozerNight").on("keydown keyup", function () {
        sumAwaitingDozer();
    });

    sumPreparationDrilling();
    $("#PreparationDrillingDay, #PreparationDrillingNight").on("keydown keyup", function () {
        sumPreparationDrilling();
    });

    sumDismantling();
    $("#DismantlingDay, #DismantlingNight").on("keydown keyup", function () {
        sumDismantling();
    });

    sumMovingRig();
    $("#MovingRigDay, #MovingRigNight").on("keydown keyup", function () {
        sumMovingRig();
    });

    sumTests();
    $("#TestsDay, #TestsNight").on("keydown keyup", function () {
        sumTests();
    });

    sumAwaitingDrillCrew();
    $("#AwaitingDrillCrewDay, #AwaitingDrillCrewNight").on("keydown keyup", function () {
        sumAwaitingDrillCrew();
    });
});

function sumPreStart() {
    var num1 = document.getElementById('PreStartDay').value;
    var num2 = document.getElementById('PreStartNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('PreStartTotal').value = result;
    }
}

function sumCondition() {
    var num1 = document.getElementById('ConditionDay').value;
    var num2 = document.getElementById('ConditionNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('ConditionTotal').value = result;
    }
}

function sumDrilling() {
    var num1 = document.getElementById('DrillingDay').value;
    var num2 = document.getElementById('DrillingNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('DrillingTotal').value = result;
    }
}

function sumReaming() {
    var num1 = document.getElementById('ReamingDay').value;
    var num2 = document.getElementById('ReamingNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('ReamingTotal').value = result;
    }
}

function sumReamingCasing() {
    var num1 = document.getElementById('ReamingCasingDay').value;
    var num2 = document.getElementById('ReamingCasingNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('ReamingCasingTotal').value = result;
    }
}

function sumBitChange() {
    var num1 = document.getElementById('BitChangeDay').value;
    var num2 = document.getElementById('BitChangeNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('BitChangeTotal').value = result;
    }
}

function sumRepairs() {
    var num1 = document.getElementById('RepairsDay').value;
    var num2 = document.getElementById('RepairsNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('RepairsTotal').value = result;
    }
}

function sumBlast() {
    var num1 = document.getElementById('BlastDay').value;
    var num2 = document.getElementById('BlastNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('BlastTotal').value = result;
    }
}

function sumWaterDelay() {
    var num1 = document.getElementById('WaterDelayDay').value;
    var num2 = document.getElementById('WaterDelayNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('WaterDelayTotal').value = result;
    }
}

function sumAwaitingPartsMaterials() {
    var num1 = document.getElementById('AwaitingPartsMaterialsDay').value;
    var num2 = document.getElementById('AwaitingPartsMaterialsNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('AwaitingPartsMaterialsTotal').value = result;
    }
}

function sumAwaitingMechanicElectrician() {
    var num1 = document.getElementById('AwaitingMechanicElectricianDay').value;
    var num2 = document.getElementById('AwaitingMechanicElectricianNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('AwaitingMechanicElectricianTotal').value = result;
    }
}

function sumAwaitingDozer() {
    var num1 = document.getElementById('AwaitingDozerDay').value;
    var num2 = document.getElementById('AwaitingDozerNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('AwaitingDozerTotal').value = result;
    }
}

function sumPreparationDrilling() {
    var num1 = document.getElementById('PreparationDrillingDay').value;
    var num2 = document.getElementById('PreparationDrillingNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('PreparationDrillingTotal').value = result;
    }
}

function sumDismantling() {
    var num1 = document.getElementById('DismantlingDay').value;
    var num2 = document.getElementById('DismantlingNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('DismantlingTotal').value = result;
    }
}

function sumMovingRig() {
    var num1 = document.getElementById('MovingRigDay').value;
    var num2 = document.getElementById('MovingRigNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('MovingRigTotal').value = result;
    }
}

function sumTests() {
    var num1 = document.getElementById('TestsDay').value;
    var num2 = document.getElementById('TestsNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('TestsTotal').value = result;
    }
}

function sumAwaitingDrillCrew() {
    var num1 = document.getElementById('AwaitingDrillCrewDay').value;
    var num2 = document.getElementById('AwaitingDrillCrewNight').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('AwaitingDrillCrewTotal').value = result;
    }
}

$(document).ready(function () {
    //this calculates values automatically 
    averageDayHours()
    $("#PreStartDay, #ConditionDay, #DrillingDay, #ReamingDay, #ReamingCasingDay, #BitChangeDay, #RepairsDay, #BlastDay, #WaterDelayDay, #AwaitingPartsMaterialsDay, #AwaitingMechanicElectricianDay, #AwaitingDozerDay, #PreparationDrillingDay, #DismantlingDay, #MovingRigDay, #TestsDay, #AwaitingDrillCrewDay").on("keydown keyup", function () {
        averageDayHours()
    });

    averageNightHours()
    $("#PreStartNight, #ConditionNight, #DrillingNight, #ReamingNight, #ReamingCasingNight, #BitChangeNight, #RepairsNight, #BlastNight, #WaterDelayNight, #AwaitingPartsMaterialsNight, #AwaitingMechanicElectricianNight, #AwaitingDozerNight, #PreparationDrillingNight, #DismantlingNight, #MovingRigNight, #TestsNight, #AwaitingDrillCrewNight").on("keydown keyup", function () {
        averageNightHours()
    });

    sumOther();
    $("#OtherDayHours, #OtherNightHours").on("keydown keyup", function () {
        sumOther();
    });
});

function averageDayHours() {
    var num1 = document.getElementById('PreStartDay').value;
    var num2 = document.getElementById('ConditionDay').value;
    var num3 = document.getElementById('DrillingDay').value;
    var num4 = document.getElementById('ReamingDay').value;
    var num5 = document.getElementById('ReamingCasingDay').value;
    var num6 = document.getElementById('BitChangeDay').value;
    var num7 = document.getElementById('RepairsDay').value;
    var num8 = document.getElementById('BlastDay').value;
    var num9 = document.getElementById('WaterDelayDay').value;
    var num10 = document.getElementById('AwaitingPartsMaterialsDay').value;
    var num11 = document.getElementById('AwaitingMechanicElectricianDay').value;
    var num12 = document.getElementById('AwaitingDozerDay').value;
    var num13 = document.getElementById('PreparationDrillingDay').value;
    var num14 = document.getElementById('DismantlingDay').value;
    var num15 = document.getElementById('MovingRigDay').value;
    var num16 = document.getElementById('TestsDay').value;
    var num17 = document.getElementById('AwaitingDrillCrewDay').value;
    var total = document.getElementById('TotalDayHours').value;
    var result = parseFloat(total) - (parseFloat(num1) + parseFloat(num2) + parseFloat(num3) + parseFloat(num4) + parseFloat(num5) + parseFloat(num6) + parseFloat(num7) + parseFloat(num8) + parseFloat(num9) + parseFloat(num10) + parseFloat(num11) + parseFloat(num12) + parseFloat(num13) + parseFloat(num14) + parseFloat(num15) + parseFloat(num16) + parseFloat(num17));

    if (!isNaN(result)) {
        if (result < 0) {
            alert("Input work hours must be less than the total work hours. Please check the inputed values.")
        }
        else {
            document.getElementById('OtherDayHours').value = result;
        }
    }
}

function averageNightHours() {
    var num1 = document.getElementById('PreStartNight').value;
    var num2 = document.getElementById('ConditionNight').value;
    var num3 = document.getElementById('DrillingNight').value;
    var num4 = document.getElementById('ReamingNight').value;
    var num5 = document.getElementById('ReamingCasingNight').value;
    var num6 = document.getElementById('BitChangeNight').value;
    var num7 = document.getElementById('RepairsNight').value;
    var num8 = document.getElementById('BlastNight').value;
    var num9 = document.getElementById('WaterDelayNight').value;
    var num10 = document.getElementById('AwaitingPartsMaterialsNight').value;
    var num11 = document.getElementById('AwaitingMechanicElectricianNight').value;
    var num12 = document.getElementById('AwaitingDozerNight').value;
    var num13 = document.getElementById('PreparationDrillingNight').value;
    var num14 = document.getElementById('DismantlingNight').value;
    var num15 = document.getElementById('MovingRigNight').value;
    var num16 = document.getElementById('TestsNight').value;
    var num17 = document.getElementById('AwaitingDrillCrewNight').value;
    var total = document.getElementById('TotalNightHours').value;
    var result = parseFloat(total) - (parseFloat(num1) + parseFloat(num2) + parseFloat(num3) + parseFloat(num4) + parseFloat(num5) + parseFloat(num6) + parseFloat(num7) + parseFloat(num8) + parseFloat(num9) + parseFloat(num10) + parseFloat(num11) + parseFloat(num12) + parseFloat(num13) + parseFloat(num14) + parseFloat(num15) + parseFloat(num16) + parseFloat(num17));

    if (!isNaN(result)) {
        if (result < 0) {
            alert("Input work hours must be less than the total work hours. Please check the inputed values.")
        }
        else {
            document.getElementById('OtherNightHours').value = result;
        }
    }
}

function sumOther() {
    var num1 = document.getElementById('OtherDayHours').value;
    var num2 = document.getElementById('OtherNightHours').value;
    var result = parseFloat(num1) + parseFloat(num2);
    if (!isNaN(result)) {
        document.getElementById('OtherTotalHours').value = result;
    }
}


//$(document).ready(function () {
//    AddOrEdit()
//    $("#TodayDate, #HoleID").on("keydown keyup", function () {
//        AddOrEdit()
//    });
//});

//function AddOrEdit() {
//    var date = document.getElementById('TodayDate').value;
//    var holeCode = document.getElementById('HoleID').value;


//    var num3 = document.getElementById('DrillingDay').value;
//    var num4 = document.getElementById('ReamingDay').value;
    
//    if (!isNaN(result)) {
//        if (result < 0) {
//            alert("Input work hours must be less than the total work hours. Please check the inputed values.")
//        }
//        else {
//            document.getElementById('OtherDayHours').value = result;
//        }
//    }

//    var HoleID = this.value;
//    if (HoleID == null)
//        return;

//    var xhttp = new XMLHttpRequest();
//    xhttp.onreadystatechange = function () {
//        if (this.readyState == 4 && this.status == 200) {
//            document.getElementById("Drill").innerHTML = this.responseText
//            document.getElementById("Drill").innerHTML = $('#DetailsDrill')[0].outerText;

//            document.getElementById("Dip").innerHTML = this.responseText
//            document.getElementById("Dip").innerHTML = $('#DetailsDip')[0].outerText;
//        }
//    };
//    xhttp.open("GET", apiBaseUrl + "/CreateDailyReports" + HoleID, true);
//    xhttp.send();
//}





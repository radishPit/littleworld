$(function () {
    //事件的委托
    initEleEvents();
});

//事件的委托
function initEleEvents() {
    $(".logininfo").mouseover(function () {
        $(this).css("color", "red");
    });
    $(".logininfo").mouseout(function () {
        $(this).css("color", "#fff");
    });

    $(".topnavitem").mouseover(function () {
        $(this).css("color", "#ff0084");
    });
    $(".topnavitem").mouseout(function () {
        $(this).css("color", "rgb(0, 154, 217)");
    });

    $(".ftMtopitem").mouseover(function () {
        $(this).css("color", "#ff0084");
    });
    $(".ftMtopitem").mouseout(function () {
        $(this).css("color", "#fff");
    });

    $(".ftMB").mouseover(function () {
        $(this).css("color", "#ff0084");
    });
    $(".ftMB").mouseout(function () {
        $(this).css("color", "#fff");
    });
}
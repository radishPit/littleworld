$(function () {  
    initEvents();
});
function initEvents() {
    $(".mainLeft3ATitle").removeClass("mainLeft3ATitleS");
    $(".mainLeft3ATitle2").addClass("mainLeft3ATitleS");
    //提交按钮的背景颜色随着鼠标的移入、移出和点击时的变化
    changeBgColor();
    //当文本获得焦点或者失去焦点时，显示和隐藏提示部分
    showHideDes();
}
//提交按钮的背景颜色随着鼠标的移入、移出和点击时的变化
function changeBgColor() {
    $(".addBtn").hover(function () {
        $(this).css("background-position", "-210px -112px");
    }, function () {
        $(this).css("background-position", "-210px -70px");
    }).mousedown(function () {
        $(this).css("background-position", "-210px -154px");
    });
}
function showHideDes() {
    $(".addDiv input").focus(function () {
        $(this).next("span").css("display", "block");
    });
    $(".addDiv input").blur(function () {
        $(this).next("span").css("display", "none");
    });
}
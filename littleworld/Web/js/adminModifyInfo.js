$(function () {
    initEvents();
});

function initEvents() {
    //当文本获得焦点或者失去焦点时，显示和隐藏提示部分
    showHideDes();
    //修改mainTitle中的内容
    $(".mainCTitle").html("&nbsp;&nbsp;修改密码");
}
function showHideDes() {
    $(".commonText").focus(function () {
        $(this).next("span").css("display", "block");
    });
    $(".commonText").blur(function () {
        $(this).next("span").css("display", "none");
    });
}
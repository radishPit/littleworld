$(function () {
    inte();
    changeheadimg();
    changenav();
});
function changeheadimg() {
    $("#headerpic").mouseover(function () {
        $("#changeimg").show();
    });
    $("#headerpic").mouseout(function () {
        $("#changeimg").hide();
    });
}
function changenav() {
    $("#nav1").click(function () {
        $(".selectnav").hide();
        $("#select1").show();
    });
    $("#nav2").click(function () {
        $(".selectnav").hide();
        $("#select2").show();
    });
    $("#nav3").click(function () {
        $(".selectnav").hide();
        $("#select3").show();
    });
}
function inte() {
    $("#btn1").click(function () {
        var btnname = $(this).attr("value");
        if (btnname == "编辑") {
            $(".info-right").hide(); ;
            $(".hidediv").show();
            $(this).attr("value", "保存");
        } else {
            $(".info-right").show(); ;
            $(".hidediv").hide();
            $(this).attr("value", "编辑");
        }

    });
}

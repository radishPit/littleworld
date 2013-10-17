$(function () {
    initEvents();
});

function initEvents() {
    //搜索框自动搜索功能，引用jQuery ui
    tags();
    //提交按钮的背景颜色随着鼠标的移入、移出和点击时的变化
    changeBgColor();
    //选项卡的使用
    tabs();
    //当文本获得焦点或者失去焦点时，显示和隐藏提示部分
    showHideDes();
}
function showHideDes() {
    $(".addDiv input").focus(function () {
        $(this).next("span").css("display", "block");
    });
    $(".addDiv input").blur(function () {
        $(this).next("span").css("display", "none");
    });
}
function tabs() {
    $("#mainNav a").click(function () {
        var nameI = $(this).attr("name");
        $("#mainNav a").css({ "background-color": "rgb(206,244,255)" });
        $(this).css({ "background-color": "rgb(105,217,236)" });
        $(".mainContent").hide();
        $("." + nameI).show();
    });
}
//提交按钮的背景颜色随着鼠标的移入、移出和点击时的变化
function changeBgColor() {
    $(".addBtn").hover(function () {
        $(this).css("background-position", "-200px -112px");
    }, function () {
        $(this).css("background-position", "-200px -70px");
    }).mousedown(function () {
        $(this).css("background-position", "-200px -154px");
    });
}
function tags() {
    var availableTags = [
	"ActionScript",
	"AppleScript",
	"Asp",
	"BASIC",
	"C",
	"C++",
	"Clojure",
	"COBOL",
	"ColdFusion",
	"Erlang",
	"Fortran",
	"Groovy",
	"Haskell",
	"Java",
	"JavaScript",
	"Lisp",
	"Perl",
	"PHP",
	"Python",
	"Ruby",
	"Scala",
	"Scheme"
	];
    $("#tags").autocomplete({
        source: availableTags
    });
}
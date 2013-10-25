$(function () {
    initEventsMaster();
});

function initEventsMaster() {
    //mainLeft3中和mainRight中，当鼠标移到导航栏时，文字变化，和当点击时，背景等样式的改变
    changeMainLeft3();
    //mainLeft3中，显示和隐藏详细菜单
    showContentMenu();
    //关闭提示框
    closeAlert();
}
//mainLeft3中，当鼠标移到导航栏时，文字变化，和当点击时，背景等样式的改变
function changeMainLeft3() {
    $(".mainLeft3ATitle").hover(function () {
        $(this).animate({ fontSize: '16px' }, "fast");
    }, function () {
        $(this).animate({ fontSize: '14px' }, "fast");
    });

    $(".mainLeft3ATitle").click(function () {
        $(".mainLeft3ATitle").removeClass("mainLeft3ATitleS");
        $(this).addClass("mainLeft3ATitleS");
    });
    //mainright中
    $(".mainRightUla").hover(function () {
        $(this).css({"background-color":"#fff","background-image":"none"});
    }, function () {
        $(this).css({ "background-image": 'url("../images/superAdminImg/shortcut-button-bg.gif")', "background-color": "rgb(247, 247, 247)" });
    });
}
//mainLeft3中，显示和隐藏详细菜单
function showContentMenu() {
    $(".mainLeft3ATitle").click(function () {
        $(".mainLeft3ATitle").next(".mainLeft3UlContent").slideUp();
        $(this).next(".mainLeft3UlContent").slideDown();
    });
}
//关闭提示框
function closeAlert() {
    $(".addAdminAlertInnerClose").click(function () {
        $(this).parent().hide();
    });
}
//显示错误提示框
function showErrorAlert(alertContent) {
    $(".addAdminAlert1").hide();
    $(".addAdminAlertFail").show();
    $(".addAdminAlertFail .addAdminAlertInner").html(alertContent);
}
//显示正确提示框
function showSuccessAlert(alertContent) {
    $(".addAdminAlert1").hide();
    $(".addAdminAlertSuccess").show();
    $(".addAdminAlertSuccess .addAdminAlertInner").html(alertContent);
}
//显示通知提示框
function showNoticeAlert(alertContent) {
    $(".addAdminAlert1").hide();
    $(".addAdminAlertNotice").show();
    $(".addAdminAlertNotice .addAdminAlertInner").html(alertContent);
}


//点击分页的页数时,改变它的样式
function clickPage(i) {
    $(".pageA").css({ "background-image": "none", "color": "rgb(87, 160, 0)" });
    $(".pageA" + i).css({ "background-image": 'url("../images/superAdminImg/bg-button-green.gif")', "color": "#fff" });
}
//菜单栏的变化
function changeMenuSeeNovelty(nowTitle) {
    $(".mainLeft3ATitle").removeClass("mainLeft3ATitleS");
    $(nowTitle).addClass("mainLeft3ATitleS");
    $(".mainLeft3ATitle").next(".mainLeft3UlContent").hide();
    $(nowTitle).next(".mainLeft3UlContent").slideDown();
}
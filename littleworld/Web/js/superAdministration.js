$(function () {
    initEventsMaster();
});

function initEventsMaster() {
    //mainLeft3中和mainRight中，当鼠标移到导航栏时，文字变化，和当点击时，背景等样式的改变
    changeMainLeft3();
    //mainLeft3中，显示和隐藏详细菜单
    showContentMenu();
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
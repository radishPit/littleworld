$(function () {
    initEvents();
});
function initEvents() {
    //菜单栏的变化
    changeMenuSeeNovelty(".mainLeft3ATitle2");
    //修改mainTitle中的内容
    $(".mainCTitle").html("&nbsp;&nbsp;查看用户信息");
    //封锁功能,就是将它的状态改为0
    fengsuoUser();
}
//封锁功能,就是将它的状态改为0
function fengsuoUser() {
    $(".adminUserFengA").load(function () {
        var stateUser = $(this).attr("thisUserState");
        if (stateUser == 1) {
            $(this).html("封锁");
        }
        else {
            $(this).html("解封");
        }

    });
    $(".adminUserFengA").click(function () {
        var userIDd = parseInt($(this).attr("thisUserID"));
        var stateUser = $(this).attr("thisUserState");
        if (stateUser == 1) {
            var indexCH = confirm("您确定要封锁该用户吗？");
            if (indexCH == true) {
                // alert("d");
                $.ajax({
                    url: "ws/adminSeeUser.asmx/fengAndJieUser",
                    type: "POST",
                    contentType: "application/json",
                    data: "{userid:" + userIDd + "}",
                    dataType: "json",
                    success: function () {
                        //alert("dd");
                        showSuccessAlert("您成功封锁该用户！");
                        location.reload();
                    }
                });
                $(this).html("解封");
            }
            else {
                showNoticeAlert("您取消了封锁该用户！");
            }
        }
        else {
            var indexCH = confirm("您确定要解封该用户吗？");
            if (indexCH == true) {
                $.ajax({
                    url: "ws/adminSeeUser.asmx/fengAndJieUser",
                    type: "POST",
                    contentType: "application/json",
                    data: "{userid:" + userIDd + "}",
                    dataType: "json",
                    success: function () {
                        //alert("dd");
                        showSuccessAlert("您成功解封该用户！");
                        location.reload();
                    }
                });
                $(this).html("封锁");
            }
            else {
                showNoticeAlert("您取消了解封该用户！");
            }
        }

    });
}
$(function () {
    initEvents();
});
function initEvents() {
    //菜单栏的变化
    changeMenuSeeNovelty(".mainLeft3ATitle3");
    //修改mainTitle中的内容
    $(".mainCTitle").html("&nbsp;&nbsp;查看新鲜事");
    //删除管理员功能,就是将它的状态改为0
    deleteNovelty();
}
function deleteNovelty() {
    $(".gvSuperAdminSeeInfoHeaderA").click(function () {
        var noveltyIDd = parseInt($(this).attr("thisNoveltyID"));
        var indexCH = confirm("您确定要屏蔽该新鲜事吗？");
        if (indexCH == true) {
            $.ajax({
                url: "ws/adminSeeNovelty.asmx/deleteNoveltyAsmx",
                type: "POST",
                contentType: "application/json",
                data: "{noveltyid:" + noveltyIDd + "}",
                dataType: "json",
                success: function () {
                    //showSuccessAlert("您成功屏蔽新鲜事" + adminName + "！");
                    //setTimeout(function () {
                        location.reload();
                    //}, 2000);  
                }        
            });
        }
        else {
            showNoticeAlert("您取消了屏蔽该新鲜事！");
        }
    });
}

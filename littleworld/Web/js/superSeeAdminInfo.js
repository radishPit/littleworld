$(function () {
    initEvents();
});
function initEvents() {
    $(".gvSuperAdminSeeInfoHeaderAD").click(function () {
        var adminID = parseInt($(this).attr("thisAdminID"));
        var adminName = $(this).attr("thisAdminName");
        var index = confirm("确认要删除账号为" + adminName + "的管理员吗？");
        if (index == true) {
            $.ajax({
                url: "ws/superSeeAdminInfo.asmx/deletAdmin",
                type: "POST",
                contentType: "application/json",
                data: "{adminid:" + adminID + "}",
                dataType: "json",
                success: function () {
                    alert("成功将" + adminName + "删除！");
                }
            });
        }
    });
}
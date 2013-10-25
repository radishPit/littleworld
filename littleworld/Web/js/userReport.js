$(function () {

    $(".cp_btn_sub").click(function () {
        $.ajax({
            url: "ws/userReport.asmx/InsertReport",
            type: "POST",
            contentType: "application/json",
            data: "{noveltyid:61,reporeterid:12,reporttime:'2013-10-23 10:11:16', reporttypeid:1,state:'举报'}",
            dataType: "json",
            success: function () {
                alert("举报成功！");
            }
        });
    });
});
    
$(function () {
    init();
});
function init() {
var id= ' <%=lblname.ClientID%> '; 
var nynam=$('#<%=txtAirTicktPrice1.ClientID%>').value; 
alert(nynam);
$.ajax({
    url: "../ws/userSpaceAblum.asmx/ShowAlumList",
    type: "POST",
    contentType: "application/json",
    data: "{userid:'5'}",
    dataType: "json",
    success: function (res) {
        var addhtml = "";
        $(res.d).each(function () {
            addhtml += '<div class="ablumlist"><div class="photobox"><div class="a-photobox1"></div><div class="a-photobox2"><i class="img_box"><img src="images/userAblumImg/status_0.png" alt="相册" /></i></div><div class="count">共0张</div></div> <div class="ablumtitle-box"><div class="titlediv"><a href="#" class="skin ablumtitle">默认相册</a></div><div class="updatetime">更新于<span></span></div></div></div>';
            $("#box-content").append(addhtml);
        });
    }


});
}

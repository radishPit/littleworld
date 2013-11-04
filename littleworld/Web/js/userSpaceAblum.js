$(function () {
    init();
});
function init() {

    $("#box-content").html("");
    alert("sdlg");
    var id= ' <%=lblname.ClientID%> '; 
   $.ajax({
    url: "../ws/userSpaceAblum.asmx/ShowAlumList",
    type: "POST",
    contentType: "application/json",
    data: "{userid:'5'}",
    dataType: "json",
    success: function (res) {
        
            $(res.d).each(function () {
                var addhtml = "";
                addhtml = '<div class="ablumlist"><div class="photobox"><div class="a-photobox1"></div><div class="a-photobox2"><i class="img_box"><img src="images/userAblumImg/status_0.png" alt="相册" /></i></div><div class="count">共0张</div></div> <div class="ablumtitle-box"><div class="titlediv"><a href="#" class="skin ablumtitle">' + this["groupName"] + '</a></div></div></div>';
                $("#box-content").append(addhtml);
            });
       
    }


});
}

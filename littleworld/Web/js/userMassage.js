$(function () {
    getmessage();
   

});

function ConvertJSONDateToJSDateObject(JSONDateString) {
    var date = new Date(parseInt(JSONDateString.replace("/Date(", "").replace(")/", ""), 10));
    
    return date;
}

function getmessage() {
    $.ajax({
        url: "ws/userMassage.asmx/Getmessage",
        type: "POST",
        contentType: "application/json",
        data: "{userid:5}",
        dataType: "json",
        success: function (res) {
            var html = "";
            $(res.d).each(function () {
                html += '<div class="WB_msg_type"><div class="msg_list_node S_line2 clearfix"><div class="id_avatar"><img width="50" height="50" src="' + this["HeadimgUrl"] + '" ></img></div><div class="msg_main"> <div class="W_f14 W_fb msg_title">' + this["OwnedName"] + ' </div> <div class="W_f14 msg_detail S_txt2">' + this["Contents"] + '</div></div> <div class="msg_ctrls"><span>' +ConvertJSONDateToJSDateObject( this["Publishtime"]) + '</span><a class="W_ico12 icon_choose" href="#"></a></div></div></div>';
            });
           
            $("#all_msg_list").html(html);
        }
    });
}


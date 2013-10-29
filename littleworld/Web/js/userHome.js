$(function () {


   
    loadthing();
    getFocus();
    submitClick();
    addImg();
    closeHover();

    addInfo();
    chooseup_click();
    unitcolor_hover();
    weibo_hide();
    WB_feed_typeHover();
    Wbface_hover();
   

   
    //
    
});

function test() {
    $(document).on("click", "hi", function () {
        alert("hi");
    });
   
}

function addInfo() {
    var userName="";
    var comments="";
    var time="";
    var supportnum="";
    var transmitnum="";
    var commentnum = "";
    var thisurl;
    var novID;
    var recept;
    var arr = new Array();
    var array = new Array();

    $.ajax({
        url: "ws/userHome.asmx/Addinfo",
        type: "POST",
        contentType: "application/json",
        data: "{sendID:5}",
        dataType: "json",

        success: function (res) {
            recept = res.d;
            var num = recept.split("%")[0]; //好友总数
            var left = recept.split("%")[1];

            for (var i = 0; i < num; i++) {
                arr[i] = left.split("@")[i]; //每个好友的新鲜事
            }
            for (var j = 0; j < arr.length; j++) {
                var novnum = arr[j].split("#+#")[0]; //每个好友新鲜事数目
                var novleft = arr[j].split("#+#")[1]; //每个好友新鲜事综合

                for (var m = 0; m < novnum; m++) {
                    array[m] = novleft.split("!=!")[m]; //每个新鲜事
                    userName = array[m].split(";")[0];
                    comments = array[m].split(";")[1];
                    time = array[m].split(";")[2];
                    supportnum = array[m].split(";")[3];
                    transmitnum = array[m].split(";")[4];
                    commentnum = array[m].split(";")[5];
                    thisurl = array[m].split(";")[6];
                    novID = array[m].split(";")[7];
                    
                    $("#news_container").append("<div class='WB_feed_type'id=" + novID + "><div class='WB_global_personcard'><div class=''></div></div><div class='WB_screen'><a href='javascript:void(0)' class='icon_chooseup' id='xiaojiantou'></a><div class='menu_small'><ul><li><a href='javascript:void(0)' class='hide'>隐藏这条微博</a> </li><li><a href='javascript:void(0)' id='pb'>屏蔽##的微博</a> </li></ul></div></div><div class='WB_feed_datail'><div class='WB_face'><a href='#' class='W_face_radius'><img width='50'height='50' src=" + thisurl + "/></a></div><div class='WB_detail'><div class='WB_info'> <a href='#' class='WB_name'>" + userName + " </a></div><div class='WB_text'>" + comments + "</div><ul class='WB_media_list'><li><div class='chePicMin'></div></li></ul><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan'><em class='icon_praised_b'></em>(" + supportnum + ")</a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>转发(" + transmitnum + ") </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>收藏 </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>评论(" + commentnum + ") </a></div><div class='WB_from'><a href='' class='WB_time'>" + time + "</a></div></div></div></div></div>");
                    //$("#news_container").append("<a href='#' class='hi'>hhhh</a>");
                    //$("#test").append("<div class='WB_feed_type'id=" + novID + "><div class='WB_global_personcard'><div class=''></div></div><div class='WB_screen'><a href='javascript:void(0)' class='icon_chooseup' id='xiaojiantou'></a><div class='menu_small'><ul><li><a href='javascript:void(0)' class='hide'>隐藏这条微博</a> </li><li><a href='javascript:void(0)' id='pb'>屏蔽##的微博</a> </li></ul></div></div><div class='WB_feed_datail'><div class='WB_face'><a href='#' class='W_face_radius'><img width='50'height='50' src=" + thisurl + "/></a></div><div class='WB_detail'><div class='WB_info'> <a href='#' class='WB_name'>" + userName + " </a></div><div class='WB_text'>" + comments + "</div><ul class='WB_media_list'><li><div class='chePicMin'></div></li></ul><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan'><em class='icon_praised_b'></em>(" + supportnum + ")</a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>转发(" + transmitnum + ") </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>收藏 </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan'>评论(" + commentnum + ") </a></div><div class='WB_from'><a href='' class='WB_time'>" + time + "</a></div></div></div></div></div>");

                }

            }


        }


    });

    
}




function Wbface_hover() {
    var index = 0;
    $(document).on("hover", ".WB_global_personcard", function () {
        index = 1;

    }, function () {

        index = 0;
    });
    $(document).on("mouseover", ".WB_face", function () {
        $(this).parent().parent().find(".WB_global_personcard").css({ visibility: "visible" });
    });
    $(document).on("mouseout", ".WB_face", function () {
        if (index == 1) {
            $(this).parent().parent().find(".WB_global_personcard").css({ visibility: "visible" });
        }
        else {
            $(this).parent().parent().find(".WB_global_personcard").css({ visibility: "hidden" });
        }
    });

}


function WB_feed_typeHover() {
    $(document).on("mouseover", ".WB_feed_type", function () {
        $(this).find(".icon_chooseup").css({ visibility: "visible" });
        $(this).find(".WB_name").addClass("wbnamecolor");
    });

    $(document).on("mouseout", ".WB_feed_type", function () {
        if (num % 2 != 1) {
            $(this).find(".icon_chooseup").css({ visibility: "hidden" });
        }
        else {
            $(this).find(".icon_chooseup").css({ visibility: "visible" });
        }
        $(this).find(".WB_name").removeClass("wbnamecolor");
    });
    
}
function weibo_hide() {
    $(document).on("click", ".hide", function () {

        $(this).parent().parent().parent().parent().prev().parent().hide();
     });
    
}

function unitcolor_hover() {
    $(document).on("mouseover", ".menu_small a", function () {
        $(this).addClass("chbg");
    });
    $(document).on("mouseout", ".menu_small a", function () {
        $(this).removeClass("chbg");
    });


}
function chPosition(obj, a, b) {
    var Xp = obj.css("background-position").split(" ")[0];
    var Yp = obj.css("background-position").split(" ")[1];
    if (a == "no") {
        Xp = Xp;
    }
    else {
        Xp = a;
    }
    if (b == "no") {
        Yp = Yp;
    }
    else {
        Yp = b;
    }
    var pos = Xp + " " + Yp;
    obj.css({ backgroundPosition: pos });
}

var num = 0;
function chooseup_click() {
    $(document).on("mouseover", ".icon_chooseup", function () {
        chPosition($(this), "-100px", "no");
    });
    $(document).on("mouseout", ".icon_chooseup", function () {
        chPosition($(this), "-75px", "no");
    });
    $(document).on("click", ".icon_chooseup", function () {
        if (num % 2 == 0) {
            chPosition($(this), "no", "-225px");
            $(this).next().show();
            WB_feed_typeHover();
        }
        else {
            chPosition($(this), "no", "-75px");
            $(this).next().hide();
        }
        num++;
    })


}

























function closeHover() {
    $(".W_close").hover(function () {
        $(this).addClass("closeh");
    }, function () {
        $(this).removeClass("closeh");
    });
    $(".W_close").click(function () {
        $(".W_layer").hide();
    });
}

function addImg() {
    $(".uploadImg").click(function () {
        $(".W_layer").show();
    });

}

function countImgs() {
    var path = "";
    var index=0;
    $(".pic_list .unique").each(function () {
       path=path+$(this).attr("src")+";";
       index++;
   });
   return path;
}

function submitClick() {
    $(".send_btn").click(function () {
        var pathstrs = countImgs();
        var txt = $(".input_detail").val();

        if (txt.length > 500) {
            alert("字符超出500");
            return;
        }
        else {
            $.ajax({
                url: "ws/userHome.asmx/AddNews",
                type: "POST",
                contentType: "application/json",
                data: "{sendID:5,state:'1',txtcomment:'" + txt + "',paths:'" + pathstrs + "'}",
                dataType: "json",
                success: function (res) {
                    alert(res.d);
                }

            });
        
        
        }
        
    });
}

function loadthing() {
    $(".input_detail").val("有些人有些事，相见不如怀念，说说你的故事吧");

}

function getFocus() {

    $(".input_detail").focus(function () {
       
        $(".btn_30px").css("visibility", "visible");
        $(".send_btn").addClass("changefabu");
        $(".input_detail").val("#相见不如怀念#");
        $(".input").addClass("changecolor");
        $(".arrow").addClass("changeposition");
    });
    $(".input_detail").blur(function () {
        $(".input").removeClass("changecolor");
        $(".arrow").removeClass("changeposition");
        if ($(this).val() == "#相见不如怀念#") {
            loadthing();
           
        }

    });
}
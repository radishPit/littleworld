$(function () {

    var myID = $(".FindID").attr("id");

    loadthing();
    getFocus();
    submitClick(myID);
    addImg();
    closeHover();


    chooseup_click();
    unitcolor_hover();
    weibo_hide();
    WB_feed_typeHover();
    Wbface_hover(myID);

    addInfo(myID);
    support(myID);
    transmit(myID);
    store(myID);
    pingbi(myID);
    AddMaster(myID);
    

});

function AddMaster(myID) {
    $(".gn_name").html(myID);
}

function pingbi(myID) {
    $(document).on("click", ".pb", function () {
        var novID = $(this).parents(".WB_feed_type").attr("id");
        
        $.ajax({
            url:"ws/userHome.asmx/PB",
            type:"POST",
            contentType: "application/json",
            data: "{ID:"+ myID +",novID:"+ novID+"}",
            dataType: "json",
            success: function (res) {
                alert(res.d);
            }
        });
    });
}
function store(myID) {
    var ID;
    var novID;
    var title;
    $(document).on("click", ".store", function () {
        var store = $(this);
        novID = $(this).parents(".WB_feed_type").attr("id");
        ID = myID;
        title = $(this).parents(".WB_feed_type").attr("id");
        $.ajax({
            url: "ws/userHome.asmx/AddStore",
            type: "POST",
            contentType: "application/json",
            data: "{novID:" + novID + ",myID:" + ID + "}",
            dataType: "json",
            success: function (res) {
                if (res.d=="yes") {
                    store.html("取消收藏");
                }
                else {
                    store.html("收藏");
                }
                
            }
        });
    });
}

//待完成
function transmit(myID) {
    var userName = "";
    var comments = "";
    var time = "";
    var supportnum = "";
    var transmitnum = "";
    var commentnum = "";
    var precontents;
    var preuserName;
    var presupnum;
    var pretrnum;

    var thisurl;
    var novID;
    var recept;
    $(document).on("click", ".transmit", function () {
        var id = $(this).parents(".WB_feed_type").attr("id");
        var th = $(this);
        precontents = $(this).parents(".WB_feed_type").find(".WB_text").html();
        preuserName = $(this).parents(".WB_feed_type").find(".WB_name").html();
       
        $.ajax({
            url: "ws/userHome.asmx/Addsupport",
            type: "POST",
            contentType: "application/json",
            data: "{novityID:" + id + ",type:11,ID:" + myID + "}",
            dataType: "json",

            success: function (res) {
                //alert(res.d);
                var all = res.d;
                var num = all.split("@=@")[0];
                recept = all.split("@=@")[1];
                th.html("转发(" + num + ") ");


                userName = recept.split(";")[0];
                comments = recept.split(";")[1];
                time = recept.split(";")[2];
                supportnum = recept.split(";")[3];
                transmitnum = recept.split(";")[4];
                commentnum = recept.split(";")[5];
                thisurl = recept.split(";")[6];
                novID = recept.split(";")[7];

                $("#news_container").prepend("<div class='WB_feed_type'id=" + novID + "><div class='WB_global_personcard'><div class=''></div></div><div class='WB_screen'><a href='javascript:void(0)' class='icon_chooseup' id='xiaojiantou'></a><div class='menu_small'><ul><li><a href='javascript:void(0)' class='hide'>隐藏这条微博</a> </li><li><a href='javascript:void(0)' class='pb'>屏蔽##的微博</a> </li></ul></div></div><div class='WB_feed_datail'><div class='WB_face'><a href='#' class='W_face_radius'><img width='50'height='50' src=" + thisurl + "/></a></div><div class='WB_detail'><div class='WB_info'> <a href='#' class='WB_name'>" + userName + " </a></div><div class='WB_text'>" + comments + "</div><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan support'><em class='icon_praised_b'></em>(" + supportnum + ")</a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan transmit'>转发(" + transmitnum + ") </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan store'>收藏 </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan comment'>评论(" + commentnum + ") </a><i class='sfgt ch'>|</i><a href='userReport.aspx?novID="+novID+"' class='zan jubao'>举报</a></div><div class='WB_from'><a href='' class='WB_time'>" + time + "</a></div></div>");


            }
        });

    });
}
function support(myID) {

    $(document).on("click", ".support", function () {
        var id = $(this).parents(".WB_feed_type").attr("id");
        var th = $(this);
        $.ajax({
            url: "ws/userHome.asmx/Addsupport",
            type: "POST",
            contentType: "application/json",
            data: "{novityID:" + id + ",type:1,ID:"+myID+"}",
            dataType: "json",

            success: function (res) {
                var ty = res.d.split("@=@")[0];
                var num = res.d.split("@=@")[1];
                if (ty=="1") {
                    th.html("<em class='icon_praised_b'></em>(" + num + ")");
                }
                else {
                    th.html("<em class='icon_praised_b'></em>(" + num + ")");
                    th.find(".icon_praised_b").toggleClass("supporttoggle");
                }
               
                //
               
            }
        });
       

    });
   
}

function addInfo(myID) {
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
    var ss;
    $.ajax({
        url: "ws/userHome.asmx/Addinfo",
        type: "POST",
        contentType: "application/json",
        data: "{sendID:" + myID + "}",
        dataType: "json",
        success: function (res) {
            $(res.d).each(function () {
                userName = this["UserName"];
                comments= this["Contents"];
                time = this["Time"];
                supportnum = this["Supportnum"];
                transmitnum = this["Transmitnum"];
                commentnum = this["Commentnum"];
                thisurl = this["Headurl"];
                novID = this["NovID"];
//                var num = ss.length % 36;
//                for (var i = 1; i < num+1; i++) {
//                    comments += ss.substring(0, 36)+"<br>";
//                    ss = ss.substring(36 * i);

//                }



                $("#news_container").append("<div class='WB_feed_type'id=" + novID + "><div class='WB_global_personcard'><div class=''></div></div><div class='WB_screen'><a href='javascript:void(0)' class='icon_chooseup' id='xiaojiantou'></a><div class='menu_small'><ul><li><a href='javascript:void(0)' class='hide'>隐藏这条微博</a> </li><li><a href='javascript:void(0)' class='pb'>屏蔽##的微博</a> </li></ul></div></div><div class='WB_feed_datail'><div class='WB_face'><a href='#' class='W_face_radius'><img width='50'height='50' src=" + thisurl + "/></a></div><div class='WB_detail'><div class='WB_info'> <a href='#' class='WB_name'>" + userName + " </a></div><div class='WB_text'>" + comments + "</div><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan support'><em class='icon_praised_b'></em>(" + supportnum + ")</a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan transmit'>转发(" + transmitnum + ") </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan store'>收藏 </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan comment'>评论(" + commentnum + ") </a><i class='sfgt ch'>|</i><a href='userReport.aspx?novID=" + novID + "' class='zan jubao'>举报</a></div><div class='WB_from'><a href='' class='WB_time'>" + time + "</a></div></div></div></div></div>");

            });


        }


    });

    
}




function Wbface_hover(myID) {
    var index = 0;
    $(document).on("hover", ".WB_global_personcard", function () {
        index = 1;

    }, function () {

        index = 0;
    });
    $(document).on("mouseover", ".WB_face", function () {
        $(this).parent().parent().find(".WB_global_personcard").css({ visibility: "visible" });
        var thisobj = $(this);
        var thisID = $(this).parents(".WB_feed_type").attr("id");
        var username;
        var nickname;
        var address;
        var school;
        var guanzhu;
        var fans;
        var novelty;
        var headImg
        $.ajax({
            url: "ws/userHome.asmx/FaceHover",
            type: "POST",
            contentType: "application/json",
            data: "{ID:" + thisID + ",me:"+myID+"}",
            dataType: "json",
            success: function (res) {
                var arr = res.d;
                for (var i = 0; i < arr.length; i++) {
                    username = arr[0];
                    nickname = arr[1];
                    address = arr[2];
                    school = arr[3];
                    guanzhu = arr[4];
                    fans = arr[5];
                    novelty = arr[6];
                    headImg = arr[7];
                }
                //alert(res.d);

                thisobj.parents(".WB_feed_type").find(".WB_global_personcard").html("<div class='top_div'><img src='images/userHomeImg/002_m.jpg' width='368' height='105'></div><div class='mid_div'><div class='mid_con'><div class='mid_con_bar'><div class='inner'><a href='#' class='innera'>" + username + "</a>(<a href='#' class='innera'>" + nickname + "</a>)</div><div class='inner'><a href='#' class='innera'>关注<span>" + guanzhu + "</span></a><span class='sfgt'>|</span><a href='#' class='innera'>粉丝<span>" + fans + "</span></a><span class='sfgt'>|</span><a href='#' class='innera'>微博<span>" + novelty + "</span></a></div></div><div class='mid_sec'><div class='mid_sec_con'><a href='#' class='innera'>" + address + "</a><span class='sfgt '>|</span><span class='innera black'>毕业学校：</span><a href='#' class='innera'>" + school + "</a></div></div></div></div><div class='bottom_div'><div class='bot_inner'><a href='javascript:void(0)' class='innera'>个人主页</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>微博</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>个人资料</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>相册</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>赞</a><span class='sfgt'>|</span><a href='javascript:void(0)' class='innera'>…</a></div></div><div class='headImag'><img src='" + headImg + "' width='86' height='86'></div>");
            }
        });

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
    var noID;

    $(document).on("click", ".hide", function () {
        
        var thisLine = $(this);
        noID = $(this).parents(".WB_feed_type").attr("id");

        $.ajax({
            url: "ws/userHome.asmx/HideNov",
            type: "POST",
            contentType: "application/json",
            data: "{noveltyID:" + noID + "}",
            dataType: "json",
            success: function (res) {
                thisLine.parents(".WB_feed_type").hide();
            }
        });
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
            var name=$(this).parents(".WB_feed_type").find(".WB_name").html();
            $(this).parents(".WB_feed_type").find(".pb").html("屏蔽"+name.trim()+"的微博");
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
   return index;
}

function submitClick(myID) {
    $(document).on("click", ".send_btn", function () {
        var pathstrs = countImgs();
        var txt = $(".input_detail").val();

        if (txt.length > 500) {
            alert("字符超出500");
            return;
        }
        else {
            var userName = "";
            var comments = "";
            var time = "";
            var supportnum = "";
            var transmitnum = "";
            var commentnum = "";
            var thisurl;
            var novID;
            var recept;
            $.ajax({
                url: "ws/userHome.asmx/AddNews",
                type: "POST",
                contentType: "application/json",
                data: "{sendID:" + myID + ",state:'1',txtcomment:'" + txt + "',paths:'" + pathstrs + "'}",
                dataType: "json",
                success: function (res) {
                    recept = res.d;
                    userName = recept.split(";")[0];
                    comments = recept.split(";")[1];
                    time = recept.split(";")[2];
                    supportnum = recept.split(";")[3];
                    transmitnum = recept.split(";")[4];
                    commentnum = recept.split(";")[5];
                    thisurl = recept.split(";")[6];
                    novID = recept.split(";")[7];

                    $("#news_container").prepend("<div class='WB_feed_type'id=" + novID + "><div class='WB_global_personcard'><div class=''></div></div><div class='WB_screen'><a href='javascript:void(0)' class='icon_chooseup' id='xiaojiantou'></a><div class='menu_small'><ul><li><a href='javascript:void(0)' class='hide'>隐藏这条微博</a> </li><li><a href='javascript:void(0)' class='pb'>屏蔽##的微博</a> </li></ul></div></div><div class='WB_feed_datail'><div class='WB_face'><a href='#' class='W_face_radius'><img width='50'height='50' src=" + thisurl + "/></a></div><div class='WB_detail'><div class='WB_info'> <a href='#' class='WB_name'>" + userName + " </a></div><div class='WB_text'><p class='sp'>" + comments + "</p></div><div class='WB_func'><div class='WB_handle'><a href='javascript:void(0)' class='zan support'><em class='icon_praised_b'></em>(" + supportnum + ")</a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan transmit'>转发(" + transmitnum + ") </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan store'>收藏 </a><i class='sfgt'>|</i> <a href='javascript:void(0)' class='zan comment'>评论(" + commentnum + ") </a><i class='sfgt ch'>|</i><a href='javascript:void(0)' class='zan jubao'>举报</a></div></div><div class='WB_from'><a href='' class='WB_time'>" + time + "</a></div></div></div></div></div>");
                    var newAdd = "#" + novID.toString();
                    $(document).on("", "newAdd", function () { 
                    
                    })
                    $(newAdd).fadeIn("slow");
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
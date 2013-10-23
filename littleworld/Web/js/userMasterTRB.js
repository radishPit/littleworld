$(function () {
    inputFocus();
    Chposition();
    Ahover();
    Aclick();
    SmallIconhover();
    ListShow();
    Slide();

});


function Slide() {
    $("#Msg").click(function () {
        $(".lev3").show();
    });

    $(".levo").not("#Msg").click(function () {
        $(".lev3").hide();
    });
}



function ListShow() {
    $("#message").click(function () {

        $(".gn_topmenulist").toggle();
    });
}

function allreset() {
    $(".S_txt3").each(
		function () {
		    var Y = $(this).children("span").css("background-position").split(" ")[1];
		    var d = 0 + "px" + " " + Y;
		    $(this).children("span").css("background-position", d);
		}
	);
}

function Aclick() {
    $(".S_txt1,.S_txt").click(function () {
        $(".S_txt1,.S_txt").removeClass("clickA");
        $(this).addClass("clickA");
    });

    $(".S_txt3").click(function () {
        allreset();
        var Y = $(this).children("span").css("background-position").split(" ")[1];
        var X = -25;
        var s = X + "px" + " " + Y;
        $(this).children("span").css("background-position", s);
    })
}


function inputFocus() {
    $(".gn_input").focus(function () {
        $(this).val("");
        $(".gn_search").addClass("getFocus");
        $(".gn_btn").addClass("getCh");
    })
    $(".gn_input").blur(function () {
        $(this).val("搜索");
        $(".gn_search").removeClass("getFocus");
        $(".gn_btn").removeClass("getCh");
    });

    $(".gn_btn").hover(function () {
        $(".gn_btn").addClass("Chcolor");
    }, function () {
        $(".gn_btn").removeClass("Chcolor");
    });


}

function Chposition() {
    $(".gn_tab").click(function () {

        $(".gn_tab").removeClass("AddImage");
        $(this).toggleClass("AddImage");

    });

}

function Ahover() {
    $(".S_txt1,.S_txt,.S_txt3").hover(function () {
        $(this).addClass("hoverA");
    }, function () {
        $(this).removeClass("hoverA");
    });


    $(".S_func1").hover(function () {
        $(this).addClass("hoverfoot");
    }, function () {
        $(this).removeClass("hoverfoot");
    });


}


function SmallIconhover() {
    $(".S_txt1").hover(function () {
        var Y = $(this).children(".W_ico20").css("background-position").split(" ")[1];
        var X = -25;
        var s = X + "px" + " " + Y;

        $(this).children(".W_ico20").stop().animate({ backgroundPosition: "(" + s + ")", opacity: '0.6' }, { duration: 200 });
    }, function () {
        var Y = $(this).children(".W_ico20").css("background-position").split(" ")[1];
        var X = 0;
        var s = X + "px" + " " + Y;

        $(this).children(".W_ico20").stop().animate({ backgroundPosition: "(" + s + ")", opacity: '0.6' }, { duration: 200 });
    });

}



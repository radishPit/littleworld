$(function () {
    inte();
});
function inte() {
//上传图片


    $('#uploadify').uploadifySettings('folder', 'JS');
    $("#addablumdes").hide();
    $("#createAlum").click(function () {
        $("#addablumdes").show();

    });
    $("#fr").click(function () {
        $("#addablumdes").hide();

    });
    $(".iname").keyup(function () {
        var s = $(this).val().length;
       
        if (s > 15) {
            $("#stringcount").html(s + "/15");
            $("#errormes").html("您最多可输入15个字！");
        }
        else {
            $("#stringcount").html(s + "/15");
            $("#errormes").html("");
        }


    });

}



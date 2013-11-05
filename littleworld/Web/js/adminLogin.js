$(function () {
    initEvents();
});
function initEvents() {
    $(".value1").focus(function () {
        var val = $(this).val();
        var name1 = $(this).attr("name1");
        if (val == name1) {
            $(this).val("");
        }
    });
    $(".value1").blur(function () {
        var val = $(this).val();
        var name1 = $(this).attr("name1");
        if (val == "") {
            $(this).val(name1);
        }
    });
//    $(".value1").keyup(function () {
//        var val = $(this).val();
//        var name = $(this).attr("name1");
//        if (val == "") {
//            $(this).val(name);
//        }
//    });


}
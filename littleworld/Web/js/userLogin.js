$(function () {
    initEvents();
});
function initEvents() {
    $("input:text").focus(function () {
        var val = $(this).val();
        var name = $(this).attr("name");
        if (val == name) {
            $(this).val("");
        }
    });
    $("input:text").blur(function () {
        var val = $(this).val();
        var name = $(this).attr("name");
        if (val == "") {
            $(this).val(name);
        }
    });
    $("input:text").keyup(function () {
        var val = $(this).val();
        var name = $(this).attr("name");
        if (val == "") {
            $(this).val(name);
        }
    });


}
$(function () {
    initEvents();
});


function initEvents() {
/*   $("#curpswCtext").focus(function () {
     $("#curpswCR").show();
      var va = $(this).val();
        if (va == "")
           
        else
            $("#curpswCR").hide(); 
 });
 $("#curpswCtext").blur(function () {
     $("#curpswCR").hide();
 });



 $("#newpswCtext").focus(function () {
     $("#newpswCR").show();
 });

 $("#newpswCtext").blur(function () {
     $("#newpswCR").hide();
 });

 $("#surepswCtext").focus(function () {
     $("#surepswCR").show();
 });

 $("surepswCtext").blur(function () {
     $("surepswCR").hide();
 }); 
 
         $(".txtpswstyle").next("div").find(".pswCR2style").hide();

             $("#submit_passworda").click(function () {
        $(".txtpswstyle").next("div").find(".pswCR1style").hide();
        var val1 = $("#newpswCtext").val();
        var val2 = $("#surepswCtext").val();
        if (val1 == val2 && val1 == "") {
            $("#newpswCR2").show();
        }
        if (val1 != val2) {
            $("#surepswCR2").show();
        }
    });
  */

    $(".txtpswstyle").focus(function () {
        $(".txtpswstyle").next("div").find(".pswCR1style").hide();
        $(".txtpswstyle").next("div").find(".pswCR2style").hide();

        $(this).next("div").find(".pswCR1style").show();
    });


}

$("img").hover(function() {
    $("#zoomedImage").html('<img src="' + $(this).attr("src") + '" alt="' + $(this).attr("alt") + '">');
});

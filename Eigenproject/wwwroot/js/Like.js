$(".btn-Like").click(function() {
    console.log("test");
    var data = this.value;
    console.log(data);
    console.log(this);
    var likes = $(this).parent().find(".Aantal-Likes").first();
    console.log(likes);
    $.ajax({
        type: "post",
        url: "/Post/AddLike",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(this.value.toString()),
        success: function (result) {
            console.log(result);
            console.log(likes);
            likes.html(result);
        },
        //error: function (err, scnd) {
        //    alert(err.statusText);
        //}
    });
})

$(".btn-DisLike").click(function () {
    var data = this.value;
    var likes = $(this).parent().find(".Aantal-Likes").first();
    console.log(likes);
    $.ajax({
        type: "post",
        url: "/Post/RemoveLike",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(this.value.toString()),
        success: function (result) {
            likes.html(result);
        },
        //error: function (err, scnd) {
        //    alert(err.statusText);
        //}
    });
})

console.log("test");
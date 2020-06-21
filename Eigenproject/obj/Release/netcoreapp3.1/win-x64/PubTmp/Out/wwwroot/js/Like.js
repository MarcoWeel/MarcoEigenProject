$(".btn-Like").click(function() {
    console.log("test");
    var data = this.value;
    console.log(data);
    console.log(this);
    var likes = $(this).parent().find(".Aantal-Likes").first();
    var likeButton = $(this).parent().find(".btn-Like").first();
    var returnLikeButton = $(this).parent().find("#LikeReturn");
    var dislikeButton = $(this).parent().find(".btn-DisLike").first();
    var returnDislikeButton = $(this).parent().find("#DislikeReturn");


    $(dislikeButton).css("display", "none");
    $(likeButton).css("display", "none");
    $(returnDislikeButton).css("display", "none");
    $(returnLikeButton).css("display", "inline-block");

    console.log(likes);
    $.ajax({
        type: "post",
        url: "/Post/AddLike",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(data.toString()),
        success: function(result) {
            console.log(result);
            console.log(likes);
            likes.html(result);
        }
    });
});

$(".btn-DisLike").click(function() {
    var data = this.value;
    var likes = $(this).parent().find(".Aantal-Likes").first();
    var likeButton = $(this).parent().find(".btn-Like").first();
    var returnLikeButton = $(this).parent().find("#LikeReturn");
    var dislikeButton = $(this).parent().find(".btn-DisLike").first();
    var returnDislikeButton = $(this).parent().find("#DislikeReturn");


    $(dislikeButton).css("display", "none");
    $(likeButton).css("display", "none");
    $(returnDislikeButton).css("display", "inline-block");
    $(returnLikeButton).css("display", "none");


    $.ajax({
        type: "post",
        url: "/Post/AddDislike",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(this.value.toString()),
        success: function(result) {
            likes.html(result);
        }
    });
});

$(".btn-ReturnLike").click(function() {
    var data = this.value;
    var likes = $(this).parent().find(".Aantal-Likes").first();
    var likeButton = $(this).parent().find(".btn-Like").first();
    var returnLikeButton = $(this).parent().find("#LikeReturn");
    var dislikeButton = $(this).parent().find(".btn-DisLike").first();
    var returnDislikeButton = $(this).parent().find("#DislikeReturn");


    $(dislikeButton).css("display", "inline-block");
    $(likeButton).css("display", "inline-block");
    $(returnDislikeButton).css("display", "none");
    $(returnLikeButton).css("display", "none");


    console.log(likes);
    $.ajax({
        type: "post",
        url: "/Post/RemoveLikeOrDislike",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(this.value.toString()),
        success: function(result) {
            likes.html(result);
        }
    });
});

console.log("test");
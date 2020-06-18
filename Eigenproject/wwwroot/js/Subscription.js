//follows genre on main page
$(".btn-Follow").click(function () {
    console.log("test");
    var followButton = $(this).parent().find(".btn-Follow").first();
    var returnFollowButton = $(this).parent().find("#Unfollow");

    var subscriptionName = $(this).parent().parent().find("#GenreInput").first();
    var subscriptionType = $(this).parent().parent().find(".TypeInput").first();

    $(followButton).css("display", "none");
    $(returnFollowButton).css("display", "inline-block");

    $.ajax({
        type: "POST",
        url: "/Subscription/AddGenreSubscription",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        data: JSON.stringify(subscriptionName.val().toString()),
        success: function () { }
    });
});

//follows user on other user details page
$(".btn-FollowUser").click(function () {
    console.log("test");
    var followButton = $(this).parent().find(".btn-Follow").first();
    var returnFollowButton = $(this).parent().find("#Unfollow");

    var subscriptionName = $(this).parent().parent().find("#GenreInput").first();
    var subscriptionType = $(this).parent().parent().find(".TypeInput").first();

    $(followButton).css("display", "none");
    $(returnFollowButton).css("display", "inline-block");

    $.ajax({
        type: "POST",
        url: "/Subscription/AddUserSubscription",
        contentType: 'application/json; charset=utf-8',
        dataType: "json",
        data: JSON.stringify(subscriptionName.val().toString()),
        success: function () { }
    });
});

//unfollows on main page
$(".btn-Unfollow").click(function () {
    console.log("test");
    var followButton = $(this).parent().find("#Follow").first();
    var returnFollowButton = $(this).parent().find("#Unfollow").first();
    var subscriptionName = $(this).parent().parent().find("#GenreInput").first();


    $(followButton).css("display", "inline-block");
    $(returnFollowButton).css("display", "none");

    $.ajax({
        type: "post",
        url: "/Subscription/RemoveSubscription",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(subscriptionName.val().toString()),
        success: function () { }
    });
});

//unfollows on subscriptions page
$(".btn-UnfollowSub").click(function () {
    console.log("test");
    var returnFollowButton = $(this).parent().find("#Unfollow").first();
    var subscriptionName = $(this).parent().find("#GenreInput").first();


    $(returnFollowButton).css("display", "none");
    $(this).parent().find("#Name").css("display", "none");

    $.ajax({
        type: "post",
        url: "../Subscription/RemoveSubscription",
        contentType: 'application/json',
        dataType: 'json',
        data: JSON.stringify(subscriptionName.val().toString()),
        success: function () { }
    });
});
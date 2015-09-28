var myCookieController = (function() {

    function get(context) {
        var cookies = [];
        data.cookies.getMyCookie()
            .then(function(resCookie) {
                cookies.push(resCookie);

                if (data.users.hasUser()) {
                    cookies = _.map(cookies, controllerHelpers.fixUser);
                }

                cookies = _.chain(cookies)
                    .map(controllerHelpers.fixDate).value();

                return templates.get('my-cookie');
            })
            .then(function(template) {
                context.$element().html(template(cookies));
                $('.btn.btn-success').on('click', function() {
                    var $this = $(this),
                        cookieId = $this.parents('.cookie-box').attr('data-id');
                    data.cookies.like(cookieId)
                        .then(function(cookie) {
                            $this.parents('.cookie-box').find('.likes').html(cookie.likes);
                            toastr.clear();
                            toastr.success('Cookie liked!');
                        });
                });
                $('.btn.btn-danger').on('click', function() {
                    var $this = $(this),
                        cookieId = $this.parents('.cookie-box').attr('data-id');
                    data.cookies.dislike(cookieId)
                        .then(function(cookie) {
                            toastr.clear();
                            toastr.error('Cookie disliked!');
                            $this.parents('.cookie-box').find('.dislikes').html(cookie.dislikes);
                        });
                });
            })
            .catch(function(err) {
                toastr.error(err);
            });
    }

    return {
        get: get
    };
})();

var cookiesController = (function() {

    function all(context) {
        var cookies;
        var category = context.params.category || null;
        var sortBy = context.params.sortBy || 'date';
        data.cookies.get()
            .then(function(resCookies) {
                cookies = resCookies;

                cookies.sort(function(c1, c2) {
                    if (sortBy === 'date') {
                        return (new Date(c2.shareDate)) - (new Date(c1.shareDate));
                    }
                    return c2.likes - c1.likes;
                });

                if (category) {
                    cookies = cookies.filter(function(cookie) {
                        return cookie.category.toLowerCase() === category.toLowerCase();
                    });
                }


                if (data.users.hasUser()) {
                    cookies = _.map(cookies, controllerHelpers.fixUser);
                }

                cookies = _.chain(cookies)
                    .map(controllerHelpers.fixDate).value();

                return templates.get('cookies');
            })
            .then(function(template) {
                context.$element().html(template(cookies));
                return data.categories.get();
            })
            .then(function(categories) {
                categories.forEach(function(value) {
                    var $item = $('<li>');
                    var $link = $('<a>').text(value).attr('href', '#/cookies?category=' + value).appendTo($item);
                    $('#categories-sort-dropdown').append($item);
                });

                $('#sort-by-likes').on('click', function() {
                    context.redirect('./#/cookies?sortBy=likes');
                });

                $('#sort-by-date').on('click', function() {
                    context.redirect('./#/cookies?sortBy=date');
                });

                $('.reshare-cookie-btn').on('click', function() {
                    var $this = $(this);

                    var cookie = {
                        text: $this.parents('.cookie-box').attr('data-text'),
                        category: $this.parents('.cookie-box').attr('data-category'),
                        img: $this.parents('.cookie-box').attr('data-img')
                    };

                    data.cookies.add(cookie)
                        .then(function(cookie) {
                            toastr.clear();
                            toastr.success('Cookie added!');
                            document.location = '#/';
                        });
                });

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

    function add(context) {
        templates.get('share-cookie')
            .then(function(template) {
                context.$element()
                    .html(template());
                return data.categories.get();
            })
            .then(function(categories) {
                $('#tb-cookie-category').autocomplete({
                    source: categories
                });
                $('#btn-cookie-add').on('click', function() {
                    var cookie = {
                        text: $('#tb-cookie-text').val(),
                        category: $('#tb-cookie-category').val(),
                        img: $('#tb-cookie-img').val()
                    };

                    data.cookies.add(cookie)
                        .then(function(cookie) {
                            toastr.success('Cookie added!');
                            context.redirect('#/cookies');
                        });
                });

                $('.reshare-cookie-btn').on('click', function() {
                    var cookie = {
                        text: $('#tb-cookie-text').val(),
                        category: $('#tb-cookie-category').val()
                    };
                });
            });
    }

    return {
        all: all,
        add: add
    };
}());

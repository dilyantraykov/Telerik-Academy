var data = (function() {
    const LOCAL_STORAGE_USERNAME_KEY = 'x-username',
        LOCAL_STORAGE_AUTHKEY_KEY = 'x-auth-key';

    const USERNAME_CHARS = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890_.",
        USERNAME_MIN_LENGTH = 6,
        USERNAME_MAX_LENGTH = 30;

    const COOKIE_TEXT_MIN_LENGTH = 6,
        COOKIE_TEXT_MAX_LENGTH = 30,
        COOKIE_CATEGORY_MIN_LENGTH = 6,
        COOKIE_CATEGORY_MAX_LENGTH = 30;

    /* Users */

    function register(user) {
        var error = validator.validateString(user.username, USERNAME_MIN_LENGTH, USERNAME_MAX_LENGTH, "name", USERNAME_CHARS);

        if (error) {
            toastr.error(error.message);
            return Promise.reject(error.message);
        }

        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        return jsonRequester.post('api/users', {
                data: reqUser
            })
            .then(function(resp) {
                return {
                    username: resp.result.username
                };
            });
    }


    function signIn(user) {
        var error = validator.validateString(user.username, USERNAME_MIN_LENGTH, USERNAME_MAX_LENGTH, "name", USERNAME_CHARS);

        if (error) {
            toastr.error(error.message);
            return Promise.reject(error.message);
        }

        var reqUser = {
            username: user.username,
            passHash: CryptoJS.SHA1(user.username + user.password).toString()
        };

        var options = {
            data: reqUser
        };

        return jsonRequester.put('api/auth', options)
            .then(function(resp) {
                var user = resp.result;
                localStorage.setItem(LOCAL_STORAGE_USERNAME_KEY, user.username);
                localStorage.setItem(LOCAL_STORAGE_AUTHKEY_KEY, user.authKey);
                return user;
            });
    }

    function signOut() {
        var promise = new Promise(function(resolve, reject) {
            localStorage.removeItem(LOCAL_STORAGE_USERNAME_KEY);
            localStorage.removeItem(LOCAL_STORAGE_AUTHKEY_KEY);
            resolve();
        });
        return promise;
    }

    function hasUser() {
        return !!localStorage.getItem(LOCAL_STORAGE_USERNAME_KEY) &&
            !!localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY);
    }

    function usersGet() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };

        return jsonRequester.get('api/users', options)
            .then(function(res) {
                return res.result;
            });
    }

    function getUserById(id) {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };

        var user;

        return jsonRequester.get('api/users', options)
            .then(function(res) {
                return res.result;
            })
            .then(function(res) {
                $(res).each(function(index, value) {
                    if (value.id === id) {
                        user = value.username;
                    }
                });
            })
            .then(function() {
                return user;
            });

    }

    function cookiesGet() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };
        return jsonRequester.get('api/cookies', options)
            .then(function(res) {
                return res.result;
            });
    }

    function getMyCookie() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };
        return jsonRequester.get('api/my-cookie', options)
            .then(function(res) {
                return res.result;
            });
    }

    function cookiesAdd(cookie) {

        var error = validator.validateString(cookie.text, COOKIE_TEXT_MIN_LENGTH, COOKIE_TEXT_MAX_LENGTH, "cookie text");
        if (error) {
            toastr.error(error.message);
            return Promise.reject('Text ' + error.message);
        }

        error = validator.validateString(cookie.category, COOKIE_CATEGORY_MIN_LENGTH, COOKIE_CATEGORY_MAX_LENGTH, "category");
        if (error) {
            toastr.error(error.message);
            return Promise.reject('Category ' + error.message);
        }

        error = validator.validateUrl(cookie.img);
        if (error) {
            toastr.error(error.message);
            return Promise.reject(error.message);
        }

        var options = {
            data: cookie,
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };

        return jsonRequester.post('api/cookies', options)
            .then(function(resp) {
                return resp.result;
            });
    }

    function cookiesLike(id) {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            },
            data: {
                type: 'like'
            }
        };

        return jsonRequester.put('api/cookies/' + id, options)
            .then(function(res) {
                return res.result;
            });
    }

    function cookiesDislike(id) {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            },
            data: {
                type: 'dislike'
            }
        };

        return jsonRequester.put('api/cookies/' + id, options)
            .then(function(res) {
                return res.result;
            });
    }

    /* Categories */
    function categoriesGet() {
        var options = {
            headers: {
                'x-auth-key': localStorage.getItem(LOCAL_STORAGE_AUTHKEY_KEY)
            }
        };

        return jsonRequester.get('api/categories', options)
            .then(function(res) {
                return res.result;
            });
    }

    return {
        users: {
            signIn: signIn,
            signOut: signOut,
            register: register,
            hasUser: hasUser,
            get: usersGet,
            getUserById: getUserById
        },
        cookies: {
            get: cookiesGet,
            getMyCookie: getMyCookie,
            add: cookiesAdd,
            like: cookiesLike,
            dislike: cookiesDislike
        },
        categories: {
            get: categoriesGet
        },
    };
}());

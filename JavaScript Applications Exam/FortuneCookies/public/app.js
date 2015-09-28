(function() {

  var sammyApp = Sammy('#content', function() {

    this.get('#/', function() {
      this.redirect('#/home');
    });
    this.get('#/home', cookiesController.all);

    this.get('#/users/register', usersController.register);

    this.get('#/cookies', cookiesController.all);
    this.get('#/cookies/share', cookiesController.add);

    this.get('#/my-cookie', myCookieController.get);

  });

  $(function() {
    sammyApp.run('#/user');

    var $mainNav = $('#main-nav');

    if (data.users.hasUser()) {

      var $shareCookieItem = $('<li>').attr('id', 'share-cookie-item');
      var $shareCookieLink = $('<a>').attr('href', './#/cookies/share').text('Share Cookie');
      $shareCookieItem.append($shareCookieLink);

      var $myCookieItem = $('<li>').attr('id', 'my-cookie-item');
      var $myCookieLink = $('<a>').attr('href', './#/my-cookie').text('My Cookie');
      $myCookieItem.append($myCookieLink);

      $mainNav.append($shareCookieItem);
      $mainNav.append($myCookieItem);

      $('#container-sign-in').addClass('hidden');
      $('#btn-sign-out').on('click', function(e) {
        e.preventDefault();
        data.users.signOut()
          .then(function() {
            document.location = '#/';
            document.location.reload(true);
          });
      });
    } else {
      var $registerItem = $('<li>').attr('id', 'register-item');
      var $registerLink = $('<a>').attr('href', '#/users/register').text('Register');
      $registerItem.append($registerLink);

      $mainNav.append($registerItem);
      $('#container-sign-out').addClass('hidden');
      $('#btn-sign-in').on('click', function(e) {
      	e.preventDefault();
        var user = {
          username: $('#tb-username').val(),
          password: $('#tb-password').val()
        };
        data.users.signIn(user)
          .then(function(user) {
            document.location = '#/';
            document.location.reload(true);
          }, function(err) {
            $('#container-sign-in').trigger("reset");
            toastr.error('Invalid username and/or password!');
          });
      });
    }
  });
}());
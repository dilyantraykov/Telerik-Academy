var usersController = function() {
  function register(context) {
    templates.get('register')
      .then(function(template) {
        context.$element().html(template());

        $('#btn-register').on('click', function() {
          var user = {
            username: $('#tb-reg-username').val(),
            password: $('#tb-reg-pass').val()
          };

          data.users.register(user)
            .then(function() {
              toastr.success('User ' + user.username + ' registered! You can now login!');
              context.redirect('#/');
            });
        });
      });
  }

  return {
    register: register
  };
}();
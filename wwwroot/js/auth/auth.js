$(document).ready(function () {
  // toggle password
  $(".container .password-container i").click(function (e) {
    e.preventDefault();
    $(this).toggleClass("fa-eye");
    $(this).toggleClass("fa-eye-slash");
    if ($(this).hasClass("fa-eye")) {
      $(this).parent().find("input").attr("type", "password");
    } else {
      $(this).parent().find("input").attr("type", "text");
    }
  });
});

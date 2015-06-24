function checkUserBrowser(event, parameters) {
    var userWindow = window,
        browser = userWindow.navigator.appCodeName,
        isMozilla = (browser == "Mozilla");

    if (isMozilla) {
        alert("You are using Mozilla Firefox.");
    } else {
        alert("You are not using Mozilla Firefox.");
    }
}

setTimeout(function () {
    window.addEventListener("load", function () {
        const loader = document.querySelector(".loader");
        loader.className += " hidden"; // class "loader hidden"
    });
}, 2500);

randQuote = function () {
    var q = new Array();
    q[0] = "q0";
    q[1] = "q1";
    q[2] = "q2";
    var rand = Math.floor(Math.random() * q.length);
    document.write(q[rand]);
}
randQuote();
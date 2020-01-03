function scrollToAnchor(anchor) {
    var selector = anchor || document.location.hash;
    if (selector && selector.length > 1) {
        var element = document.querySelector(selector);
        if (element) {
            var y = element.getBoundingClientRect().top + window.pageYOffset;
            // y -= document.querySelector(".main .top-row").offsetHeight;
            element.scrollIntoView({ behavior: 'smooth' }).window.scroll(0, y);
        }
    }
    else
        element.scrollIntoView({ behavior: 'smooth' }).window.scroll(0, 0);
}


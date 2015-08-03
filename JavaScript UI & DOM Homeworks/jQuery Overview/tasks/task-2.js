/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function(selector) {
        var $element;

        if (typeof(selector) === 'string') {
            $element = $(selector);
        } else {
            $element = selector;
        }

        if (!($element.length)) {
            throw new Error('The selector must be either a jQuery object or a string!');
        }

        var buttons = $('.button').html('hide');

        $element.on('click', '.button', toggleContent);

        function toggleContent(ev) {
            var $button = $(ev.target);
            var $nextSibling = $button.next();

            while ($nextSibling.length) {
                if ($nextSibling.hasClass('content')) {

                    if ($nextSibling.css('display') === 'none') {
                        $button.html('hide');
                        $nextSibling.css('display', '');
                    } else {
                        $button.html('show');
                        $nextSibling.css('display', 'none');
                    }

                    break;
                } else if ($nextSibling.hasClass('button')) {
                    break;
                } else {
                    $nextSibling = $nextSibling.next();
                }
            }
        }
    };
}

module.exports = solve;

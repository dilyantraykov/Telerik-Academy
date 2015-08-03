/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  *If an id is provided, select the element
  *Finds all elements with class button or content within the provided element
  	*Change the content of all .button elements with "hide"
  *When a .button is clicked:
	  *Find the topmost .content element, that is before another .button and:
	  	*If the .content is visible:
	  		*Hide the .content
	  		*Change the content of the .button to "show"
	  	*If the .content is hidden:
			*Show the .content
			*Change the content of the .button to "hide"
	  	*If there isn't a .content element after the clicked .button and before other .button, do nothing
  *Throws if:
	  *The provided DOM element is non-existant
	  *The id is either not a string or does not select any DOM element

*/

function solve() {

    return function(selector) {
        var element;

        if (typeof(selector) === 'string') {
            element = document.getElementById(selector);
        } else {
            element = selector;
        }

        if (typeof(element) === undefined) {
            throw new Error('No such element in the DOM!');
        }

        var buttons = element.getElementsByClassName('button');

        for (var i = 0, len = buttons.length; i < len; i += 1) {
            buttons[i].innerHTML = 'hide';
            buttons[i].addEventListener('click', toggleContent, false);
        }

        function toggleContent(ev) {
            var button = ev.target;
            var nextElement = button;
            var content;

            while (nextElement) {
                if (nextElement.className.indexOf('content') >= 0) {
                    content = nextElement;
                    break;
                }

                nextElement = nextElement.nextElementSibling;
            }

            if (typeof(content) !== undefined) {
                if (content.style.display === '') {
                    button.innerHTML = 'show';
                    content.style.display = 'none';
                } else {
                    button.innerHTML = 'hide';
                    content.style.display = '';
                }
            }
        }
    };
}

module.exports = solve;

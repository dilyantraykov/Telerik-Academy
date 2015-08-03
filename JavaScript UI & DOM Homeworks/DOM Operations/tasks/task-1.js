/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function() {

    return function(element, contents) {
        
        var el;
        
        if (typeof(element) === undefined) {
          throw new Error('No element provided!');
        }

        if (typeof(contents) === undefined) {
          throw new Error('No contents provided!');
        }

        if (typeof(element) === 'string') {
            el = document.getElementById(element);
        } else {
          el = element;
        }

        if (typeof(el) === null) {
          throw new Error('No such element in the DOM!');
        }

        var docFragment = document.createDocumentFragment();
        var div = document.createElement('div');

        for (var i = 0, len = contents.length; i < len; i += 1) {
          if (typeof(contents[i]) !== 'string' &&
              typeof(contents[i]) !== 'number') {
            throw new Error('Div content should be either a string or a number!');
          }

          var currentDiv = div.cloneNode(true);
          currentDiv.innerHTML = contents[i];
          docFragment.appendChild(currentDiv);
        }

        el.innerHTML = '';
        el.appendChild(docFragment);
    };
};

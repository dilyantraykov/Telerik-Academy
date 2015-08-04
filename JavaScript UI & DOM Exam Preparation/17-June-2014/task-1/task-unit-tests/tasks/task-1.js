/* globals module */
function solve() {

  function clear(node) {
    while (node.firstChild) {
      node.removeChild(node.firstChild);
    }
  }

  return function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector);
    var div = document.createElement('div');

    var aside = div.cloneNode(true);
    var main = div.cloneNode(true);

    main.className = 'image-preview';

    container.style.width = '60%';
    container.style.margin = '0 auto';
    aside.style.width = '25%';
    aside.style.float = 'right';
    aside.style.height = '650px';
    aside.style.overflowY = 'scroll'; 
    aside.style.overflowX = 'hidden'; 
    main.style.width = '70%';
    main.style.float = 'left';

    var input = document.createElement('input');
    input.style.width = '90%';

    aside.appendChild(input);

    for (var i = 0, len = items.length; i < len; i += 1) {
      var item = div.cloneNode(true);
      item.className = 'image-container';
      item.innerHTML = '<h3 style="text-align: center">' + items[i].title + '</h3>' +
              '<img style="width: 100%" src="' + items[i].url + '" />';

      aside.appendChild(item);
      if (i === 0) {
        var clonedItem = item.cloneNode(true);
        main.innerHTML = clonedItem.innerHTML;
      }
    }

    aside.addEventListener('click', function(ev) {
      var target = ev.target;
      if (target.parentNode.className.indexOf('image-container') >= 0) {
        var clonedContainer = target.parentNode.cloneNode(true);
        main.innerHTML = '';
        main.appendChild(clonedContainer);
      }
    }, false);

    input.addEventListener('keyup', function() {
      var images = document.querySelectorAll('.image-container');
      for (var i = 0, len = images.length; i < len; i += 1) {
        var text = images[i].innerText.toLowerCase();
        if (text.indexOf(input.value.toLowerCase()) < 0) {
          images[i].style.display = 'none';
        } else {
          images[i].style.display = '';
        }
      }
    }, false);

    container.appendChild(aside);
    container.appendChild(main);
    document.body.appendChild(container);
};

}

module.exports = solve;
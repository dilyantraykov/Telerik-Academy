function solve(){
  return function(selector){
    var $select = $('select').css('display', 'none');

    var $options = $('option');

    var $list = $('<div />').addClass('dropdown-list');

    var $container = $('<div />').css('display', 'none')
    							.addClass('options-container')
    							.on('click', '.dropdown-item', selectItem);
    							
    var $current = $('<div />').addClass('current')
    						.on('click', toggleDropdown);

    for (var i = 0; i < $options.length; i += 1) {
		var $option = $($options[i]);

		if (i === 0) {
    		$current.html($option.html());
    		$current.attr('data-value', $option.attr('data-value'));
    	}

    	var $div = $('<div />').addClass('dropdown-item').attr({
    		'data-value': $option.val(),
    		'data-index': i
    	}).html($option.html());

    	$div.appendTo($container);
    }

    $select.appendTo($list);
    $current.appendTo($list);
    $container.appendTo($list);
    $list.appendTo(document.body);

    function toggleDropdown() {
    	if ($container.css('display') === 'none') {
    		$current.html('Select a value');
    		$container.css('display', '');
    	} else {
    		$container.css('display', 'none');
    	}
    }

    function selectItem(ev) {
    	$item = $(ev.target);
    	$current.html($item.html());
    	$current.attr('data-value', $item.attr('data-value'));
    	$select.find('option[value="' + $item.attr('data-value') + '"]').attr('selected', 'selected');
    	toggleDropdown();
    }
  };
}

module.exports = solve;
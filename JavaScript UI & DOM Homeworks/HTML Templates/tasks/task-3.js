function solve() {
    return function() {
        $.fn.listview = function(data) {
            var $this = $(this),
	            scriptId = $this.attr('data-template'),
	            $script = $('#' + scriptId),
	            template = handlebars.compile($script.html());

	        // remove script tag
	        $this.html('');

            for (var i = 0, len = data.length; i < len; i+= 1) {
            	$this.append(template(data[i]));
            }
        };
    };
}

module.exports = solve;

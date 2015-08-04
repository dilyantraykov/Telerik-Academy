        /* globals $ */
        $.fn.gallery = function() {
            var $this = $(this);
            var columns = arguments[0] || 4;
            var $images = $('.image-container');
            var $selected = $('.selected').css('display', 'none');
            $list = $('.gallery-list');

            $gallery = $('<div />').addClass('gallery');

            for (var i = 0, len = $images.length; i < len; i += 1) {
                var $image = $($images[i]);
                if (i % columns === 0) {
                    $image.addClass('clearfix');
                }
                $gallery.append($image);
            }

            $this.html = ('');
            $this.append($gallery).on('click', '.image-container', clickedImage);
            $this.append($selected);

            function clickedImage(ev) {
                var $image = $(ev.target);
                $selected.css('display', '');

                $list.append($selected.html()).addClass('blurred').addClass('disabled-background');
            }
        };

/* globals $ */
$.fn.gallery = function(columnsPerRow) {
    var $currentImage, $nextImage, $previousImage;
    var columns = columnsPerRow || 4;
    var $gallery = $(this);
    var $selected = $gallery.children('.selected').hide();
    var $galleryList = $gallery.children('.gallery-list');
    var $images = $galleryList.children('.image-container');
    var $disabledBackground = $('<div />').addClass('disabled-background');

    $images.each(function(index, element) {
        $image = $(element);
        if (index % columns === 0) {
            $image.addClass('clearfix');
        }
        $galleryList.append($image);
    });

    $gallery.addClass('gallery');

    $selected.on('click', 'img', clickedNavigation);
    $gallery.on('click', '.image-container', clickedImage);

    function clickedImage(ev) {
        getNavigationImages(ev.target);

        $selected.show();
        $galleryList.addClass('blurred');
        $gallery.append($disabledBackground);

        $selected.find('.current-image')
            .html($currentImage
                .attr('id', 'current-image'));
        $selected.find('.previous-image')
            .html($previousImage
                .attr('id', 'previous-image'));
        $selected.find('.next-image')
            .html($nextImage
                .attr('id', 'next-image'));
    }

    function clickedNavigation(ev) {
        getNavigationImages(ev.target);

        if ($currentImage.attr('id') === 'current-image') {
            $selected.css('display', 'none');
            $galleryList.removeClass('blurred');
            $disabledBackground.remove();
        } else {
            $('#current-image').attr('src', $currentImage.attr('src'))
                .attr('data-info', $currentImage.attr('data-info'));
            $('#previous-image').attr('src', $previousImage.attr('src'))
                .attr('data-info', $previousImage.attr('data-info'));
            $('#next-image').attr('src', $nextImage.attr('src'))
                .attr('data-info', $nextImage.attr('data-info'));
        }
    }

    function getNavigationImages(target) {
        var id, nextId, previousId;
        $currentImage = $(target).clone();
        id = $currentImage.attr('data-info');

        if (id > 1) {
            previousId = id - 1;
        } else {
            previousId = $images.length;
        }

        if (id < $images.length) {
            nextId = (id | 0) + 1;
        } else {
            nextId = 1;
        }

        $previousImage = $images.find('[data-info="' + previousId + '"]').clone();
        $nextImage = $images.find('[data-info="' + nextId + '"]').clone();
    }
};

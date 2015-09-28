var controllerHelpers = function() {
    function groupByCategory(item) {
        return item.category;
    }

    function parseGroups(items, category) {
        return {
            category: category,
            items: items
        };
    }

    function filterByCategory(category) {
        return function(group) {
            return group.category.toLowerCase() === category.toLowerCase();
        };
    }

    function fixDate(item) {
        var newItem = Object.create(item);
        newItem.shareDate = moment(item.shareDate).format('MMMM Do YYYY [at] hh:mm');
        return newItem;
    }

    function fixUser(item) {
        var newItem = Object.create(item);
        data.users.getUserById(newItem.userId).then(function(res) {
            newItem.user = res;
        });
        return newItem;
    }

    return {
        groupByCategory, parseGroups, filterByCategory, fixDate, fixUser
    };
}();

/* Task Description */
/* 
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function() {
        var books = [];
        var categories = [];

        function listBooks(category) {
            if (typeof category != 'undefined') {
                var i,
                    len,
                    result = [];
                for (i = 0, len = books.length; i < len; i += 1) {
                    if (arguments[0].category === books[i].category) {
                        result.push(books[i]);
                    }
                }
                return result;
            }
            return books;
        }

        function addCategory(name) {
            categories[name] = {
                books: [],
                ID: categories.length + 1
            };
        }

        function addBook(book) {
            if (book.title.length < 2 || book.title.length > 100 ||
                book.category.length < 2 || book.category.length > 100) {
                throw new Error();
            }
            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error();
            }
            if (typeof book.author != 'string' || book.author.length <= 0) {
                throw new Error();
            }
            if (books.some(function hasSameTitle(item) {
                    return item.title === book.title;
                })) {
                throw new Error();
            }
            if (books.some(function hasSameTitle(item) {
                    return item.isbn === book.isbn;
                })) {
                throw new Error();
            }

            if (categories.indexOf(book.category) < 0) {
                addCategory(book.category);
            }

            categories[book.category].books.push(book);

            book.ID = books.length + 1;
            books.push(book);
            return book;
        }

        function listCategories() {
            var categoryList = [];
            categoryList.push.apply(categoryList, Object.keys(categories));

            return categoryList;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;

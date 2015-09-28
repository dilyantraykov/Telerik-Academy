/* 
Create a function that:
*   **Takes** a collection of books
    *   Each book has propeties `title` and `author`
        **  `author` is an object that has properties `firstName` and `lastName`
*   **finds** the most popular author (the author with biggest number of books)
*   **prints** the author to the console
	*	if there is more than one author print them all sorted in ascending order by fullname
		*   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

function solve() {
  return function (books) {

    function fullAuthorName(book) {
      return book.author.firstName + ' ' + book.author.lastName;
    }

    function toAuthorInfoObject(group) {
      return {
        name: fullAuthorName(group[0]),
        books: group.length
      };
    }

    function isTopPopular(author) {
      return author.books === mostBooks;
    }

    var authors = _.chain(books)
      .groupBy(fullAuthorName)
      .sortBy('length')
      .map(toAuthorInfoObject);

    var mostBooks = authors.last().value().books;

    authors.filter(isTopPopular)
      .sortBy('name')
      .pluck('name')
      .each(console.log);
  };
}

module.exports = solve;
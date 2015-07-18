// Problem 6. Extract text from HTML
// Write a function that extracts the content of a html page given as text.
// The function should return anything that is in a tag, without the tags.

function extractTextFromHtml(html) {
	var i, inTag = false, len = html.length,
		result = '';

	for (i = 0; i < len; i += 1) {
		if (html[i] === '<') {
			inTag = true;
		}

		if(!inTag) {
			result += html[i];
		}

		if (html[i] === '>') {
			inTag = false;
		}
	}

	return result;
}

var html = "<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>";

console.log(extractTextFromHtml(html));
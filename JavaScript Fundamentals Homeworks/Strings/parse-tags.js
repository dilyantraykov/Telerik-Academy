// Problem 4. Parse tags
// You are given a text. Write a function that changes the text in all regions:
// <upcase>text</upcase> to uppercase.
// <lowcase>text</lowcase> to lowercase
// <mixcase>text</mixcase> to mix casing(random)

function parseTags(text) {
    var i, j, k,
        startTagPosition = 0,
        endTagPosition = 0,
        position = 0,
        result = '',
        tags = ['mixcase', 'upcase', 'lowcase'],
        len = text.length;

    for (i = 0; i < len; i += 1) {
        if (text[i] === '<') {
        	position = i + 1;
        	
            for (j = 0; j < tags.length; j += 1) {
                if (text.indexOf(tags[j], position) === position) {
                    
                    startTagPosition = position + tags[j].length + 1;
                    endTagPosition = text.indexOf('</' + tags[j] + '>', position);
                    endTagPosition = (endTagPosition === -1) ? len - 1 : endTagPosition;
                    
                    for (k = startTagPosition; k < endTagPosition; k += 1) {
                        switch (tags[j]) {
                            case 'mixcase':
                                result += ((Math.random() + 0.5) | 0) ? text[k].toUpperCase() : text[k].toLowerCase();
                                break;
                            case 'upcase':
                                result += text[k].toUpperCase();
                                break;
                            case 'lowcase':
                                result += text[k].toLowerCase();
                                break;
                            default:
                                break;
                        }
                    }

                    i = endTagPosition + ('</' + tags[j] + '>').length - 1;
                }
            }
        } else {
            result += text[i];
        }
    }

    return result;
}

var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";

console.log(parseTags(text));

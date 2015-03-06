/*
Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input
<p>Please visit <a href="http://academy.telerik.com">our site</a> 
 to choose a training course. Also visit <a href="www.devbg.org">our forum</a>
 to discuss the courses.</p>	
 * 
output
<p>Please visit [URL=http://academy.telerik.com]our site[/URL] 
 to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL]
 to discuss the courses.</p>
*/

using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = @"<p>Please visit <a   href=""http://academy.telerik.com"">our site</a> 
 to choose a training course. Also visit <a href=""www.devbg.org""   >our forum<  /a>
 to discuss the courses.</p>";
        string regex = @"<\s*a\s[^>]*\bhref\s*=\s*('(?<hyperlink>[^']*)'|""(?<hyperlink>[^""]*)""|(?<hyperlink>\S*))[^>]*>(?<hyperlinktext>(.|\s)*?)<\s*/a\s*>";
        Console.WriteLine(Regex.Replace(text, regex, m => "[URL=" + m.Groups["hyperlink"].Value + "]" + m.Groups["hyperlinktext"].Value + "[/URL]"));
    }
}

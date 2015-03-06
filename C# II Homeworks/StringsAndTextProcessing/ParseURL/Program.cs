/*
Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	                                                                    Information
http://telerikacademy.com/Courses/Courses/Details/212	            [protocol] = http 
                                                               [server] = telerikacademy.com 
                                                         [resource] = /Courses/Courses/Details/212
*/

using System;

class Program
{
    static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        string protocol = url.Substring(0, url.IndexOf("://"));
        Console.WriteLine(url.IndexOf("://") + 1);
        int length = url.IndexOf("/", url.IndexOf("://") + 3) - url.IndexOf("://") - 3;
        string server = url.Substring(url.IndexOf("://") + 3, length);
        string resource = url.Substring(url.IndexOf("/", url.IndexOf("://") + 3));
        Console.WriteLine("Protocol: {0} ", protocol);
        Console.WriteLine("Server: {0} ", server);
        Console.WriteLine("Resource: {0} ", resource);
    }
}

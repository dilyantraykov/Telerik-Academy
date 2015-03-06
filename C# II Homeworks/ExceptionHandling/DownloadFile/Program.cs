/*
Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;

class Program
{
    static void Main()
    {
        try
        {
            WebClient webClient = new WebClient();
            string remoteUri = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = remoteUri.Substring(remoteUri.LastIndexOf("/")+1);
            string localPath = String.Format("../../{0}", fileName);
            Console.WriteLine("Downloading file \"{0}\"...", fileName);
            webClient.DownloadFile(remoteUri, localPath);
            Console.WriteLine("Successfully downloaded \"{0}\" from \"{1}\"!", fileName, remoteUri);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (WebException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}


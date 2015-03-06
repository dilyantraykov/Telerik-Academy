using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lasers
{
    class Program
    {
        static string[] cuboids = Console.ReadLine().Split();
        static int width = int.Parse(cuboids[0]);
        static int height = int.Parse(cuboids[1]);
        static int depth = int.Parse(cuboids[2]);
        static string[] lasers = Console.ReadLine().Split();
        static int laserWidth = int.Parse(lasers[0]);
        static int laserHeight = int.Parse(lasers[1]);
        static int laserDepth = int.Parse(lasers[2]);
        static string[] vectors = Console.ReadLine().Split();
        static int dirWidth = int.Parse(vectors[0]);
        static int dirHeight = int.Parse(vectors[1]);
        static int dirDepth = int.Parse(vectors[2]);
        static bool[, ,] matrix = new bool[width + 1, height + 1, depth + 1];

        static void Main(string[] args)
        {
            DeleteEdjes();
            bool opa;
            int oldWidth = 0;
            int oldHeight = 0;
            int oldDepth = 0;
            while (true)
            {
                CheckForWall(laserWidth, laserHeight, laserDepth);
                if (matrix[laserWidth, laserHeight, laserDepth] == true)
                {
                    break;
                }
                oldWidth = laserWidth;
                oldHeight = laserHeight;
                oldDepth = laserDepth;
                matrix[laserWidth, laserHeight, laserDepth] = true;
                laserWidth += dirWidth;
                laserHeight += dirHeight;
                laserDepth += dirDepth;
            }
            Console.WriteLine("{0} {1} {2}", oldWidth, oldHeight, oldDepth);
        }

        static void CheckForWall(int laserWidth, int laserHeight, int laserDepth)
        {
            if (laserWidth == width || laserWidth == 1)
            {
                dirWidth *= -1;
            }
            if (laserHeight == height || laserHeight == 1)
            {
                dirHeight *= -1;
            }
            if (laserDepth == depth || laserDepth == 1)
            {
                dirDepth *= -1;
            }
        }

        static void DeleteEdjes()
        {
            int curWidth = 1;
            int curHeight = 1;
            int curDepth = 1;
            for (int i = 1; i < height; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curHeight++;
            }
            curHeight = 1;
            for (int i = 1; i < width; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curWidth++;
            }
            curWidth = 1;
            for (int i = 1; i < depth; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curDepth++;
            }
            curDepth = depth;
            for (int i = 1; i < width; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curWidth++;
            }
            curDepth = 0;
            for (int i = 1; i < depth; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curDepth++;
            }
            curWidth = width;
            curHeight = 1;
            curDepth = 1;
            for (int i = 1; i < height; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curHeight++;
            }
            curHeight = 1;
            curDepth = depth;
            for (int i = 1; i < height; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curHeight++;
            }
            curWidth = 1;
            curHeight = 1;
            for (int i = 1; i < height; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curHeight++;
            }
            curWidth = 1;
            curHeight = height;
            curDepth = 1;
            for (int i = 1; i < width; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curWidth++;
            }
            curWidth = 1;
            curDepth = 1;
            for (int i = 1; i < depth; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curDepth++;
            }
            curWidth = width;
            curDepth = 1;
            for (int i = 1; i < depth; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curDepth++;
            }
            curWidth = 1;
            curDepth = depth;
            for (int i = 1; i < width; i++)
            {
                matrix[curWidth, curHeight, curDepth] = true;
                curWidth++;
            }
        }
    }
}
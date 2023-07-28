using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows;
using Automation.MouseMoveAndClickLibrary;

namespace MouseMoverAndClicker
{
    public class MouseMoverAndClicker
    {
        static void Main(string[] args)
        {
            // Screen Resolution:  1920 X 1080

            //TestMouseMoveAndClickDebug(new Point(960, 0), 5000);
            MouseMoveAndClick(new Point(1550, 0), 480000);
            //TestGetCursorDebug(5000);
            //TestGetCursor();
        }

        private static void MouseMoveAndClick(Point moveTo)
        {
            MouseMoveAndClickLibrary.MouseMove(moveTo);
            MouseMoveAndClickLibrary.SendMouseLeftClick(moveTo);
        }

        private static void MouseMoveAndClick(Point moveTo, int interval)
        {
            while(true)
            {
                MouseMoveAndClickLibrary.MouseMove(moveTo);
                MouseMoveAndClickLibrary.SendMouseLeftClick(moveTo);
                Thread.Sleep(interval);
            }
        }

        private static void TestMouseMoveAndClickDebug(Point moveTo, int interval)
        {
            int totSecElapsed = 0;
            int movAmount = 25;
            int count = 1;
            int thisInterval = 0;
            Point p = new Point(1550, 0);
            while (true)
            {
                Console.WriteLine($"Seconds Elapsed this Interval: {thisInterval}.");
                Console.WriteLine($"Total Seconds Elapsed: {totSecElapsed}");
                Console.WriteLine($"Dragging and Clicking the Mouse:  xcoord: {p.X}, ycoord: {p.Y}.");
                MouseMoveAndClickLibrary.MouseMove(p);
                MouseMoveAndClickLibrary.SendMouseLeftClick(p);
                Thread.Sleep(interval);
                p.X = p.X;
                p.Y = p.Y + movAmount;
                thisInterval = interval / 1000;
                totSecElapsed = count * interval / 1000;
                count++;
            }
        }

        private static void TestGetCursor()
        {
            Point p = new Point();
            MouseMoveAndClickLibrary.GetCursorPos(ref p);
        }

        private static void TestGetCursorDebug(int interval)
        {
            while(true)
            {
                Thread.Sleep(interval);
                Point p = new Point();
                MouseMoveAndClickLibrary.GetCursorPos(ref p);
                Console.WriteLine($"Current Cursor Position: X = {p.X}, Y = {p.Y}");
            }
        }
    }
}

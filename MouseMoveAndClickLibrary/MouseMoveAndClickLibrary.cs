using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;

namespace Automation.MouseMoveAndClickLibrary
{
    public class MouseMoveAndClickLibrary
    {
        const uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;
        const uint MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        const uint MOUSEEVENTF_MIDDLEUP = 0x0040;
        const uint MOUSEEVENTF_MOVE = 0x0001;
        const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        const uint MOUSEEVENTF_XDOWN = 0x0080;
        const uint MOUSEEVENTF_XUP = 0x0100;
        const uint MOUSEEVENTF_WHEEL = 0x0800;
        const uint MOUSEEVENTF_HWHEEL = 0x01000;

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(ref Point p);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        public static void SendMouseRightclick(Point p)
        {
            // Clicks left mouse button in Specified coordinates

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseRightclick()
        {
            // Clicks left mouse button in Current coordinates

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftDoubleClick(Point p)
        {
            // Clicks left mouse button in Specified coordinates

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);

            Thread.Sleep(150); 

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftDoubleClick()
        {
            // Clicks left mouse button in current coordinates

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void SendMouseRightDoubleClick(Point p)
        {
            // Clicks left mouse button in specified coordinates

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseRightDoubleClick()
        {
            // Clicks left mouse button in current coordinates

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, (UIntPtr)0);

            Thread.Sleep(150);

            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftClick(Point p)
        {
            // Clicks left mouse button in Specified coordinates

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftClick()
        {
            // Clicks left mouse button in current coordinates

            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftDown(Point p)
        {
            // Clicks left mouse button in specified coordinates

            mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftDown()
        {
            // Clicks left mouse button in current coordinates

            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftUp(Point p)
        {
            // Clicks left mouse button in specified coordinates

            mouse_event(MOUSEEVENTF_LEFTUP, (uint)p.X, (uint)p.Y, 0, (UIntPtr)0);
        }

        public static void SendMouseLeftUp()
        {
            // Clicks left mouse button in current coordinates

            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, (UIntPtr)0);
        }

        public static void MouseDrag(Point p)
        {
            // Mouse drag from current position to specified position

            SendMouseLeftDown();
            SetCursorPos(p.X, p.Y);
            SendMouseLeftUp();
        }

        public static void MouseDrag(Point from, Point to)
        {
            // Mouse drag from one specified position to another specified position

            Point mp = new Point(0, 0);
            SendMouseLeftDown(from);
            SetCursorPos(to.X, to.Y);
            SendMouseLeftUp();
        }

        public static void MouseMove(Point p)
        {
            // Move mouse to new position

            SetCursorPos(p.X, p.Y);
        }
    }
}

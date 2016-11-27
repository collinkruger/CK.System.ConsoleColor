using System;

namespace CK.System.ConsoleColor
{
    using static global::CK.System.Disposable.Disposable;
    using static global::System.Console;
    using static global::System.ConsoleColor;

    public static partial class ConsoleColorSet
    {
        /// <summary>
        /// Sets the the background color of the <see cref="global::System.Console"/> and returns an <see cref="global::System.IDisposable"/> that when disposed reassigns the previous color.
        /// </summary>
        public static IDisposable Background(global::System.ConsoleColor color)
        {
            var old = BackgroundColor;

            BackgroundColor = color;

            return Gen(() =>
            {
                ForegroundColor = old;
            });
        }

        public static IDisposable BackgroundBlack() => Foreground(Black);
        public static IDisposable BackgroundDarkBlue() => Foreground(DarkBlue);
        public static IDisposable BackgroundDarkGreen() => Foreground(DarkGreen);
        public static IDisposable BackgroundDarkCyan() => Foreground(DarkCyan);
        public static IDisposable BackgroundDarkRed() => Foreground(DarkRed);
        public static IDisposable BackgroundDarkMagenta() => Foreground(DarkMagenta);
        public static IDisposable BackgroundDarkYellow() => Foreground(DarkYellow);
        public static IDisposable BackgroundGray() => Foreground(Gray);
        public static IDisposable BackgroundDarkGray() => Foreground(DarkGray);
        public static IDisposable BackgroundBlue() => Foreground(Blue);
        public static IDisposable BackgroundGreen() => Foreground(Green);
        public static IDisposable BackgroundCyan() => Foreground(Cyan);
        public static IDisposable BackgroundRed() => Foreground(Red);
        public static IDisposable BackgroundMagenta() => Foreground(Magenta);
        public static IDisposable BackgroundYellow() => Foreground(Yellow);
        public static IDisposable BackgroundWhite() => Foreground(White);
    }
}

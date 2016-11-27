using System;

namespace CK.System.ConsoleColor
{
    using static global::CK.System.Disposable.Disposable;
    using static global::System.Console;
    using static global::System.ConsoleColor;

    /// <summary>
    /// Set/undo the <see cref="global::System.Console.ForegroundColor"/> and <see cref="global::System.Console.BackgroundColor"/>, leveraging <see cref="global::System.IDisposable"/>.
    /// </summary>
    public static partial class ConsoleColorSet
    {
        /// <summary>
        /// Sets the the foreground color of the <see cref="global::System.Console"/> and returns an <see cref="global::System.IDisposable"/> that when disposed reassigns the previous color.
        /// </summary>
        public static IDisposable Foreground(global::System.ConsoleColor color)
        {
            var old = ForegroundColor;

            ForegroundColor = color;

            return Gen(() =>
            {
                ForegroundColor = old;
            });
        }
        
        public static IDisposable ForegroundBlack() => Foreground(Black);
        public static IDisposable ForegroundDarkBlue() => Foreground(DarkBlue);
        public static IDisposable ForegroundDarkGreen() => Foreground(DarkGreen);
        public static IDisposable ForegroundDarkCyan() => Foreground(DarkCyan);
        public static IDisposable ForegroundDarkRed() => Foreground(DarkRed);
        public static IDisposable ForegroundDarkMagenta() => Foreground(DarkMagenta);
        public static IDisposable ForegroundDarkYellow() => Foreground(DarkYellow);
        public static IDisposable ForegroundGray() => Foreground(Gray);
        public static IDisposable ForegroundDarkGray() => Foreground(DarkGray);
        public static IDisposable ForegroundBlue() => Foreground(Blue);
        public static IDisposable ForegroundGreen() => Foreground(Green);
        public static IDisposable ForegroundCyan() => Foreground(Cyan);
        public static IDisposable ForegroundRed() => Foreground(Red);
        public static IDisposable ForegroundMagenta() => Foreground(Magenta);
        public static IDisposable ForegroundYellow() => Foreground(Yellow);
        public static IDisposable ForegroundWhite() => Foreground(White);
    }
}

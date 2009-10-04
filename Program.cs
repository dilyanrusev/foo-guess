using System;

namespace Foo.Guess
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (FooGuess game = new FooGuess())
            {
                game.IsMouseVisible = true;
                game.Run();
            }
        }
    }
}


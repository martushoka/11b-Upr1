using MusicHub1.Data;
using System;

namespace MusicHub1
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MusicHub1Context();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}

using System;
using DiscogsSharp.Enums;

namespace DiscogsSharp.Abstractions
{
    public class Genre
    {
        public Guid Id { get; private set; }
        public Genres GenreName { get; private set; }

        public Genre(Genres genreName)
        {
            Id = Guid.NewGuid();
            GenreName = genreName;
        }
    }
}

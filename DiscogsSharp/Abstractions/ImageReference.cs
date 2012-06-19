using System;

namespace DiscogsSharp.Abstractions
{
    public abstract class ImageReference
    {
        public ImageType Type { get; protected set; }
        public int Height { get; protected set; }
        public int Width { get; protected set; }

        public Uri Uri { get; protected set; }
        public Uri Uri150 { get; protected set; }
        //public Uri ResourceUri { get; protected set; } //Possible duplicate of Uri?
    }

    public enum ImageType
    {
        Primary,
        Secondary,
    }
}
using System;
using System.Collections.Generic;
using DiscogsSharp.Enums;

namespace DiscogsSharp.Abstractions
{
    public abstract class Artist
    {
        public DataQuality DataQuality { get; protected set; }

        public long Id { get; protected set; }
        public string Name { get; protected set; }
        public string RealName { get; protected set; }
        public string Profile { get; protected set; }

        public IList<Artist> Aliases { get; protected set; }

        public IList<Uri> Urls { get; protected set; }

        public IList<ImageReference> Images { get; protected set; }

        public Uri ProfileUri { get; protected set; }
        protected Uri ApiResourceUri { get; set; }
        protected Uri ApiReleasesUri { get; set; }

        protected Artist()
        {
            Aliases = new List<Artist>();
            Urls = new List<Uri>();
            Images = new List<ImageReference>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic_Reader
{
    public interface IReader
    {
        IEnumerable<FeedItem> Read(string url);
    }
}

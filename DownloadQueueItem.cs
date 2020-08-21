using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace GDrive.Framework
{
    public class DownloadQueueItem
    {
        public string FileUrl { get; private set; }
        public string PathToSave { get; private set; }
        public long FileSize { get; private set; }

        public WaitHandle StopEvent {get; set;}
        public object QueueItem { get; set; }

        public DownloadQueueItem(string file, string path, long size)
        {
            FileUrl = file;
            PathToSave = path;
            FileSize = size;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            var item = obj as DownloadQueueItem;
            if (item == null)
                return false;

            return this.QueueItem != null && this.QueueItem.Equals(item.QueueItem);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

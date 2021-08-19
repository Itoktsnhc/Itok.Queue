using System;

namespace Itok.Queue.File
{
    public class QueueItem : IEquatable<QueueItem>
    {
        public byte[]? Data { get; set; }

        /// <summary> File number </summary>
        public int FileNumber { get; }

        /// <summary> offset of start of entry in file </summary>
        public int Start { get; }

        /// <summary> length of entry on disk </summary>
        public int Length { get; }

        public QueueItem(Operation operation)
            : this(operation.FileNumber, operation.Start, operation.Length)
        {
        }

        public QueueItem(int fileNumber, int start, int length)
        {
            FileNumber = fileNumber;
            Start = start;
            Length = length;
        }

        public bool Equals(QueueItem? other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((QueueItem)obj);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(QueueItem left, QueueItem right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(QueueItem left, QueueItem right)
        {
            return !Equals(left, right);
        }
    }
}
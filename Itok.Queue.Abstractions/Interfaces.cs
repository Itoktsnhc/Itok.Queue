using System;

namespace Itok.Queue.Abstractions
{
    /// <summary>
    /// Queue should be singleton for each queue store
    /// </summary>
    public interface IQueue: IDisposable
    {
        IQueueSession OpenSession();
    }

    public interface IQueueSession : IDisposable
    {
        /// <summary>
        /// Pre-Dequeue, item added after <see cref="Flush"/> is called
        /// </summary>
        /// <param name="data"></param>
        void Enqueue(byte[] data);

        /// <summary>
        /// Pre-Dequeue, item removed after <see cref="Flush"/> is called
        /// </summary>
        /// <returns>null if queue is empty</returns>
        byte[]? Dequeue();

        /// <summary>
        /// Commit operations since last flush.
        /// </summary>
        void Flush();
    }
}
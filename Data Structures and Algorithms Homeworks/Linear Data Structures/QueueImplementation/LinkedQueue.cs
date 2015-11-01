namespace QueueImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedQueue<T> : IEnumerable
    {
        private LinkedList<T> list;

        public LinkedQueue()
        {
            this.list = new LinkedList<T>();
        }

        public void Enqueue(T item)
        {
            this.list.AddLast(item);
        }

        public T Dequeue()
        {
            var item = this.list.First;
            this.list.RemoveFirst();

            return item.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var item = this.list.First;

            for (var i = 0; i < this.list.Count; i++)
            {
                if (item != null)
                {
                    yield return item.Value;

                    item = item.Next;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

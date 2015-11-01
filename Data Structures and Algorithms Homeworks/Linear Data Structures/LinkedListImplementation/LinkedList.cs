namespace LinkedListImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable
    {
        public ListItem<T> FirstElement { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            var currentItem = this.FirstElement;

            while (currentItem != null)
            {
                yield return currentItem.Value;

                currentItem = currentItem.NextItem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void Add(T value)
        {
            var item = new ListItem<T>(value);

            if (this.FirstElement == null)
            {
                this.FirstElement = item;
            }
            else if (this.FirstElement.NextItem == null)
            {
                this.FirstElement.NextItem = item;
            }
            else
            {
                var lastItem = this.FirstElement.NextItem;

                while (lastItem.NextItem != null)
                {
                    lastItem = lastItem.NextItem;
                }

                lastItem.NextItem = item;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStuff
{
    public static class Util
    {
        public static List<T> Shuffle<T>(this List<T> stuff)
        {
            List<T> temp = new List<T>();
            for (int i = 0; i < stuff.Count; i++)
            {
                Random rng = new Random();
                int o = rng.Next(stuff.Count);
                T something = temp[o];
                temp[o] = temp[i];
                temp[i] = something;
            }
            return temp;
        }
    }
    class PriorityQ<T> where T : IComparable , new()
    {
        LinkedList<T> _llQueue = new LinkedList<T>();

        public int Count
        {
            get { return _llQueue.Count(); }
            private set { }
        }

        public void Clear()
        {
            _llQueue.Clear();
        }

        public int Enqueue(object o)
        {
            LinkedListNode<T> temp;
            if (Count == 0)
                _llQueue.AddFirst((T)o);

            else
            {

                for (var node = _llQueue.First; node != null; node = node.Next)
                {
                    if (node.Value.CompareTo(o) == 0)
                    {

                        _llQueue.AddAfter(node, (T)o);
                    }


                    else if (node.Value.CompareTo(o) > 0)
                        _llQueue.AddBefore(node, (T)o);

                    else if (node.Value.CompareTo(o) < 0)
                    {
                        if (node.Next == null)
                            _llQueue.AddLast((T)o);
                        else
                            continue;
                    }

                    break;
                }
            }

            return Count;
        }

        public T Dequeue()
        {
            if (Count == 0)
                throw new IndexOutOfRangeException("The queue is empty!");

            T temp = _llQueue.First();
            _llQueue.RemoveFirst();
            return temp;
        }
    }
}


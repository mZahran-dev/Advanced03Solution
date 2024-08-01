using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv03.ListMethods
{
    internal class ListMethodsImplement<T>
    {

        #region property and Constructor
        private List<T> _items;

        public ListMethodsImplement()
        {
            _items = new List<T>();
        } 
        #endregion

        #region Methods
        public void Add(T item)
        {
            _items.Add(item);
        }

        public bool Exists(Predicate<T> match)
        {
            foreach (var item in _items)
            {
                if (match(item))
                {
                    return true;
                }
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            foreach (var item in _items)
            {
                if (match(item))
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> results = new List<T>();
            foreach (var item in _items)
            {
                if (match(item))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return _items[i];
                }
            }
            return default(T);
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = _items.Count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                {
                    return i;
                }
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            foreach (var item in _items)
            {
                action(item);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            foreach (var item in _items)
            {
                if (!match(item))
                {
                    return false;
                }
            }
            return true;
        } 
        #endregion

    }
}

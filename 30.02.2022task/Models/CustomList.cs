using System;
using System.Collections.Generic;
using System.Text;

namespace _30._02._2022task.Models
{
    class CustomList<T>

    {
        private T[] _templist;
        private T[] _list;
        private int _capacity;
        public int Capacity {
            get 
            {
                return _capacity;
            }
            set 
            {
                if (Capacity>Count)
                {
                    _capacity = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Count cant upper then Capacity");
                }
            }
        }
        public int Count 
        {
            get 
            {
                return _list.Length;
            }
        }
        public CustomList()
        {
            _list = new T[0];
        }
        public CustomList(params T[] nums)
        {
            _list = new T[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                _list[i] = nums[i];
            }
        }
        public T this[int index] 
        {
            get
            {
                return _list[ index];
            }
            set
            {
                
                _list[index] = value;
            }
            
        }
        public void Add(T input)
        {
            
            _templist = _list;

            _list = new T[_list.Length + 1];
            for (int i = 0; i < _templist.Length; i++)
            {
                _list[i] = _templist[i];
            }
            _list[_list.Length - 1] = input;

        }
        public void Show()
        {
            foreach (T item in _list)
            {
                Console.WriteLine(item);
            }
        }
        public void Remove(T input)
        {
            //for (int i = 0; i < _list.Length-1; i++)
            //{
            //    if (i.Equals(input))
            //    {

                    
            //    }
            //}            
        }
        public void Reverse()
        {
            //_templist = _list;
            //for (int i = _templist.Length - 1; i > 0; i--)
            //{
                 
            //}
            
        }
        public void Clear()
        {
            Array.Resize(ref _list,0);
        }
        public int IndexOf(T input)
        {
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
        public int LastIndexOf(T input)
        {
            for (int i = _list.Length-1; i > 0; i--)
            {
                if (_list[i].Equals(input))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Exist(T input)
        {
            for (int i = 0; i < _list.Length; i++)
            {
                if (_list[i].Equals(input))
                {
                    return true;
                }
            }
            return false;

        }
    }
}

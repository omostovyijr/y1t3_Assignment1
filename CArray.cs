using System.Linq;

namespace Assignment_1
{
    public class CArray
    {
        private static object[] _array = new object[15];

        private int _tailPointer = 0;

        public void Insert(int index, object element)
        {
            if (_tailPointer >= _array.Length)
            {
                var extendArray = new object[_array.Length * 2];
                for (var i = 0; i < _array.Length; i++)
                {
                    extendArray[i] = (int) _array[i];
                }
                _array = extendArray;
            }
            
            for (var i = _tailPointer; i != index; i--)
            {
                _array[i] = _array[i - 1];
            }

            _array[index] = element;
            _tailPointer += 1;
        }

        public void Push(object element)
        {
            Insert(_tailPointer, element);
        }

        public void Remove(int element)
        {
            var index = IndexOf(element);

            if (index == -1)
            {
                return;
            }

            _array[index] = 0;
            for (var i = index; i < _array.Length; i++)
            {
                _array[i] = _array[i + 1];
            }

            _tailPointer -= 1;
        }

        public object Pop()
        {
            var lastElement = _array[_tailPointer - 1];

            _array[_tailPointer] = 0;
            _tailPointer -= 1;
            
            return lastElement;
        }

        public object GetAt(int index)
        {
            return _array[index];
        }

        public static int IndexOf(int element)
        {
            var index = -1;
            for (var i = 0; i < _array.Length; i++)
            {
                if (element == (int) _array[i])
                {
                    return i;
                }
            }

            return index;
        }

        public bool Empty()
        {
            return _tailPointer == 0;
        }

        public object[] ToArray()
        {
            return _array.ToArray();
        }
    }
}

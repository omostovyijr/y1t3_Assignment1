using System;

namespace Assignment_1
{
    public class CStack
    {
        private object[] _array = new object[50];

        private int _pointer = 0;

        public void Push(object element)
        {
            if (_pointer == _array.Length)
            {
                // todo: We should extend it(!)
                throw new Exception("Stack overflow.");
            }
            
            _array[_pointer] = element;
            _pointer += 1;
        }

        public object Pop()
        {
            var returnValue = _array[_pointer -1];
            _pointer -= 1;
            _array[_pointer] = null;
            
            return returnValue;
        }

        public object Search()
        {
            if (_pointer == 0)
            {
                throw new Exception("Stack is empty.");
            }
            
            return _array[_pointer - 1];
        }

        public object LastElement()
        {
            return _pointer - 1;
        }

        public bool CheckIfEmpty()
        {
            if (_pointer == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

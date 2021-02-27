using System;

namespace StackRealisation
{
    public class Stackkk : IStack
    {
        private int[] _numbers;
        private int _indexOfLastNumber = -1;
        private int _maxSize;
        private int _amountOfNumbers = 0;

        //Constructors
        public Stackkk(int capacity)
        {
            _maxSize = capacity;
            _numbers = new int[capacity];
        }

        public Stackkk()
        {
            _maxSize = 4;
            _numbers = new int[4];
        }
        
        public int Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack empty.");
            }
            else
            {
                int valueToReturn = _numbers[_indexOfLastNumber];
                _numbers[_indexOfLastNumber] = 0;
                _indexOfLastNumber--;
                _amountOfNumbers--;
                return valueToReturn;
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack empty.");
            }
            else
            {
                return _numbers[_indexOfLastNumber];
            }
        }

        public void Push(int item)
        {
            if (_amountOfNumbers == _maxSize)
            {
                Console.WriteLine("RESIZING");
                _maxSize *= 2;
                int[] tempArray = new int[_maxSize];
                Array.Copy(_numbers, 0, tempArray, 0, _numbers.Length);
                _numbers = tempArray;
            }
            _indexOfLastNumber++;
            _amountOfNumbers++;
            _numbers[_indexOfLastNumber] = item;
        }

        public bool IsEmpty()
        {
            return _amountOfNumbers == 0;
        }
    }
}


//array resize Push: добавляет элемент в стек на первое место

//Pop: извлекает и возвращает первый элемент из стека

//Peek: просто возвращает первый элемент из стека без его удаления
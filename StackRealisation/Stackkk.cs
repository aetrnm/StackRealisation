using System;

namespace StackRealisation
{
    public class Stackkk : IStack
    {
        private int[] _numbers;
        private int _amountOfNumbers = -1;
        private int _maxSize;

        public Stackkk(int capacity)
        {
            _maxSize = capacity;
            Array.Resize(ref _numbers, _maxSize);
        }

        public Stackkk()
        {
            _maxSize = 4;
            Array.Resize(ref _numbers, _maxSize);
        }
        
        public int Pop()
        {
            if (_amountOfNumbers == -1)
            {
                throw new InvalidOperationException("Stack empty.");
            }
            else
            {
                int valueToReturn = _numbers[_amountOfNumbers];
                _numbers[_amountOfNumbers] = 0;
                _amountOfNumbers--;
                return valueToReturn;
            }
        }

        public int Peek()
        {
            if (_amountOfNumbers == -1)
            {
                throw new InvalidOperationException("Stack empty.");
            }
            else
            {
                return _numbers[_amountOfNumbers];
            }
        }

        public void Push(int item)
        {
            if (_amountOfNumbers + 1 == _maxSize)
            {
                Console.WriteLine("RESIZING");
                _maxSize *= 2;
                int[] tempArray = new int[_maxSize];
                Array.Copy(_numbers, 0, tempArray, 0, _numbers.Length);
                _numbers = tempArray;
            }
            _amountOfNumbers++;
            _numbers[_amountOfNumbers] = item;
        }

        public bool IsEmpty()
        {
            return _amountOfNumbers == -1;
        }
    }
}


//array resize Push: добавляет элемент в стек на первое место

//Pop: извлекает и возвращает первый элемент из стека

//Peek: просто возвращает первый элемент из стека без его удаления
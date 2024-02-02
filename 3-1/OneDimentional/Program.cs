using System;

public class OneD_Array
{
    private int[] _array;

    public OneD_Array(int length, bool Keyboard_Input = false)
    {
        _array = new int[length];
        if (Keyboard_Input == false)
        {
            Initialize();
        }
        else
        {
            Keyboard_Initialiize();
        }
    }

    private void Initialize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = rnd.Next(0, 150);
        }
    }

    private void Keyboard_Initialiize()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            _array[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Print_Array()
    {
        Print_Array(_array);
    }

    private static void Print_Array(int[] _arr)
    {
        for (int i = 0; i < _arr.Length; i++)
        {
            Console.Write(_arr[i] + " ");
        }
        Console.WriteLine();
    }

    public double Mid_Value()
    {
        int value_sum = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            value_sum += _array[i];
        }
        return value_sum / _array.Length;
    }

    public void Delite_Values_More_Than_Mod_100()
    {
        int new_array_length = 0;

        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] > -100 && _array[i] < 100)
            {
                new_array_length++;
            }
        }

        int[] new_array = new int[new_array_length];
        int new_array_ind = 0;

        for (int i = 0; i < _array.Length; i++)
        {
            if (_array[i] > -100 && _array[i] < 100)
            {
                new_array[new_array_ind] = _array[i];
                new_array_ind++;
            }
        }
        _array = new_array;
    }

    public void Delite_Unique_Values()
    {
        int new_arr_length = _array.Length;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = i; j < _array.Length; j++)
            {

                if (_array[i] == _array[j] && i != j)
                {
                    new_arr_length--;
                    break;
                }
            }
        }
        int Counter = 0;
        int[] new_arr = new int[new_arr_length];
        for (int k = 0; k < _array.Length; k++)
        {
            if (!Contain(new_arr, _array[k]))
            {
                new_arr[Counter] = _array[k];
                Counter++;
            }
        }
        Print_Array(new_arr);
    }

    private static bool Contain(int[] arr, int symb)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (symb == arr[i])
            {
                return true;
            }
        }
        return false;
    }
}

public class Program
{
    static void Main(string[] args)
        {
            //main для одномерных массивов
            Console.WriteLine("Введите длинну Вашего одномерного массива: ");
            int Arr_Len = int.Parse(Console.ReadLine());

            Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
            Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
            bool _Keyboard_Input = bool.Parse(Console.ReadLine());

            OneD_Array _1D_Arr = new OneD_Array(Arr_Len, _Keyboard_Input);

            _1D_Arr.Print_Array();
            Console.WriteLine("Среднее значение: ");
            Console.WriteLine(_1D_Arr.Mid_Value());
            Console.WriteLine("Массив без одинаковых значений: ");
            _1D_Arr.Delite_Unique_Values();
            Console.WriteLine("Массив без значений >100 по модулю: ");
            _1D_Arr.Delite_Values_More_Than_Mod_100();
            _1D_Arr.Print_Array();
            Console.ReadLine();
        }
}
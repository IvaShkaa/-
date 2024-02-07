using System;

public class Step_Array
{
    private int[][] _array;

    public Step_Array(int Length, bool Keyboard_Input)
    {
        _array = new int[Length][];
        if (Keyboard_Input == false)
        {
            Initialiize();
        }
        else
        {
            Keyboard_Initialiize();
        }
    }

    private void Initialiize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            int arr_length = rnd.Next(1, 8);
            _array[i] = new int[arr_length];
            for (int j = 0; j < arr_length; j++)
            {
                _array[i][j] = rnd.Next(0, 100);
            }
        }
    }

    private void Keyboard_Initialiize()
    {
        Random rnd = new Random();
        for (int i = 0; i < _array.Length; i++)
        {
            Console.WriteLine("Введите длинну подмассива: ");
            int arr_length = int.Parse(Console.ReadLine());
            _array[i] = new int[arr_length];
            for (int j = 0; j < _array[i].Length; j++)
            {
                _array[i][j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public double Mid_Value()
    {
        int value_sum = 0;
        int value_counter = 0;
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                value_sum += _array[i][j];
                value_counter += 1;
            }
        }
        return value_sum / value_counter;
    }

    public string Mid_Subarray_Value()
    {
        string mid_val_arr = "";
        for (int i = 0; i < _array.Length; i++)
        {
            int value_sum = 0;
            for (int j = 0; j < _array[i].Length; j++)
            {
                value_sum += _array[i][j];
            }
            mid_val_arr += value_sum / _array[i].Length + " ";
        }
        return mid_val_arr;
    }

    public void Change_Even_Values()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                if (_array[i][j] % 2 == 0)
                {
                    _array[i][j] = i * j;
                }
            }
        }
    }

    public void Print_Array()
    {
        for (int i = 0; i < _array.Length; i++)
        {
            for (int j = 0; j < _array[i].Length; j++)
            {
                Console.Write(_array[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //main для ступенчатых массивов
        Console.WriteLine("Введите количество подмассивов в вашем двумерном массиве:");
        int Step_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _Keyboard_Input = bool.Parse(Console.ReadLine());

        Step_Array Step_Arr = new Step_Array(Step_Arr_length, _Keyboard_Input);

        Console.WriteLine("Обычный вывод массива");
        Step_Arr.Print_Array();
        Console.WriteLine("Среднее значение: ");
        Console.WriteLine(Step_Arr.Mid_Value());
        Console.WriteLine("Среднее значение в каждом подмассиве: ");
        Console.WriteLine(Step_Arr.Mid_Subarray_Value());
        Console.WriteLine("Замена чётных элементов на произведение их индексов: ");
        Step_Arr.Change_Even_Values();
        Step_Arr.Print_Array();
        Console.ReadLine();
    }
}

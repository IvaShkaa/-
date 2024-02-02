using System;

public class TwoD_Array
{
    public int[,] _array;
    public bool Keyboard_Input = false;

    public TwoD_Array(int _Height, int _Length, bool Keyboard_Input)
    {
        _array = new int[_Height, _Length];
        if (Keyboard_Input == false)
        {
            Initialiize();
        }
        else
        {
            Keyboard_Initialiize();
        }
    }
    public int Height
    {
        get
        {
            return _array.GetLength(0);
        }
    }

    public int Length
    {
        get
        {
            return _array.GetLength(1);
        }
    }

    private void Initialiize()
    {
        Random rnd = new Random();
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                _array[i, j] = rnd.Next(0, 100);
            }
        }
    }

    private void Keyboard_Initialiize()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                _array[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public double Mid_Value()
    {
        int value_sum = 0;
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                value_sum += _array[i, j];
            }
        }
        return value_sum / _array.Length;
    }

    public void Print_Array()
    {
        for (int i = 0; i < Height; i++)
        {
            for (int j = 0; j < Length; j++)
            {
                Console.Write(_array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void Print_Snake_Array()
    {
        for (int i = 0; i < Height; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = Length - 1; j >= 0; j--)
                {
                    Console.Write(_array[i, j] + " ");
                }
            }
            else
            {
                for (int j = 0; j < Length; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        //main для двумерных массивов
        Console.WriteLine("Введите количество строк в вашем двумерном массиве:");
        int _2D_Arr_height = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов в вашем двумерном массиве:");
        int _2D_Arr_length = int.Parse(Console.ReadLine());

        Console.WriteLine("Если вы хотите ввести значения с помощью клавиатуры введите true");
        Console.WriteLine("Если вы не хотите вводить значения с помощью клавиатуры введите false");
        bool _Keyboard_Input = bool.Parse(Console.ReadLine());

        TwoD_Array _2D_Arr = new TwoD_Array(_2D_Arr_length, _2D_Arr_height, _Keyboard_Input);

        Console.WriteLine("Обычный вывод массива: ");
        _2D_Arr.Print_Array();
        Console.WriteLine("Среднее значение: ");
        Console.WriteLine(_2D_Arr.Mid_Value());
        Console.WriteLine("Вывод массива змейкой:");
        _2D_Arr.Print_Snake_Array();
        Console.ReadLine();
    }
}   
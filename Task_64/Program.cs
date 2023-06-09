Console.WriteLine("Введите начало отсчета: ");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец отсчета: ");
int finish = Convert.ToInt32(Console.ReadLine());

CountDownOne(start, finish);
Console.WriteLine();
CountDownTwo(start, finish);

// I. Способ: 

void CountDownOne(int start, int finish){
    if (start < finish){
        return;
    }
    Console.Write($"{start}, ");
    CountDownOne(start - 1, finish);
}

// II. Способ:

void CountDownTwo(int start, int finish){
    if (finish > start){
        return;
    }
    CountDownTwo(start, finish + 1);
    Console.Write($"{finish}, ");
}

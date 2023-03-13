Console.WriteLine("введите M чисел...");
string line = Console.ReadLine();

string[] lineArr = line.Split(' ');
int[] M = Array.ConvertAll(lineArr, int.Parse);

int count = 0;

for (int i = 0; i < M.Length; i++)
{
    if(M[i] > 0)
    {
        count++;
    }
}

Console.WriteLine(count);
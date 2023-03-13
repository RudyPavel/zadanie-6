string line1 = Console.ReadLine();
string line2 = Console.ReadLine();

string[] line1Arr = line1.Split(' ');
double[] vector1 = Array.ConvertAll(line1Arr, double.Parse);
string[] line2Arr = line2.Split(' ');
double[] vector2 = Array.ConvertAll(line2Arr, double.Parse);

double b1 = vector1[0];
double k1 = vector1[1];

double b2 = vector2[0];
double k2 = vector2[1];

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"-> ({x},{y})");
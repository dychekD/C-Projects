int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 4;
int b1 = 3;
int c1 = 7;
int a2 = 85;
int b2 = 38;
int c2 = 796;
int a3 = 54;
int b3 = 65;
int c3 = -7;

int result1 = Max(a1, b1, c1);
int result2 = Max(a2, b2, c2);
int result3 = Max(a3, b3, c3);
int result4 = Max(result1, result2, result3);
Console.WriteLine (result4);
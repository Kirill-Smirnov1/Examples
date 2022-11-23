int Max(int arg1, int arg2, int arg3)
{
    int resalt = arg1;
    if(arg2 > resalt) resalt = arg2;
    if(arg3 > resalt) resalt = arg3;
    return resalt;
}

int a1 = 10;
int b1 = 20;
int c1 = 30;
int a2 = 40;
int b2 = 50;
int c2 = 60;
int a3 = 70;
int b3 = 80;
int c3 = 90;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);
int max = Max(max1, max2, max3);
Console.WriteLine(max);

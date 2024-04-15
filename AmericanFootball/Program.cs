using static System.Console;
using static System.Convert;
using static System.Math;


int n, a, b, s;
string str1 = ReadLine();
string str2 = "";
var arr = str1.Split(" ");
n = ToInt32(arr[0]);
a = ToInt32(arr[1]);
b = ToInt32(arr[2]);
s = ToInt32(arr[3]);
int res1 = a * (n - 1) + b;
int res2 = b * (n - 1) + a;
if (s >= res1 && s <= res2)
{
    str2 = "YES";
}
else
{
    str2 = "NO";
}

WriteLine(str2);



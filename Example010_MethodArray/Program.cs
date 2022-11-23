int [] array = {23,31,-67,-100,-800,690,510,260,1000,-800};
int n = array.Length;
int find = -800;
int index = 0;
while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        //break;
    }
    index++;
}

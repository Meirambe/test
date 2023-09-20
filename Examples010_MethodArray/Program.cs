int[] array = {15,32,83,34,18,25,63,75,18};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}
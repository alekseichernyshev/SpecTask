
string[] array = {"Russia", "Denmark", "Kazan"};
int count = Count(array);
string[] result= CreateArray(count);
FillArray(array, result);
PrintArray(result);


static int Count(string[] array){
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}
static string[] CreateArray(int size){
    return new string[size];
}

void FillArray(string[] array, string[] array2){
    int index;
    int i;
    for (i = 0, index = 0; i < array.Length; i++, index++)
    {
        if(array[i].Length>3){
            index--;
            continue;
        }if (array[i].Length<=3)
        {
            array2[index] = array[i];
        }
    }
}
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


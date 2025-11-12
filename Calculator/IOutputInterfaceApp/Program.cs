using IOutputInterfaceApp;

int[] numbers = { 1, 3, 6, 12, 0 };
MyArray myArray = new MyArray(numbers);

//Task 1
myArray.Show();
myArray.Show("Message example!");

//Task 2
Console.WriteLine($"Max value: {myArray.Max()}");
Console.WriteLine($"Min value: {myArray.Min()}");
Console.WriteLine($"Avg value: {myArray.Avg()}");

Console.Write("Enter value to search in array: ");
int value = int.Parse(Console.ReadLine());
if (myArray.Search(value))
    Console.WriteLine($"Entered value ({value}) is found \n");
else
    Console.WriteLine($"Entered value ({value}) isn't found \n");

//Task 3
myArray.SortAsc();
myArray.Show("Ascending sorting:");

myArray.SortDesc();
myArray.Show("Descending sorting:");

myArray.SortByParam(true);
myArray.Show("SortByParam - Ascending sorting");

myArray.SortByParam(false);
myArray.Show("SortByParam - Descending sorting");




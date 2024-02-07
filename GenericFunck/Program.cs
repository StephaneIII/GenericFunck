using GenericFunck;


List<int> intList = new List<int>() { 5, 10, 3, 8, 15 };
Console.WriteLine("Largest element in intList: " + Functions<int>.FindLargest(intList)); // Output: 15


List<double> doubleList = new List<double>() { 3.14, 2.718, 1.618, 2.0 };
Console.WriteLine("Largest element in doubleList: " + Functions<double>.FindLargest(doubleList)); // Output: 3.14

List<string> stringList = new List<string>() { "apple", "banana", "orange", "kiwi" };
Console.WriteLine("Largest element in stringList: " + Functions<string>.FindLargest(stringList)); // Output: orange

[![.NET 6.0](https://img.shields.io/badge/.Net-6.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
# Final control work on the main block

This code is written in C#. It is a program that creates a new array of strings from an existing array, containing only the strings that have a length less than or equal to 3 characters. The original array is entered via the keyboard.

![Block diagram](https://github.com/MarinaZhdanovich/exam_work/blob/main/Blockdiagram.jpg)

## How to use

1. Run the program using the command `dotnet run`. The program will ask you to enter the size of the array. Please, input a positive integer.

2. Next, you will be asked to enter each string for the array one by one. Repeat this step until the array is filled with all the strings.

3. The program will display the original array of strings.

4. Finally, it will output a new array containing only the strings that have a length of 3 characters or less.

## Functions

* `int InputNum(string message)`. It shows a message to the user and asks for input of an integer. It returns the number entered by the user.

* `string InputString(string message)`. It shows a message to the user and asks for input of a string. It returns the string entered by the user.

* `string[] CreateArray(int size)`. The function takes an integer (size) as input. It creates a new array of strings with the specified size and returns this new array.

* `void FillArray(string[] array)`. This function takes an array of strings as input and fills it with strings entered by the user using the `InputString` function.

* `void PrintArray(string[] array)`. The function takes an array of strings as input and prints its contents.

* `int CountShortStringSize(string[] array)`. It counts the number of strings in the array that have a length less than or equal to 3 characters. It then returns the count as an integer.

* `string[] NewShortStringArray (string[] array)`. This function takes an array of strings as input. It first calls the CountShortStringSize method to determine the number of strings that meet the condition (length <= 3). Then, it creates a new array of strings with the size equal to the count obtained. After that, it populates the new array with the qualifying strings from the input array. Finally, it returns the new array containing the qualifying strings.
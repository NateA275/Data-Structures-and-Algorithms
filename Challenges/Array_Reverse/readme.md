# Reverse an Array

## Summary of Challenge

Write a function called ArrayReverse() which takes an array as an argument.
Withouth utilizing any of the built-in methods available to your language, return
the provided array argument with elements in reversed order.

## Whiteboard

![whiteboard_image](../../assets/array_reverse.jpg)


## Code
```C#
        static int[] ArrayReverse(int[] arr)
        {
            int n = arr.Length; //Set variable for length, since it is used often.
            int[] newArr = new int[n]; //Declare new integer array to hold solution
            for (int i = 0; i < n; i++)
            {
                newArr[i] = arr[n - (i + 1)]; //Assign values to new array
            }
            return newArr; //Return the resultant
        }
```

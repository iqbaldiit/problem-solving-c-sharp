// See https://aka.ms/new-console-template for more information
//https://www.w3schools.com/dsa/dsa_data_arrays.php
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using DataStructureAlgorithm.Topic;
using DataStructureAlgorithm.Problems;
using DataStructureAlgorithm;
using DataStructureAlgorithm.Hackerrank;
using DataStructureAlgorithm.LeetCode;
using DataStructureAlgorithm.LeetCode.ArrayString;

//// Fibonakki Series By Loop
//var val1 = 0;
//var val2 = 1;
//System.Console.WriteLine(val1);
//System.Console.WriteLine(val2);

//for (var i = 0; i < 18; i++)
//{
//    var fibo = val2 + val1;
//    System.Console.WriteLine(fibo);
//    val1 = val2;
//    val2 = fibo;
//}


//// Fibonakki Series By recursive
//int nCount = 2;
//void fibbonakki(int val1,int val2)
//{
//    if (nCount <= 19)
//    {
//        var fibo = val1 + val2;
//        System.Console.WriteLine(fibo);
//        nCount++;
//        val1 = val2;
//        val2 = fibo;
//        fibbonakki(val1, val2);
//    }
//    else { return; }
//}
//System.Console.WriteLine(0);
//System.Console.WriteLine(1);
//fibbonakki(0, 1);


////Array: Find the lowest value.
//int[] ary = [2, 5, 45, 6, 7];

//var a=ary[0];


//for (int i = 0; i < ary.Length; i++)
//{
//    if (ary[i] < a) { a = ary[i]; }
//}
//System.Console.WriteLine(a);


////Bubble Sort: Bubble Sort is an algorithm that sorts an array from the lowest value to the highest value.

//int[] my_array = [64, 34, 25, 12, 22, 11, 90, 5];
//var length=my_array.Length;

//for (int i = 0; i < length; i++)
//{
//    for (int j = 0; j < length - i - 1; j++)
//    {
//        var item=my_array[j];
//        var nextValue=my_array[(j+1)];
//        if (item > nextValue)
//        {
//            my_array[j+1]=item;
//            my_array[j]=nextValue;
//        }
//    }
//}

//for (int i = 0;i < length; i++)
//{
//    System.Console.WriteLine(my_array[i]);
//}


//Selection Sort :https://www.w3schools.com/dsa/dsa_algo_selectionsort.php

//int[] my_array = [64, 34, 25, 12, 22, 11, 90, 5];
//var length = my_array.Length;

//get 2Sum

//int[] get2Sum(int[] arrayOfNum,int targetValue)
//{
//    var lnth=arrayOfNum.Length;
//    int[] result = [];

//    for (int firstIndex = 0; firstIndex<lnth;firstIndex++)
//    {
//        var firstNumber=arrayOfNum[firstIndex];

//        for (int secondIndex = firstIndex+1; secondIndex < lnth; secondIndex++)
//        {
//            var secondNumber=arrayOfNum[secondIndex];

//            if(firstNumber+secondNumber==targetValue)
//            {
//                result = [firstNumber, secondNumber];
//            }
//        }
//    }
//    return result;
//}

//int[] get2SumV2(int[] arrayOfNum, int targetValue)
//{
//    var lnth = arrayOfNum.Length;
//    int[] result = [];
//    int[] keep = [];

//    for (int firstIndex = 0; firstIndex < lnth; firstIndex++)
//    {
//        var firstNumber = arrayOfNum[firstIndex];
//        var secondnumber=targetValue-firstNumber;
//        if (keep.Contains(secondnumber)){
//            result = [firstNumber, secondnumber];
//            break;
//        }
//        else
//        {
//            keep.Append(firstNumber);
//        }
//    }
//    return result;
//}

//var result = get2Sum([1, 2, 3, 4, 5], 5);
//System.Console.WriteLine(String.Join(",",result));


/*************Deligates************/
//System.Console.WriteLine("Add: "+ MainDelegate.addition(2, 3)+". Minus:"+MainDelegate.deduction(5,2));

/*************TimeZone************/
//TimeZoneSettings.getNigeriaTime();


/********************Problems*************************/
//SearchingChallange.Execute();
//ValidParentheses.Execute();

/********************LeetCode Problems***************/

//MergeSortedArray.ExecuteV1();
//MergeStringsAlternately.Execute();
//GreatestCommonDivisorOfStrings.Execute();
//KidsWithTheGreatestNumberOfCandies.Execute();
//CanPlaceFlowers.Execute();
//ReverseVowelsOfAString.Execute();
//ReverseWordsInString.Execute();
ProductOfArrayExceptSelf.Execute();


/********************Hacker Rank*********************/

//Triplet.Execute();
//BigSum.Execute();
//DiagonalDifference.ExecuteSum();
//PlusMinus.Execute();
//Staircase.staircase(6);
//MinMaxSum.Execute();




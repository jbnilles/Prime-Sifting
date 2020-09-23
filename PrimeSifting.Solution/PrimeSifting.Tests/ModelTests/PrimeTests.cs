using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeSifting.Models;

namespace PrimeSifting.Tests
{
  [TestClass]
  public class PrimeTests
  {
    Prime prime = new Prime();
    [TestMethod]
    public void CreateList_CreatesAListOfNumbersToN_List()
    {
      List<int> newList = new List<int>{2,3,4,5};
      List<int> result = prime.CreateList(5);

      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void MakePrimeList_RemoveMultiplesOfTwo_List()
    {
      List<int> newList = new List<int>{2,3,5};
      List<int> result = prime.MakePrimeList(new List<int> {2,3,4,5});
            
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void MakePrimeList_RemoveMultiplesOfPrime_List()
    {
      List<int> newList = new List<int>{2,3,5,7,11,13,17,19};
      List<int> result = new List<int> {2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};//prime.MakePrimeList(new List<int> {2,3,4,5,6,7,8,9,10,11,12}, prime);
      //int j = result.Count;
      
     // for(int i = 2; i < j; i++ )
      //{
        result = prime.MakePrimeList(result);
      //}

      foreach (int item in result)
      {
          Console.WriteLine(item);
      }
      
            
      CollectionAssert.AreEqual(newList, result);
    }

  }
}



// function findPrimes(x) {
//   let prime = 2;
//   let numList = [];
//   for(let i = 2; i <= x; i++) {
//     numList.push(i);
//   }
//   for(prime = 2; prime <= numList.length; prime++) {
//     for(let j = 1; j < numList.length; j++) {
//       if(numList[j] % prime === 0 && numList[j] !== prime) {
//          numList.splice(j,1);
//       }
//     }
//   }
//  return numList;
// }

// function recLoop(array, prime, input) {
//   if (isNaN(input) || input < 0) {
//     alert("Please enter a positive number and try again.");
//   } else if (array === 0) {
//     array = [];
//     for (let i = 1; i <= input; i++) {
//       array.push(i);
//     }
//     recLoop(array, prime, input);
//   } else if (prime <= input) {
//     let newArray = [];
//     array.forEach(function(num){
//       if (num % prime !== 0 || num === prime) {
//         newArray.push(num);
//       }
//     });
//     prime++;
//     recLoop(newArray, prime, input);
//   } else {
//     $("#result3").text(array);
//   } 
// }
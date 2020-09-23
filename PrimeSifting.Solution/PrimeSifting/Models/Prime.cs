using System;
using System.Collections.Generic;
using PrimeSifting;

namespace PrimeSifting.Models
{
    public class Prime
    {
        private static List<int> CreateList(int num)
        {
          List<int> result = new List<int>{};
          for (int i = 2; i <= num; i++)
          {
              result.Add(i);
          }
            return result;
        }
        private static List<int> MakePrimeList(List<int> list)
        {          
          int j = list.Count;
          
          int multiple;
          for(int a = 0; a < list.Count; a++ ) //2357
          {
            multiple = list[a];
            for (int index = 1; index < list.Count; index++)
            {
              if (list[index] % multiple == 0 && list[index] != multiple)
              {                          
                list.Remove(list[index]);   
                index--;
              }
            }
          }
          return list;
        }
        public static List<int> FindPrimes (int high)
        {
          List<int> starterList = CreateList(high);
          List<int> result =  MakePrimeList(starterList);
          return result;
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
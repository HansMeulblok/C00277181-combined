using NUnit.Framework;
using UnityEngine;

 
 public class CombinedFilterTests
    {
        [Test]
        public void CombinedFilterTestsSimple()
        {
            int[] input = { 4,6,9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 13,709, 362901 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
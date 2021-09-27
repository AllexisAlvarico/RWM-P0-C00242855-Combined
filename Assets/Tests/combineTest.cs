using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;

namespace Tests
{
    public class combineTest
    {
        [Test]
        public void combineTestSimple()
        {
            int[] input = {4, 2, 8, 3, 9, 4, 10, 5, 11, 6, 1 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = {0,6,11,5,10,4,9,2,8,1,4};
            CollectionAssert.AreEqual(expected, output);
        }
    }
}

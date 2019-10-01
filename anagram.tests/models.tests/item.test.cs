using System;
using System.Collections.Generic;
using anagram.models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Anagram.TestTools
{
    [TestClass]

    public class ItemTest : IDisposable 
    {
        public void Dispose () 
        {
            Item.ClearAll ();
        }

        [TestMethod]
        public void ItemConstructor_CreatesInstanceOfItem_Item () 
        {
            Item newItem = new Item("");
            Assert.AreEqual (typeof (Item), newItem.GetType ());
        }

        // [TestMethod]
        // public void CharArray_ReturnArray_Array()
        // {
        //     Item newItem = new Item ("drab");
        //     newItem.StringToArray();
        //     char[] correctArray = {'d', 'r', 'a', 'b'};           
        //     CollectionAssert.AreEqual(newItem.WordArray, correctArray);

        // }
        [TestMethod]
        public void SortArray_SortsArrayAlphabetically_Array()
        {
            Item newItem = new Item("beard");
            char[] sortedArray = newItem.SortArray();
            char[] correctArray = {'a', 'b', 'd', 'e', 'r'};
            CollectionAssert.AreEqual(sortedArray, correctArray);

        }
        [TestMethod]
        public void CompareArray_ComparesSortedArrays_True()
        {
            Item newItem = new Item("bread");

            newItem.gatherInput("beard");
 
            Console.WriteLine("test" + newItem.Word + " " + Item.wordsCompare[0]);
            bool result = newItem.CompareArrays();     
                
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Input_GatherInput_List()
        {
            Item newItem = new Item ("");            
            var test = newItem.gatherInput("beard");
            test = newItem.gatherInput("mustache");
            List<string> testList = new List<string>{"beard", "mustache"};
            CollectionAssert.AreEqual(testList, test);
        }

    }

}
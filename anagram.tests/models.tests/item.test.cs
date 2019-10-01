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
            List<string> correctList = new List<string> {"beard", "bread", "derab"};
            
            newItem.gatherInput("beard");
            newItem.gatherInput("bread");
            newItem.gatherInput("super");
            newItem.gatherInput("derab");

            var result = newItem.CompareArrays();     
                
            CollectionAssert.AreEqual(result, correctList);
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

        [TestMethod]
        public void Partial_CheckPartial_String()
        {
            Item newItem = new Item("bread");

            List<string> correctList = new List<string> {"ear", "drap", "bar"};
            
            newItem.gatherInput("ear");
            newItem.gatherInput("drap");
            newItem.gatherInput("super");
            newItem.gatherInput("bar");


            var result = newItem.CheckPartial();

            CollectionAssert.AreEqual(result, correctList);

        }

    }

}
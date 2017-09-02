using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuizQuestion;
using System.Collections.Generic;

namespace QuizQuestion.Test
{
    [TestClass]
    public class QuizQuestionTest
    {
        [TestMethod]
        public void Test_only_positive()
        {
            Assert.AreEqual(6, QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3 }, 2));
            Assert.AreEqual(35, QuizQuestion.BiggestProduct(new List<int>() { 5, 2, 7 }, 2));
            Assert.AreEqual(6, QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3 }, 3));
            Assert.AreEqual(60, QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3, 4, 5 }, 3));
            Assert.AreEqual(27, QuizQuestion.BiggestProduct(new List<int>() { 1, 9, 3 }, 2));
            Assert.AreEqual(9, QuizQuestion.BiggestProduct(new List<int>() { 1, 9, 3 }, 1));
        }

        [TestMethod]
        public void Test_only_negative()
        {
            Assert.AreEqual(6, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3 }, 2));
            Assert.AreEqual(35, QuizQuestion.BiggestProduct(new List<int>() { -5, -2, -7 }, 2));
            Assert.AreEqual(-6, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3 }, 3));
            Assert.AreEqual(-6, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3, -4, -5 }, 3));
            Assert.AreEqual(27, QuizQuestion.BiggestProduct(new List<int>() { -1, -9, -3 }, 2));
            Assert.AreEqual(-1, QuizQuestion.BiggestProduct(new List<int>() { -1, -9, -3 }, 1));
        }

        [TestMethod]
        public void Test_all_integers()
        {
            Assert.AreEqual(6, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3, 0, 1, 2 }, 2));
            Assert.AreEqual(12, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3, 0, 1, 2 }, 4));
            Assert.AreEqual(35, QuizQuestion.BiggestProduct(new List<int>() { -5, 0, -7 }, 2));
            Assert.AreEqual(0, QuizQuestion.BiggestProduct(new List<int>() { 1, 0, -3 }, 0));
            Assert.AreEqual(-6, QuizQuestion.BiggestProduct(new List<int>() { -1, -2, -3, -4, -5 }, 3));
            Assert.AreEqual(27, QuizQuestion.BiggestProduct(new List<int>() { -1, -9, -3 }, 2));
            Assert.AreEqual(-1, QuizQuestion.BiggestProduct(new List<int>() { -1, -9, -3 }, 1));
        }

        [TestMethod]
        public void Test_zero_k()
        {
            Assert.AreEqual(0, QuizQuestion.BiggestProduct( new List<int>() { 1, 2, 3 }, 0));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_negative_k()
        {
            QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3 }, -1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Test_k_bigger_than_list_count()
        {
            QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3 }, 4);
        }

        [TestMethod]
        public void Test_k_equal_to_list_count()
        {
            QuizQuestion.BiggestProduct(new List<int>() { 1, 2, 3 }, 3);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Test_null_list()
        {
            QuizQuestion.BiggestProduct(null, 4);
        }
    }
}

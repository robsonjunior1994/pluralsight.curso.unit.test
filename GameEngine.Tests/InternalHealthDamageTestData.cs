﻿using System.Net.NetworkInformation;

namespace GameEngine.Tests
{
    public class InternalHealthDamageTestData
    {
        //private static readonly List<Object[]> Data = new List<object[]>
        //{
        //    new object[] { 0, 100 },
        //    new object[] { 1, 99 },
        //    new object[] { 50, 50 },
        //    new object[] { 101, 1 },
        //};

        ////vamos expor a lista para que possa ser chamada
        //public static IEnumerable<object> TestData = Data;

        public static IEnumerable<Object[]> TestData 
        {
            get 
            {
                yield return new object[] { 0, 100 };
                yield return new object[] { 1, 99 };
                yield return new object[] { 50, 50 };
                yield return new object[] { 101, 1 };
            }
        }
    }
}

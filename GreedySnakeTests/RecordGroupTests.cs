using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GreedySnake;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Microsoft.QualityTools.Testing.Fakes;


namespace GreedySnakeTests
{
    /// <summary>
    /// Unit Test for each function in RecordGroup.cs
    /// </summary>
    [TestClass]
    public class RecordGroupTests
    {
        RecordGroup group = new YellowStoneMapRecords();

        [TestMethod]
        public void SerializeGameRecordTest()
        {
            using (ShimsContext.Create())
            {
                System.Fakes.ShimDateTime.NowGet = () => { return new DateTime(2015, 6, 9, 22, 19, 0); };

                string expectedResult = "Xu Yan|20|6/9/2015 10:19:00 PM";
                GameRecord g = new GameRecord("Xu Yan", 20, DateTime.Now);

                Assert.AreEqual<string>(expectedResult, group.SerializeGameRecord(g));
            }
        }

        // Need to set the modifier of RecordGroup.DeserializeGameRecord to public to run the test
        //[TestMethod]
        //public void DeserializeGameRecord()
        //{
        //    Assert.AreEqual<GameRecord>(g, group.DeserializeGameRecord(expectedResult));
        //}

        [TestMethod]
        public void IsBetterRecord_EmptyRecord()
        {
            GameRecord longer = new GameRecord("Xu Yan", 21, new DateTime(2015, 6, 9, 22, 19, 0));
            Assert.IsTrue(group.IsBetterRecord(longer));
        }

        [TestMethod]
        public void IsBetterRecord_LongerSnake()
        {
            GameRecord r1 = new GameRecord("Xu Yan", 22, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r2 = new GameRecord("Xu Yan", 19, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r3 = new GameRecord("Xu Yan", 21, new DateTime(2015, 6, 9, 22, 19, 0));

            group.AddRecord(r1);
            group.AddRecord(r2);
            group.AddRecord(r3);

            GameRecord r4 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 19, 0));

            Assert.IsTrue(group.IsBetterRecord(r4));
        }

        [TestMethod]
        public void IsBetterRecord_LaterTime()
        {
            GameRecord r1 = new GameRecord("Xu Yan", 22, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r2 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r3 = new GameRecord("Xu Yan", 21, new DateTime(2015, 6, 9, 22, 19, 0));

            group.AddRecord(r1);
            group.AddRecord(r2);
            group.AddRecord(r3);

            GameRecord r4 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 23, 1, 0));

            Assert.IsFalse(group.IsBetterRecord(r4));
        }

        [TestMethod]
        public void AddRecord_AddMultipleRecords()
        {
            GameRecord r1 = new GameRecord("Xu Yan", 22, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r2 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r3 = new GameRecord("Xu Yan", 21, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r4 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 23, 1, 0));

            group.AddRecord(r1);
            group.AddRecord(r2);
            group.AddRecord(r3);
            group.AddRecord(r4);

            Assert.AreEqual<int>(group.records.Count, 3);
        }

        [TestMethod]
        public void AddRecord_ReplaceFirst()
        {
            GameRecord r1 = new GameRecord("Xu Yan", 22, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r2 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r3 = new GameRecord("Xu Yan", 21, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r4 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 23, 1, 0));

            group.AddRecord(r1);
            group.AddRecord(r2);
            group.AddRecord(r3);
            group.AddRecord(r4);

            SortedSet<GameRecord> expected = new SortedSet<GameRecord>();
            expected.Add(r4);
            expected.Add(r3);
            expected.Add(r1);

            CollectionAssert.AreEqual(group.records, expected);
        }

        [TestMethod]
        public void AddRecord_RecordAlwaysSorted()
        {
            GameRecord r1 = new GameRecord("Xu Yan", 22, new DateTime(2015, 6, 10, 22, 19, 0));
            GameRecord r2 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 19, 0));
            GameRecord r3 = new GameRecord("Xu Yan", 20, new DateTime(2015, 6, 9, 22, 20, 0));

            group.AddRecord(r1);
            group.AddRecord(r2);
            group.AddRecord(r3);

            Assert.AreEqual(group.records.First(), r3);
            group.records.Remove(group.records.First());

            Assert.AreEqual(group.records.First(), r2);
            group.records.Remove(group.records.First());

            Assert.AreEqual(group.records.First(), r1);
        }


    }
}

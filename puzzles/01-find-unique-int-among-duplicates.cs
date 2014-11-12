using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Algorithms.puzzles
{
    /// <summary>
    /// https://www.interviewcake.com/question/find-unique-int-among-duplicates
    /// Your company delivers breakfast via autonomous quadcopter drones. And something mysterious has happened.
    /// Each breakfast delivery is assigned a unique ID, a positive integer. 
    /// When one of the company's 100 drones takes off with a delivery, the delivery's ID is added to an array, delivery_id_confirmations. 
    /// When the drone comes back and lands, the ID is again added to the same array.
    /// After breakfast this morning there were only 99 drones on the tarmac. One of the drones never made it back from a delivery. 
    /// We suspect a secret agent from Amazon placed an order and stole one of our patented drones. 
    /// To track them down, we need to find their delivery ID.
    /// Given the array of IDs, which contains many duplicate integers and one unique integer, find the unique integer.
    /// The IDs are not guaranteed to be sorted or sequential. Orders aren't always fulfilled in the order they were received, and some deliveries get cancelled before takeoff.
    /// </summary>
    public class FindUniqueIntAmongDuplicates
    {
        public int FindUniqueInt(List<int> droneIds)
        {
            var dronesSeen = new Dictionary<int, int>();

            foreach (var droneId in droneIds)
            {
                if (dronesSeen.ContainsKey(droneId))
                {
                    dronesSeen.Remove(droneId);
                }
                else
                {
                    dronesSeen.Add(droneId, 1);
                }
            }

            if (dronesSeen.Count == 1)
                return dronesSeen.First().Key;

            throw new Exception("There is not a single unique drone.");
        }
    }

    [TestFixture]
    public class Tester
    {
        [Test]
        public void GenerateTestDataAndFindAnswer()
        {
            const int listSize = 100;
            var outGoingDrones = Enumerable.Range(0, listSize).ToList();
            var rand = new Random();
            int toRemove = rand.Next(0, listSize);
            var inComingDrones = Enumerable.Range(0, listSize).ToList();
            inComingDrones.RemoveAt(toRemove);
            outGoingDrones.AddRange(inComingDrones);

            var findUniqueIntAmongDuplicates = new FindUniqueIntAmongDuplicates();
            int answer = findUniqueIntAmongDuplicates.FindUniqueInt(outGoingDrones);
            Assert.AreEqual(toRemove, answer);
        }
    }
}

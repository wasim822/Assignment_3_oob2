// SerializationTests.cs
using Assignment_3_skeleton;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace Test_Assignment_3_1
{
    public class SerializationTests
    {
        private List<User> users;
        private readonly string testFileName = "test_users.bin";

        [SetUp]
        public void Setup()
        {
            users = new List<User>
            {
                new(1, "Joe Blow", "jblow@gmail.com", "password"),
                new (2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"),
                new (3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"),
                new (4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999")
            };
        }

        [TearDown]
        public void TearDown()
        {
            users.Clear();
            if (File.Exists(testFileName))
            {
                File.Delete(testFileName);
            }
        }

        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            Assert.IsTrue(File.Exists(testFileName));
        }

        [Test]
        public void TestDeSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            List<User> deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            Assert.AreEqual(users.Count, deserializedUsers.Count);
            for (int i = 0; i < users.Count; i++)
            {
                Assert.AreEqual(users[i].Id, deserializedUsers[i].Id);
                Assert.AreEqual(users[i].Name, deserializedUsers[i].Name);
                Assert.AreEqual(users[i].Email, deserializedUsers[i].Email);
                Assert.AreEqual(users[i].Password, deserializedUsers[i].Password);
            }
        }
    }
}

// LinkedListTests.cs - COMPLETE VERSION
using Assignment_3_skeleton;
using NUnit.Framework;
using System.Collections.Generic;

namespace Test_Assignment_3_1
{
    [TestFixture]
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        [Test]
        public void TestIsEmpty()
        {
            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.True);
                Assert.That(this.linkedList.Size(), Is.EqualTo(0));
            });
        }

        [Test]
        public void TestAppendNode()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);
            this.linkedList.Append(userD);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.False);
                Assert.That(this.linkedList.Size(), Is.EqualTo(4));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userA));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userC));
                Assert.That(this.linkedList.Retrieve(3), Is.EqualTo(userD));
            });
        }

        [Test]
        public void TestPrependNodes()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");

            this.linkedList.Prepend(userA);
            this.linkedList.Prepend(userB);
            this.linkedList.Prepend(userC);
            this.linkedList.Prepend(userD);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.False);
                Assert.That(this.linkedList.Size(), Is.EqualTo(4));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userD));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userC));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(3), Is.EqualTo(userA));
            });
        }

        [Test]
        public void TestInsertNode()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");
            var userE = new User(5, "Eve", "eve@example.com", "pass000");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);
            this.linkedList.Append(userD);

            this.linkedList.Insert(userE, 2);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.False);
                Assert.That(this.linkedList.Size(), Is.EqualTo(5));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userA));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userE));
                Assert.That(this.linkedList.Retrieve(3), Is.EqualTo(userC));
                Assert.That(this.linkedList.Retrieve(4), Is.EqualTo(userD));
            });
        }

        [Test]
        public void TestReplaceNode()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");
            var userE = new User(5, "Eve", "eve@example.com", "newpass");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);
            this.linkedList.Append(userD);

            this.linkedList.Replace(userE, 2);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.False);
                Assert.That(this.linkedList.Size(), Is.EqualTo(4));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userA));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userE));
                Assert.That(this.linkedList.Retrieve(3), Is.EqualTo(userD));
            });
        }

        [Test]
        public void TestDeleteNode()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);
            this.linkedList.Append(userD);

            this.linkedList.Delete(2);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.IsEmpty(), Is.False);
                Assert.That(this.linkedList.Size(), Is.EqualTo(3));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userA));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userD));
            });
        }

        [Test]
        public void TestFindNode()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");
            var userD = new User(4, "Diana", "diana@example.com", "pass999");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);
            this.linkedList.Append(userD);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.Contains(userB), Is.True);
                Assert.That(this.linkedList.IndexOf(userB), Is.EqualTo(1));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
            });
        }

        [Test]
        public void TestDeleteFromBeginning()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);

            this.linkedList.Delete(0);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.Size(), Is.EqualTo(2));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userC));
            });
        }

        [Test]
        public void TestDeleteFromEnd()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");

            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);

            this.linkedList.Delete(2);

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.Size(), Is.EqualTo(2));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userA));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
            });
        }

        [Test]
        public void TestAdditionalFunctionality()
        {
            var userA = new User(1, "Alice", "alice@example.com", "pass123");
            var userB = new User(2, "Bob", "bob@example.com", "pass456");
            var userC = new User(3, "Charlie", "charlie@example.com", "pass789");

            // Test ToArray functionality
            this.linkedList.Append(userA);
            this.linkedList.Append(userB);
            this.linkedList.Append(userC);

            // Cast to SLL to access additional methods
            var sll = (SLL)this.linkedList;
            User[] array = sll.ToArray();

            Assert.Multiple(() =>
            {
                Assert.That(array.Length, Is.EqualTo(3));
                Assert.That(array[0], Is.EqualTo(userA));
                Assert.That(array[1], Is.EqualTo(userB));
                Assert.That(array[2], Is.EqualTo(userC));
            });

            // Test Reverse functionality
            sll.Reverse();

            Assert.Multiple(() =>
            {
                Assert.That(this.linkedList.Size(), Is.EqualTo(3));
                Assert.That(this.linkedList.Retrieve(0), Is.EqualTo(userC));
                Assert.That(this.linkedList.Retrieve(1), Is.EqualTo(userB));
                Assert.That(this.linkedList.Retrieve(2), Is.EqualTo(userA));
            });
        }
    }
}
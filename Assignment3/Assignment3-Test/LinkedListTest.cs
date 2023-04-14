using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Assignment_3
{
    public class LinkedListTests
    {
        private LinkedListADT linkedList;

        [SetUp]
        public void Setup()
        {
            // Create your concrete linked list class and assign to to linkedList.
            this.linkedList = new SLL();
        }

        [TearDown]
        public void TearDown()
        {
            this.linkedList.Clear();
        }

        //Test the linked list is empty.
        [Test]
        public void TestIsEmpty()
        {
            Assert.True(this.linkedList.IsEmpty());
            Assert.AreEqual(0, this.linkedList.Size());
        }

        //Tests appending elements to the linked list.
        [Test]
        public void TestAppendNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests prepending nodes to linked list.
        [Test]
        public void testPrependNodes()
        {
            this.linkedList.Prepend("a");
            this.linkedList.Prepend("b");
            this.linkedList.Prepend("c");
            this.linkedList.Prepend("d");

            /**
             * Linked list should now be:
             * 
             * d -> c -> b -> a
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("d", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("c", this.linkedList.Retrieve(1));

            // Test the third node value is c
            Assert.AreEqual("b", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("a", this.linkedList.Retrieve(3));
        }

        //Tests inserting node at valid index.
        [Test]
        public void TestInsertNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Insert("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> c -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(5, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the third node value is c
            Assert.AreEqual("c", this.linkedList.Retrieve(3));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(4));
        }

        //Tests replacing existing nodes data.
        [Test]
        public void TestReplaceNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Replace("e", 2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> e -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(4, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the third node value is e
            Assert.AreEqual("e", this.linkedList.Retrieve(2));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(3));
        }

        //Tests deleting node from linked list.
        [Test]
        public void TestDeleteNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            this.linkedList.Delete(2);

            /**
             * Linked list should now be:
             * 
             * a -> b -> d
             */

            // Test the linked list is not empty.
            Assert.False(this.linkedList.IsEmpty());

            // Test the size is 4
            Assert.AreEqual(3, this.linkedList.Size());

            // Test the first node value is a
            Assert.AreEqual("a", this.linkedList.Retrieve(0));

            // Test the second node value is b
            Assert.AreEqual("b", this.linkedList.Retrieve(1));

            // Test the fourth node value is d
            Assert.AreEqual("d", this.linkedList.Retrieve(2));
        }

        //Tests finding and retrieving node in linked list.
        [Test]
        public void TestFindNode()
        {
            this.linkedList.Append("a");
            this.linkedList.Append("b");
            this.linkedList.Append("c");
            this.linkedList.Append("d");

            /**
             * Linked list should now be:
             * 
             * a -> b -> c -> d
             */

            bool contains = this.linkedList.Contains("b");
            Assert.True(contains);

            int index = this.linkedList.IndexOf("b");
            Assert.AreEqual(1, index);

            string value = (string)this.linkedList.Retrieve(1);
            Assert.AreEqual("b", value);
        }
		// ADDED TEST - Fill the linked list, then clear it.
		[Test]
		public void TestFillNEmpty()
		{
			linkedList.Append("a");
			linkedList.Append("b");
			linkedList.Append("c");
			linkedList.Append("d");

			Assert.AreEqual("a", linkedList.Retrieve(0));
			Assert.AreEqual("b", linkedList.Retrieve(1));
			Assert.AreEqual("c", linkedList.Retrieve(2));
			Assert.AreEqual("d", linkedList.Retrieve(3));

			linkedList.Clear();

			// List should be null
			Assert.True(linkedList.IsEmpty());

		}

		// ADDED TEST - Fill the linked list and get the size of it. Then, delete a node and verify the size again.
		[Test]
		public void TestGetSize()
		{
			linkedList.Append("a");
			linkedList.Append("b");
			linkedList.Append("c");
			linkedList.Append("d");

			Assert.AreEqual(4, linkedList.Size());

			linkedList.Delete(1);
			Assert.AreEqual(3, linkedList.Size());

		}

		// ADDED TEST - Append four characters to the linked list, then replace them with Nico!
		[Test]
		public void TestNICOReplace()
		{
			linkedList.Append("a");
			linkedList.Append("b");
			linkedList.Append("c");
			linkedList.Append("d");

			

			linkedList.Replace("N", 0);
			linkedList.Replace("I", 1);
			linkedList.Replace("C", 2);
			linkedList.Replace("O", 3);

			

			Assert.AreEqual("N", linkedList.Retrieve(0));
			Assert.AreEqual("I", linkedList.Retrieve(1));
			Assert.AreEqual("C", linkedList.Retrieve(2));
			Assert.AreEqual("O", linkedList.Retrieve(3));
		}


		[Test]
		public void TestIndexOf()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");

			int index = this.linkedList.IndexOf("b");

			// Test that the index of "b" is 1
			Assert.AreEqual(1, index);
		}
		[Test]
		public void TestClear()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");

			this.linkedList.Clear();

			// Test that the linked list is empty
			Assert.True(this.linkedList.IsEmpty());

			// Test that the size is 0
			Assert.AreEqual(0, this.linkedList.Size());
		}

		[Test]
		public void TestInvalidIndex()
		{
			this.linkedList.Append("a");
			this.linkedList.Append("b");
			this.linkedList.Append("c");

			// Test that an exception is thrown when retrieving from an invalid index
			Assert.Throws<IndexOutOfRangeException>(() => this.linkedList.Retrieve(3));

			// Test that an exception is thrown when inserting at an invalid index
			Assert.Throws<IndexOutOfRangeException>(() => this.linkedList.Insert("d", 4));

			// Test that an exception is thrown when replacing at an invalid index
			Assert.Throws<IndexOutOfRangeException>(() => this.linkedList.Replace("d", 4));

			// Test that an exception is thrown when deleting from an invalid index
			Assert.Throws<IndexOutOfRangeException>(() => this.linkedList.Delete(4));
		}
        
	}
}
    


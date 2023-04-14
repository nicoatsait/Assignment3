using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment_3_skeleton
{
	public class SLL : LinkedListADT
	{
		private Node head;

		// constructor for the SLL class
		public SLL()
		{
			head = null;
		}
		// Method to check if list is empty
		public bool IsEmpty()
		{
			return head == null;
		}
		//Method to clear list
		public void Clear()
		{
			head = null;
		}
		//Method to append a new node with the given data to the end of the linked list
		public void Append(Object data)
		{
			// Create a new node with the given data
			Node newNode = new Node(data);

			// If the linked list is empty, set the head of the list to the new node
			if (IsEmpty())
			{
				head = newNode;
			}

			// Otherwise, traverse the linked list until the end is reached, and append the new node
			else
			{
				Node currentNode = head;

				while (currentNode.Next != null)
				{
					currentNode = currentNode.Next;
				}

				currentNode.Next = newNode;
			}
		}

		// Method to prepend a new node with the given data to the beginning of the linked list
		public void Prepend(Object data)
		{
			Node newNode = new Node(data);

			newNode.Next = head;
			head = newNode;
		}

		// Define a method to insert a new node with the given data at the specified index in the linked list
		public void Insert(Object data, int index)
		{
			if (index < 0 || index > Size())
			{
				throw new IndexOutOfRangeException();
			}

			Node newNode = new Node(data);

			if (index == 0)
			{
				Prepend(data);
			}
			else
			{
				Node currentNode = head;
				int currentIndex = 0;

				while (currentIndex < index - 1)
				{
					currentNode = currentNode.Next;
					currentIndex++;
				}

				newNode.Next = currentNode.Next;
				currentNode.Next = newNode;
			}
		}

		// Define a method to replace the node at the specified index with a new node containing the given data
		public void Replace(Object data, int index)
		{
			if (index < 0 || index >= Size())
			{
				throw new IndexOutOfRangeException();
			}

			Node currentNode = head;
			int currentIndex = 0;

			while (currentIndex < index)
			{
				currentNode = currentNode.Next;
				currentIndex++;
			}

			currentNode.Data = data;
		}

		public int Size()
		{
			int count = 0;
			Node currentNode = head;

			while (currentNode != null)
			{
				count++;
				currentNode = currentNode.Next;
			}

			return count;
		}

		public void Delete(int index)
		{
			if (index < 0 || index >= Size())
			{
				throw new IndexOutOfRangeException();
			}

			if (index == 0)
			{
				head = head.Next;
			}
			else
			{
				Node currentNode = head;
				int currentIndex = 0;

				while (currentIndex < index - 1)
				{
					currentNode = currentNode.Next;
					currentIndex++;
				}

				currentNode.Next = currentNode.Next.Next;
			}
		}

		public Object Retrieve(int index)
		{
			if (index < 0 || index >= Size())
			{
				throw new IndexOutOfRangeException();
			}

			Node currentNode = head;
			int currentIndex = 0;

			while (currentIndex < index)
			{
				currentNode = currentNode.Next;
				currentIndex++;
			}

			return currentNode.Data;
		}

		public int IndexOf(Object data)
		{
			Node currentNode = head;
			int currentIndex = 0;

			while (currentNode != null)
			{
				if (currentNode.Data.Equals(data))
				{
					return currentIndex;
				}

				currentNode = currentNode.Next;
				currentIndex++;
			}

			return -1;
		}

		public bool Contains(Object data)
		{
			return IndexOf(data) != -1;
		}

		private class Node
		{
			public Object Data { get; set; }
			public Node Next { get; set; }

			public Node(Object data)
			{
				Data = data;
				Next = null;
			}
		}


	}
}
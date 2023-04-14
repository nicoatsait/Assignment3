using System;

namespace Assignment_3_skeleton
{
	public class Node
	{
		private const string Message = "Index is out of range";
		private string _data;
		private Node _next;

		public string Data { get { return _data; } set { _data = value; } }
		public Node Next { get { return _next; } set { _next = value; } }

		public Node(Node n, string data)
		{
			this._next = n;
			this._data = data;
		}

		public Node(object data)
		{
			this._data = (string)data;
		}

	}
}
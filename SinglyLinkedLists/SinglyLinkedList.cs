﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        private SinglyLinkedListNode firstNode;

        public SinglyLinkedList()
        {
            firstNode = null;
            // NOTE: This constructor isn't necessary, once you've implemented the constructor below.
        }

        // READ: http://msdn.microsoft.com/en-us/library/aa691335(v=vs.71).aspx
        public SinglyLinkedList(params object[] values)
        {
            throw new NotImplementedException();
        }

        // READ: http://msdn.microsoft.com/en-us/library/6x16t2tx.aspx
        public string this[int i]
        {
            get { 
                throw new NotImplementedException(); 
            }
            set { throw new NotImplementedException(); }
        }

        public bool EmptyList()
        {
            return (firstNode == null);
        }

        public void AddAfter(string existingValue, string value)
        {
            throw new NotImplementedException();
        }

        public void AddFirst(string value)
        {
            throw new NotImplementedException();
/*
            if (firstNode == null)
            {
                AddLast(value);
            }
            else
            {
                SinglyLinkedListNode oldFirstNode = firstNode;
                SinglyLinkedListNode newFirstNode = new SinglyLinkedListNode(value);

                newFirstNode.Next = oldFirstNode;
            }
*/
        }

        public void AddLast(string value)
        {
            if (firstNode == null)
            {
                firstNode = new SinglyLinkedListNode(value);
            }
            else
            {
                SinglyLinkedListNode currentNode = firstNode;
                SinglyLinkedListNode cacheNode = null;

                while (currentNode.Next != null)
                {
                    cacheNode = currentNode;
                    currentNode = currentNode.Next;
                }

                SinglyLinkedListNode newNode = new SinglyLinkedListNode(value);
                newNode.Next = null;
                currentNode.Next = newNode;
            }
        }

        public string First()
        {
            if (firstNode == null)
            {
                return null;
            }
            else
            {
                return firstNode.Value;
            }
        }

        // NOTE: There is more than one way to accomplish this.  One is O(n).  The other is O(1).
        public int Count()
        {
            throw new NotImplementedException();
        }

        public string ElementAt(int index)
        {
            SinglyLinkedListNode currentNode = firstNode;
            SinglyLinkedListNode cacheNode = null;

            if (currentNode == null)
                throw new ArgumentOutOfRangeException("empty list");

            for (int i = 0; i < index; i++)
            {
                if (currentNode == null)
                    throw new ArgumentOutOfRangeException("index out of range");

                cacheNode = currentNode;
                currentNode = currentNode.Next;
            }

            return currentNode.Value;
        }


        public int IndexOf(string value)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }

        // HINT 1: You can extract this functionality (finding the last item in the list) from a method you've already written!
        // HINT 2: I suggest writing a private helper method LastNode()
        // HINT 3: If you highlight code and right click, you can use the refactor menu to extract a method for you...
        public string Last()
        {
            if (LastNode() != null)
                return LastNode().Value;
            else
                throw new NotImplementedException();
        }

        public void Remove(string value)
        {
            return;
        }

        public void Sort()
        {
            throw new NotImplementedException();
        }

        public string[] ToArray()
        {
            throw new NotImplementedException();
        }

        private SinglyLinkedListNode LastNode()
        {
            SinglyLinkedListNode lastNode = null;

            if (firstNode == null)
            {
                lastNode = null;
            }
            else
            {
                SinglyLinkedListNode currentNode = firstNode;
                SinglyLinkedListNode cacheNode = null;

                while (currentNode.Next != null)
                {
                    cacheNode = currentNode;
                    currentNode = currentNode.Next;
                }
                lastNode = currentNode;
            }
            return lastNode;
        }
    }
}

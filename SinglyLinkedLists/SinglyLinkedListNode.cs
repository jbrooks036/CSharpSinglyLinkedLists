using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Stretch Goals: Using Generics, which would include implementing GetType() http://msdn.microsoft.com/en-us/library/system.object.gettype(v=vs.110).aspx
namespace SinglyLinkedLists
{
    public class SinglyLinkedListNode : IComparable
    {
        // Used by the visualizer.  Do not change.
        public static List<SinglyLinkedListNode> allNodes = new List<SinglyLinkedListNode>();

        // READ: http://msdn.microsoft.com/en-us/library/aa287786(v=vs.71).aspx
        private SinglyLinkedListNode next;
        public SinglyLinkedListNode Next
        {
            get { return this.next; }

            set 
            { 
                if (value == this)
                    throw new ArgumentException("Can't set Next to this");
                this.next = value; 
            }
        }

        private string value; // field
        public string Value  // property
        {
            get { return this.value; }
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(Object obj) 
        {
            SinglyLinkedListNode otherNode = obj as SinglyLinkedListNode;

            if (otherNode == null)
                return false;
            else
                return this.value.Equals(otherNode.value);

        }

        public static bool operator <(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) < 0;
        }

        public static bool operator >(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            // This implementation is provided for your convenience.
            return node1.CompareTo(node2) > 0;
        }

        public SinglyLinkedListNode(string value)
        {
            this.value = value;
            // Used by the visualizer:
            allNodes.Add(this);
        }

        // READ: http://msdn.microsoft.com/en-us/library/system.icomparable.compareto.aspx
        public int CompareTo(Object obj)
        {
            if (obj == null) return 1;

            SinglyLinkedListNode otherNode = obj as SinglyLinkedListNode;
            if (otherNode != null) 
                return this.value.CompareTo(otherNode.value);
            else 
               throw new ArgumentException("Object is not a Node");
        }

        public bool IsLast()
        {
            return (this.next == null);
        }
    }
}

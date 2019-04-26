using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_way_list
{
    class List<Type>
    {
        public Element Head { get; private set; }
        public Element Last { get; private set; }
        private int itemscoutner;
        public List() { Head =Last= null; }
        public class Element
        {
            public Element next, prev;
            public Type data { get; set; }
            public Element(Type data)
            {
                this.next = null;
                this.prev = null;
                this.data = data;
            }
        }
        public void InsertFront(Type data)
        {
            Element newNode = new Element(data);
            newNode.next = Head;
            newNode.prev = null;
            if (Head != null)
            {
                Head.prev = newNode;
            }
            Head = newNode;
        }
        public void InsertAfter(Element actual, Type data)
        {
            if (actual == null)
            {
                Console.WriteLine("Podełeś nieziainicjalizowany element");
                return;
            }
            Element newNode = new Element(data);
            newNode.next = actual.next;
            actual.next = newNode;
            newNode.prev = actual;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }
        public void InsertLast( Type data)
        {
            Element newNode = new Element(data);
            if (Head == null)
            {
                newNode.prev = null;
                Head = newNode;
                return;
            }
            Element lastNode =Last;
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public void DeleteNodebyKey( Type key)
        {
            Element temp = Head;
            if (temp != null && temp.data.Equals(key))
            {
                Head = temp.next;
                Head.prev = null;
                return;
            }
            while (temp != null && !temp.data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }

    }
}

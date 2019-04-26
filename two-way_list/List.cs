using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_way_list
{
    class List<Type>
    {
        Element head=null;
        Element last = null;
        private int itemscoutner;
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
        void InsertFront(Type data)
        {
            Element newNode = new Element(data);
            newNode.next = head;
            newNode.prev = null;
            if (head != null)
            {
                head.prev = newNode;
            }
            head = newNode;
        }

        internal void InsertLast( Type data)
        {
            Element newNode = new Element(data);
            if (head == null)
            {
                newNode.prev = null;
                head = newNode;
                return;
            }
            Element lastNode =last;
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }

    }
}

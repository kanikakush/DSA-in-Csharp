using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LindkedList
{
    public class LinkedListBasic
    {
        class LinkedListNode
        {
            int data;
            LinkedListNode next;
            public LinkedListNode(int i)
            {
                data= i;
                next = null;
            }
        }

        public void InsertDataIntoLinkedList(int Data)
        {
            LinkedListNode node;
            node=new LinkedListNode(Data);
            
            //node.next = null;
        }

    }
}

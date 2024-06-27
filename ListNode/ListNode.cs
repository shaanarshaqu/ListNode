namespace ListNodes
{
    public class ListNode
    {
        int val;
        ListNode next;
        public ListNode(int val, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }


        public static ListNode head = null;
        public static ListNode tail = null;

        public static void AddToListNode(int val)
        {
            var newNode = new ListNode(val);
            if (tail != null)
            {
                tail.next = newNode;
                tail = tail.next;
                return;
            }
            if (head == null)
            {
                head = newNode;
                return;
            }
            ListNode current = head;
            while (current != null) 
            { 
                if (current.next == null)
                {
                    current.next = newNode;
                    return;
                }
                current= current.next;
            }
        }

        public static void ViewList(ListNode current)
        {
/*            ListNode current = head;
*/            Console.Write("[ ");
            while (current != null)
            {
                if(current.next != null)
                {
                    Console.Write($"{current.val},");
                }
                else
                {
                    Console.Write($"{current.val} ");
                }           
                current = current.next;
            }
            Console.Write("]");
        }

        public async static Task<ListNode> RemoveDuplicate(ListNode refhead)
        {
            ListNode current = refhead;
            ListNode prev = refhead;
            while (current != null)
            {
                if (prev.val != current.val)
                {
                    prev.next = current;
                    prev= prev.next;
                }
                current = current.next;
            }
            return refhead;
        }

        public static 

    }
}

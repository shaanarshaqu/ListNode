using ListNodes;

public class Program
{
    public async static Task Main(string[] args)
    {
        ListNode.AddToListNode(1);
        ListNode.AddToListNode(1);
        ListNode.AddToListNode(1);
        ListNode.AddToListNode(1);
        ListNode.AddToListNode(2);
        ListNode.AddToListNode(2);
        ListNode.AddToListNode(2);
        ListNode.AddToListNode(2);
        ListNode.AddToListNode(3);
        ListNode.AddToListNode(5);

        ListNode.ViewList(ListNode.head);
    }
}
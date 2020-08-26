namespace singly_linked_list
{
    public class SinglyLinkedList
    {
        public SllNode Head;
        public SinglyLinkedList() 
        {
            this.Head = null;
            
            // your code here
        }
        // SLL methods go here. As a starter, we will show you how to add a node to the list.
        public void Add(int value) 
        {
            SllNode newNode = new SllNode(value);
            if(Head == null) 
            {
                Head = newNode;
            } 
            else
            {
                SllNode runner = Head;
                while(runner.Next != null) {
                    runner = runner.Next;
                }
                runner.Next = newNode;
            }
        }
        public void remove()
        {
            SllNode runner = Head;

            while(runner.Next != null ){
                runner = runner.Next;
            }
            

        }    
    }

 

}
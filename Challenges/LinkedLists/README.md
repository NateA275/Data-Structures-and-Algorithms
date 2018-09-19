# Linked Lists

## What is a Linked List?

> Linked Lists are a linear data type, and can be used in a similar way as Arrays.
Unlike Arrays, Linked Lists allow for more dynamic uses such as adding, inserting, and deleting.
Also unlike Arrays, random access is not possible with Linked Lists. All elements must be accessed
sequentially, making implementation a case-by-case decision.

## Visual

![linked_list](../../assets/linked_list.PNG)

## Implementation

This project is implemented with multiple classes. One class represents a Linked List object,
another class represents a Node object. Both classes have properties, and the Linked List class
contains several methods for manipulating nodes within the list.

## Usage

Linked lists are best implemented when data-set size is variable and insertion/deletion operation are frequently used.
Linked list are best avoided when sorting and when random access are common required operations.

---

# Kth Element From the End of the Linked List

> This method is an exercise in manipulating linked lists. 
It returns the element that is k elements from the last element.

## Challenge

Write a method for the Linked List class which takes a number, k, as a parameter.
Return the node that is k from the end of the linked list. You have access to the Node class and 
all the properties on the Linked List class as well as the methods created in previous challenges. ​

## Whiteboard

![kth_Element](../../assets/kth_element.jpg)

## Code
```C#
        public Node KthElement(int k)
        {
            Current = Head;
            Node runner = Head;
            int counter = 0;

            while (runner.Next != null)
            {
                counter++;
                runner = runner.Next;
                if (counter > k)
                    Current = Current.Next;
            }
            if (k > counter)
            {
                throw new NullReferenceException();
            }
            return Current;
        }
```
---

# Merge Linked Lists

> This method can merge two seperate linked list into one linked list.
It takes two linked lists as parameters, and returns the head of the resultant linked list.

## Challenge

Write a function called mergeLists which takes two linked lists as arguments.
Zip the two linked lists together into one so that the nodes alternate between the two 
lists and return a reference to the head of the single list. Try and keep additional 
space down to O(1). You have access to the Node class and all the properties on the L
inked List class as well as the methods created in previous challenges.

## Whiteboard

![merge_linked_list](../../assets/merge_linked_list.jpg)

## Code
```C#
        public Node Merge(MyLinkedList list1, MyLinkedList list2)
        {
            list1.Current = list1.Head;
            list2.Current = list2.Head;
            Node runner1 = list1.Head;
            Node runner2 = list2.Head;
            while (runner1.Next != null && runner2.Next != null)
            {
                runner1 = runner1.Next;
                runner2 = runner2.Next;
                list2.Current.Next = list1.Current.Next;
                list1.Current.Next = list2.Current;
                list1.Current = runner1;
                list2.Current = runner2;
            }
            if (list2.Current.Next == null)
                list2.Current.Next = list1.Current.Next;
            list1.Current.Next = list2.Current;
            return list1.Head;
        }
```


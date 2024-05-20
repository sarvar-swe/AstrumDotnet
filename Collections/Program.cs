//Non-generic
using System.Collections;
using System.Collections.Generic;

// ArrayList arrayList = new ArrayList();
// arrayList.Add("Astrum");
// arrayList.Add(100);
// arrayList.Add(true);

// string[] strings = new string[3];
// strings[0] = "Zero";
// strings[1] = "One";
// strings[2] = "Two";

// arrayList.AddRange(strings);

// arrayList.Remove(100);
// arrayList.Remove(true);
// arrayList.RemoveAt(0);



// Console.WriteLine(arrayList.Count);
// Console.WriteLine(arrayList.Capacity);
// for(int i = 0; i < arrayList.Count; i++)
// {
//     Console.WriteLine(arrayList[i]);
//     // arrayList[i] = 100;
// }

// Console.WriteLine(arrayList[0]);
// foreach(var element in arrayList)
// {
    
// }


// List<int> list = new List<int>();

// list.Add(3);
// list.Add(4);
// list.Add(5);
// list.Add(6);
// list.Add(7);

// foreach(int num in list)
// {
//     Console.WriteLine(num);
// }

// for(int i = 0; i < list.Count; i++)
// {
//     Console.WriteLine(list[i]);
// }


// List<string> stringList = new List<string>()
// {
//     "Astrum",
//     "IT",
//     "Academy"
// };

// List<string> list = new()
// {
//     "Astrum",
//     "IT",
//     "Academy"
// };

// List<string> list = ["Astrum", "IT", "Academy"];


// foreach(string str in list)
// {
//     Console.WriteLine(str);
// }


// Stack stack = new Stack();

// stack.Push("Astrum");
// stack.Push(100);
// stack.Push(true);

// Console.WriteLine(stack.Count);
// Console.WriteLine(stack.Pop());
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack.Count);

// Stack<int> stack = new Stack<int>();

// stack.Push(0);
// stack.Push(1);
// stack.Push(2);
// stack.Push(3);
// stack.Push(4);
// stack.Push(5);

// while(stack.Count > 0)
// {
//     Console.WriteLine(stack.Pop());
// }

// foreach(int element in stack)
// {
//     Console.WriteLine(element);
// }

// Console.WriteLine(stack.Pop());


// Queue queue = new Queue();

// queue.Enqueue("Astrum");
// queue.Enqueue(100);
// queue.Enqueue(true);

// Console.WriteLine(queue.Count);
// Console.WriteLine(queue.Dequeue());
// Console.WriteLine(queue.Count);

// while(queue.Count > 0)
// {
//     Console.WriteLine(queue.Dequeue());
// }

// foreach(var element in queue)
// {
//     Console.WriteLine(element);
// }



// Console.WriteLine(queue.Count);


// Queue<string> queue = new Queue<string>();

// queue.Enqueue("Akrom");
// queue.Enqueue("Doston");
// queue.Enqueue("Ahror");
// queue.Enqueue("Otabek");

// Console.WriteLine(queue.Dequeue());
// Console.WriteLine(queue.Dequeue());

SortedList sortedList = new SortedList();

sortedList.Add(2, "IT");
sortedList.Add(1, "Astrum");
sortedList.Add(3, "Academy");

// foreach(var element in sortedList)
// {
//     Console.WriteLine();
// }

// for(int i = 1; i <= sortedList.Count; i++)
// {
//     Console.WriteLine(sortedList[i]);
// }
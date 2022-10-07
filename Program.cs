// See https://aka.ms/new-console-template for more information
using DSA;
using DSA.Stack;

Console.WriteLine("Hello, World!");
#region Stack using array
StackUsingArray obj = new StackUsingArray();
obj.Push(5);
obj.Push(6);
obj.Push(7);
obj.Push(99);
obj.Push(44);
obj.Push(66);
obj.StackElementDisplay();
obj.Pop();
obj.StackElementDisplay();
#endregion



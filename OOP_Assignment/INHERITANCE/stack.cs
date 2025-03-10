using System;
using System.Collections.Generic;

public class Stack
{
    private List<object> _elements;

    public Stack()
    {
        _elements = new List<object>();
    }

    public void Push(object obj)
    {
        if (obj == null)
        {
            throw new InvalidOperationException("Cannot push null onto the stack.");
        }
        _elements.Add(obj);
    }

    public object Pop()
    {
        if (_elements.Count == 0)
        {
            throw new InvalidOperationException("Cannot pop from an empty stack.");
        }
        // Get the last element and remove it from the stack
        var topElement = _elements[_elements.Count - 1];
        _elements.RemoveAt(_elements.Count - 1);
        return topElement;
    }

    public void Clear()
    {
        _elements.Clear();
    }
}

// Example usage
public class Program
{
    public static void Main()
    {
        var stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        
        Console.WriteLine(stack.Pop()); // Output: 3
        Console.WriteLine(stack.Pop()); // Output: 2
        Console.WriteLine(stack.Pop()); // Output: 1
        
    
    }
}
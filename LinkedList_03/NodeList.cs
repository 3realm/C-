using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_03
{
    internal class NodeList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public NodeList() {  }

        public NodeList(int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddElemebt(int.Parse(Console.ReadLine()));
            }  
        }

        public int Length
        {
            get
            {
                int vector = 0;
                Node current = Head;

                while (current != null)
                {
                    current = current.Host;
                    vector++;
                }

                return vector;
            }
        }

        public override string ToString()
        {
            string s = "[ ";
            for (int i = 0; i < Length; i++)
            {
                s += FixLoop(i).Value + " ";
            }
            return s + "]";
        }

        public void AddElement(int value)
        {
            if (Head == null)
            {
                Head = new Node() { Value = value };
            }
            else
            {
                Node current = Head;
                while (current.Host != null)
                {
                    current = current.Host;
                }
                current.Host = new Node() { Value = value };
            }
        }

        public void AddElemebt(int value)
        {
            if (Head == null)
            {
                Head = new Node(value);
            }
            else
            {
                Node current = Head;
                while (current.Host != null)
                {
                    current = current.Host;
                }
                current.Host = new Node(value);
            }
        }

        public void AddElemect(int value) 
        {
            Node current = new Node(value);

            if (Head == null)
            {
                Head = current;
            }
            else
            {
                Tail.Host = current;    
            }

            Tail = current;
        }

        public void AddFirstElement(int value) 
        {
            Node current = new Node(value);

            current.Host = Head;
            Head = current;
            if (Length == 0)
            {
                current = Head; 
            }
        }

        public bool Contains(int value) 
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true; 
                }
                current = current.Host;
            }
            return false;
        }

        public void Loop() 
        {
            Node current = Head;

            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Host;
            }
        }

        public Node FixLoop(int count)
        {
            Node current = Head;

            for (int i = 0; i < count; i++)
            {
                current = current.Host;
            }
            return current;
        }

        public void FindingLoop(int count) 
        {
            Node current = Head;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Value);
                current = current.Host;
            }
        }

        public void MakingLoop(int index) 
        {
            Node current = Head;
            Node runner = Head;

            for (int i = 0; i < index; i++)
            {
                runner = runner.Host;
            }

            while (current.Host != null)
            {
                current = current.Host;
            }
            
            current.Host = runner;
        }

        public void StartLoop() 
        {
            Node slow = Head;
            Node fast = Head;

            while (fast != null)
            {
                slow = slow.Host;
                fast = fast.Host.Host;
                if (slow == fast) {break;}
            }

            if (fast == null || fast.Host == null)
            {
                Console.WriteLine("Петли нет");
            }

            slow = Head;
            while (slow != fast)
            {
                slow = slow.Host;
                fast = fast.Host;
            }

            Console.WriteLine(fast.Value);
        }

        public void RemoveElement(int value) 
        {
            Node current = Head;
            Node previous = null;

            for (int i = 0; i <= Length; i++)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Host = current.Host;
                        if (current == null)
                        {
                            RemoveEndElement();
                        }
                        
                    }
                    else
                    {
                        RemoveStartElement();
                    }
                    break;
                }

                previous = current;
                current = current.Host;
            }
        }

        public void RemoveStartElement()
        {            
            if (Length == 0)
            {
                Console.WriteLine("Координат для удаления нет");
            }
            else
            {
                Node current = Head.Host;
                Head = current;
            }            
        }

        public void RemoveEndElement()
        {
            if (Length == 0)
            {
                Console.WriteLine("Координат для удаления нет");
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < Length - 1; i++)
                {
                    current = current.Host;
                }
                current.Host = null;
            }
        }
        
        public void RemoveDuplicates() 
        {
            Node current = Head;

            while (current != null)
            {
                Node runner = current;
                while (runner.Host != null)
                {
                    if (runner.Host.Value == current.Value)
                    {
                        runner.Host = runner.Host.Host;
                    }
                    else 
                    {
                        runner = runner.Host;
                    }
                }
                current = current.Host;
            }
        }

        public int SearchingElements(int value) 
        {
            Node current = Head;
            int count = 0;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    count++;
                }

                current = current.Host;
            }
            return count;   
        }

        public int SearchingEndElements(int index)
        {
            Node runner = Head;
            Node runner_h = Head;

            for (int i = 0; i < index - 1; i++)
            {
                if (runner_h != null)
                {
                    runner_h = runner_h.Host;
                }
                else
                {
                    Console.WriteLine("Выход за границу");
                    return 0;
                }              
            }

            if (runner_h.Host == null)
            {
                Console.WriteLine("Выход за границу");
                return 0;
            }

            while (runner_h.Host != null)
            {
                runner_h = runner_h.Host;
                runner = runner.Host;
            }

            return runner.Value;
        }
    }
}

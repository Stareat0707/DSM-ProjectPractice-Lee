using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material
{
    class Program
    {
        static void Main(string[] args)
        {
            Item watch = new Item { BuyDate = "20180501", Name = "시계", Usage = "시간 확인" };
            Item phone = new Item { BuyDate = "20180502", Name = "휴대폰", Usage = "다목적" };
            Item mouse = new Item { BuyDate = "20180503", Name = "마우스", Usage = "컴퓨터 조작" };
            Item pillow = new Item { BuyDate = "20180504", Name = "목베게", Usage = "편안한 숙면" };
            Item vat = new Item { BuyDate = "20180505", Name = "화분", Usage = "심신 안정" };
            Item pen = new Item { BuyDate = "20180506", Name = "볼펜", Usage = "필기구" };
            Item glasses = new Item { BuyDate = "20180507", Name = "안경", Usage = "자료 출력" };
            Item monitor = new Item { BuyDate = "20180508", Name = "모니터", Usage = "시력 향상" };
            Item keyboard = new Item { BuyDate = "20180509", Name = "키보드", Usage = "자료 입력" };
            Item printer = new Item { BuyDate = "20180510", Name = "프린터", Usage = "자료 출력" };

            Item[] items = {
                watch,
                phone,
                mouse,
                pillow,
                vat,
                pen,
                glasses,
                monitor,
                keyboard,
                printer
            };

            Dictionary<string, Item> dictionary = new Dictionary<string, Item>();
            foreach (var item in items)
            {
                dictionary.Add(item.Name, item);
                Console.WriteLine($"Dictionary에 {item.Name} 추가");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                dictionary.Remove(items[i].Name);
                Console.WriteLine($"Dictionary에서 {items[i].Name} 삭제");
            }
            Console.WriteLine();

            if (dictionary.ContainsKey("모니터"))
                Console.WriteLine($"모니터는 Dictionary에 존재합니다.");
            Console.WriteLine();

            Queue<Item> queue = new Queue<Item>();
            foreach (var item in items)
            {
                queue.Enqueue(item);
                Console.WriteLine($"Queue에 {item.Name} 추가");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine($"Queue에서 {queue.Dequeue().Name} 삭제");
            }
            Console.WriteLine();

            foreach (var item in queue)
            {
                if (item.Name == "모니터")
                    Console.WriteLine("모니터는 Queue에 존재합니다.");
            }
            Console.WriteLine();

            Stack<Item> stack = new Stack<Item>();
            foreach (var item in items)
            {
                stack.Push(item);
                Console.WriteLine($"Stack에 {item.Name} 추가");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine($"Stack에서 {stack.Pop().Name} 삭제");
            }
            Console.WriteLine();

            foreach (var item in stack)
            {
                if (item.Name == "모니터")
                    Console.WriteLine("모니터는 Stack에 존재합니다.");
            }
            Console.WriteLine();

            LinkedList<Item> linkedList = new LinkedList<Item>();
            foreach (var item in items)
            {
                linkedList.AddLast(item);
                Console.WriteLine($"LinkedList에 {item.Name} 추가");
            }
            Console.WriteLine();

            for (int i = 0; i < 5; ++i)
            {
                LinkedListNode<Item> node = linkedList.First;
                linkedList.RemoveFirst();
                Console.WriteLine($"LinkedList에서 {node.Value.Name} 삭제");
            }
            Console.WriteLine();

            foreach (var item in linkedList)
            {
                if (item.Name == "모니터")
                    Console.WriteLine($"모니터는 LinkedList에 존재합니다.");
            }
            Console.WriteLine();
        }
    }
}

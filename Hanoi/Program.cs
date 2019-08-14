using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    public class Program
    {

        static void Main(string[] args)
        {

            //init state
            Hanoi.Node init = new Hanoi.Node();
            init.Depth = 0;
            init.Parent = null;
            init.Action = null;
            init.State = new Hanoi.State(new int[] { 4, 3, 2, 1, 0 }, new int[] { }, new int[] { });
            //
            //goal state
            Hanoi.State test = new Hanoi.State(new int[] { }, new int[] { }, new int[] { 4, 3, 2, 1, 0 });
            //
            //
            //Node goal = BFS(init, test);
            //
            //var limit = (int)Math.Pow(2, test.Pegs[2].Count) - 1;
            //var goal = DLS(init,test,limit);
            //
            //getSolutionPath(goal);

        }

        private static void getSolutionPath(Node goal)
        {
            var solution = new Stack<Action>();
            var tmp = goal;
            while (tmp.Parent != null)
            {
                solution.Push(tmp.Action);
                tmp = tmp.Parent;
            }
            printSolution(solution);
        }

        private static void printSolution(Stack<Action> solution)
        {
            foreach (var action in solution)
            {
                System.Threading.Thread.Sleep(777);
                Console.WriteLine($"move {action.Direction} from peg {action.Source} to peg {action.Destination}");
            }
        }

        //
        public static Node BFS(Node node, State Goal)
        {
            var successors = new List<Node>();

            var q = new Queue<Node>();
            q.Enqueue(node);

            while (q.Count != 0)
            {
                Node Parent = q.Dequeue();
                if (Parent.State.Pegs[2].Count == Goal.Pegs[2].Count)
                {
                    //Console.WriteLine("Find Goal " + Parent.state);
                    return Parent;
                    //break;
                }//end if
                successors = Parent.Expand();
                for (int i = 0; i < successors.Count; i++)
                {
                    Node Temp = new Node(successors[i]);
                    q.Enqueue(Temp);
                }//end for
                 //
            }

            return null;
        }
        //
        public static Node DLS(Node Start, State Goal, int depthLimit)
        {
            var successors = new List<Node>();
            var s = new Stack<Node>();
            s.Push(Start);
            while (s.Count != 0)
            {
                Node Parent = s.Pop();
                if (Parent.State.Pegs[2].Count == Goal.Pegs[2].Count)
                {
                    return Parent;
                    //break;
                }
                if (Parent.Depth == depthLimit)
                {
                    continue;
                }
                else
                {
                    successors = Parent.Expand();
                    for (int i = 0; i < successors.Count; i++)
                    {
                        var temp = successors[i];
                        s.Push(temp);
                    }
                }//end else
            }
            return null;
        }
    }
}

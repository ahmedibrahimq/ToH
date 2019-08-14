using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    public static class UninformedSearch
    {
        public static void Iterative_Deepening_Search(Node Start, State Goal)
        {
            bool Cutt_off = false;
            int depth = 0;
            while (Cutt_off == false)
            {
                Console.WriteLine("Search Goal at Depth {0}", depth);
                var solution = DLS(Start, Goal, depth, ref Cutt_off);
                if (solution != null)
                Console.WriteLine("-----------------------------");
                depth++;
            }
        }//end method
        public static Node DLS(Node Start, State Goal, int depthLimit, ref bool Cut_off)
        {
            var successors = new List<Node>();
            List<Node> children = new List<Node>();
            Stack<Node> Fringe = new Stack<Node>();
            Fringe.Push(Start);
            while (Fringe.Count != 0)
            {
                Node Parent = Fringe.Pop();
                if (Parent.state.Pegs[2].Count == Goal.Pegs[2].Count)
                {
                    Cut_off = true;
                    return Parent;
                    //break;
                }//end if
                if (Parent.depth == depthLimit)
                {
                    continue;
                }
                else
                {
                    children = Parent.Expand();
                    for (int i = 0; i < children.Count; i++)
                    {
                        var State = children[i];
                        Fringe.Push(State);
                        //Node Tem = new Node(State);
                        //Fringe.Push(Tem);
                    }//end for
                }//end else
            }//end while
            return null;
        }//end method

        //
        //
        //
        public static void Bidirectional_Search(Node Start, Node Goal)
        {
            var Children_1 = new List<Node>();
            var Children_2 = new List<Node>();
            Queue<Node> Fringe_IN = new Queue<Node>();
            Queue<Node> Fringe_GO = new Queue<Node>();
            Fringe_IN.Enqueue(Start);
            Fringe_GO.Enqueue(Goal);
            while ((Fringe_IN.Count != 0) && (Fringe_GO.Count != 0))
            {
                Node Parent1 = (Node)Fringe_IN.Dequeue();
                if ((Equ(Parent1, Goal)) || Contain(Fringe_GO, Parent1))
                {
                    Console.WriteLine();
                    Console.WriteLine("Find Goal " + Parent1.state.ToString());
                    break;
                }//end if
                Children_1 = Parent1.Expand();
                for (int i = 0; i < Children_1.Count; i++)
                {
                    Fringe_IN.Enqueue(Children_1[i]);
                }//end for
                Node Parent2 = (Node)Fringe_GO.Dequeue();
                if ((Equ(Parent2, Start)) || Contain(Fringe_IN, Parent2))
                {
                    Console.WriteLine();
                    Console.WriteLine("Find Goal " + Parent2.state.ToString());
                    break;
                }//end if
                Children_2 = Parent2.Expand();
                for (int i = 0; i < Children_2.Count; i++)
                {
                    Fringe_GO.Enqueue(Children_2[i]);
                }//end for
            }//end while
        }//End Method

        public static bool Contain(Queue<Node> Fringe, Node Parent)
        {
            object[] S = new object[Fringe.Count];
            S = Fringe.ToArray();
            for (int i = 0; i < S.Length; i++)
            {
                Node Target = (Node)S[i];
                if (Equ(Target, Parent))
                {
                    return true;
                }
            }
            return false;
        }


        public static bool Equ(Node node1, Node node2)
        {
            for (int i = 0; i < 3; i++)
            {
                if (node1.state.Pegs[i].Count != node2.state.Pegs[i].Count)
                    return false;
                else
                {
                    State s1 = new State(node1.state);
                    State s2 = new State(node2.state);
                    for (int j = 0; j < s1.Pegs[i].Count; j++)
                    {
                        if (s1.Pegs[i].Pop() != s2.Pegs[i].Pop())
                            return false;
                    }
                }
            }
            return true;
        }

    }
}

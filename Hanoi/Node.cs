using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    public class Node
    {
        public Node()
        {

        }

        //copy constructor
        public Node(Node node)
        {
            Depth = node.Depth;
            Parent = node.Parent;
            Action = new Action(node.Action);
            State = new State(node.State);
        }

        public int Depth { get; set; }
        public Node Parent { get; set; }
        public Hanoi.State State { get; set; }
        public Action Action { get; set; }
        //
        //
        //
        //check near(adjacent pegs) first then far
        // check moving to lift first then to right
        public List<Node> Expand()
        {
            //output
            List<Node> successors = new List<Node>();
            //get all pegs
            var pegs = this.State.Pegs;
            // explore all pegs as source
            // i points to source peg
            for (int i = 0; i < pegs.Length; i++)
            {
                //if i points to an empty peg as the source
                if (pegs[i].Count == 0)
                {
                    //look for another peg
                    continue;
                }//else
                 //get the disc on the top of the source
                var discToMoveFromSource = pegs[i].Peek();
                //find all possible successors
                // explore all pegs as destination
                // j points to destination peg
                for (int j = 0; j < pegs.Length; j++)
                {
                    //
                    //if the destination peg is empty
                    //important information we'll need later
                    bool emptyPeg = pegs[j].Count == 0;
                    // avoid nullRefExeption
                    // when comparing the source disc with +infinity
                    // (source < destination) this condition -which checks
                    // if disk to move from source is smaller than the disc at the top of destination-
                    // will be always true (at Line 44, 88)
                    var discOnTheTopOfDestination = (emptyPeg) ? int.MaxValue : pegs[j].Peek();
                    //
                    // skip if i and j points to the same peg
                    var samePeg = i == j;
                    //
                    // (source is smaller than destination)?
                    var sourceSmaller = (discToMoveFromSource < discOnTheTopOfDestination);
                    //
                    if (!samePeg && sourceSmaller)
                    {
                        //
                        //make a move & create a new successor
                        // where to move the source disc
                        string direction = GetDirection(i, j);
                        //
                        //move from i to j
                        Peg source = (Peg) i;
                        Peg destination = (Peg) j;
                        Action action = new Action(source, destination, direction);
                        //
                        // the action which leads to new successor function
                        successors.Add(
                                    CreateSuccessor(discToMoveFromSource, (Peg) j, emptyPeg, action));
                    }
                }
            }
            return successors;
        }

        //
        //input:
        //i is the source peg index
        //j is the destination peg index
        private static string GetDirection(int i, int j)
        {
            // where to move the source disc
            string direction;
            //
            //if the source and destination pegs are adjacent
            //the action is move near not far
            bool adjacentPegs = Math.Abs(i - j) == 1;
            if (adjacentPegs)
            {
                direction = leftOrRight(i, j);
            }
            //
            //if the source and destination pegs are first and third
            //the action is move far
            else
            {
                direction = $"far {leftOrRight(i,j)}";
            }

            //
            //short code
            //direction = (adjacentPegs) ? leftOrRight(i, j) : $"far {leftOrRight(i, j)}";
            //
            var x =
                //pegs are adjacent?
                (adjacentPegs) ?
                //
                //if the source and destination pegs are adjacent
                //the action is move near not far
                "near " :
                //
                //if the source and destination pegs are first and third
                //the action is move far
                "far " + leftOrRight(i, j);
            //
            return direction;
        }

        //
        //input:
        //i is the source peg index
        //j is the destination peg index
        private static string leftOrRight(int i, int j)
        {
            string direction;
            //
            //if the source is on the right of the destination
            //the action is move left
            //if difference between source index i and destination index j is positive
            if (i - j > 0)
            {
                direction = "left";
            }
            //
            //if the source is on the lift of the destination
            //the action is move right
            // if difference is negative
            else
            {
                direction = "right";
            }

            return direction;
        }

        private Node CreateSuccessor(int discToMoveFromSource, Peg destinationPeg, bool isEmptyPeg, Action action)
        {
            Node child = new Node
            {
                //depth of parent plus one
                Depth = this.Depth + 1,
                //parent is the current node
                Parent = this,
                //extract the child state from the parent state and the new action 
                State = new State(this.State, discToMoveFromSource, destinationPeg, isEmptyPeg),
                Action = action
            };
            return child;
        }
    }
}

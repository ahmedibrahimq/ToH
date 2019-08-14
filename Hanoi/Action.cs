using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    enum Direction
    {
        left, right, far_left, far_right
    }

    public class Action
    {
        public Peg Source { get; set; }
        public Peg Destination{ get; set; }
        public string Direction { get; set; }
        
        //copy constractor
        public Action(Action copy)
        {
            Source = copy.Source;
            Destination = copy.Destination;
            Direction = copy.Direction;
        }

        public Action(Peg source, Peg destination, string direction)
        {
            Source = source;
            Destination = destination;
            Direction = direction;
        }
        public static Stack<Action> getSolutionPath(Node goal)
        {
            //last action should proccessed last
            var solution = new Stack<Action>();
            //holds all nodes lies on the solution path
            var tmp = goal;
            //
            //extract actions going from the goal to the root(initial state)
            //scan the path bottom-up
            //
            //is it the initial state?
            //while the root isnt' reached yet
            while (tmp.Parent != null)
            {
                solution.Push(tmp.Action);
                //point to the previous node at the solution path
                tmp = tmp.Parent;
            }
            return solution;
        }

    }
}

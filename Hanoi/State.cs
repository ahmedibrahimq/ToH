using System.Collections.Generic;
using System.Linq;

namespace Hanoi
{
    public enum Peg
    {
        first, second, third
    }
    public class State
    {
        //represent discs by integers small = 0, large = 1, larger = 2, ...
        //private const int smDisck = 0, mdDisck = 1, lgDisck = 2;

        public Stack<int>[] Pegs { get; set; }

        public void PushPeg(Peg peg, int value)
        {
            Pegs[(int) peg].Push(value);
        }

        public int PeekPeg(Peg peg)
        {
            return Pegs[(int) peg].Peek();
        }

        public int PopPeg(Peg peg)
        {
            return Pegs[(int) peg].Pop();
        }

        public State()
        {
            //initialize three empty stacks numbered left to right peg1, peg2, and peg3
            this.Pegs = new Stack<int>[3]
            {
                new Stack<int>(),
                new Stack<int>(),
                new Stack<int>()
            }
            ;
        }

        //constractor takes array of discs for each peg and puts initializes all pegs
        //input arrays must be sorted in descending order
        public State(int[] discsInPeg1, int[] discsInPeg2, int[] discsInPeg3) : this()
        {
            // make it easier to use for loop 
            int[][] allDiscs = 
            {
                sort(discsInPeg1),
                sort(discsInPeg2),
                sort(discsInPeg3)
            };

            //initialize pegs
            for (int i = 0; i < Pegs.Length; i++)
            {
                foreach (int disc in allDiscs[i])
                {
                    Pegs[i].Push(disc);
                }
            }
        }

        //
        //copy costructor
        public State(State copy) : this()
        {
            for (int i = 0; i < Pegs.Length; i++)
            {
                var currentPeg = copy.Pegs[i].Reverse();
                foreach (var disc in currentPeg)
                {
                    this.Pegs[i].Push(disc);
                }
            }
        }

        //
        //copy costructor
        //to create the state of the new successor function
        //
        //input:
        //destinationPegIndex: to check if we reach the destination peg
        public State(State toClone, int diskToMove, Peg destinationPeg, bool isEmptyDestination): this()
        {
            //
            //index source and destination peg which sets at the same location
            for (int i = 0; i < Pegs.Length; i++)
            {
                //hold the current peg
                //reverse discs on currunt peg i to copy from the parent's largest disc at bottom to smallest disc at peek
                //because foreach loops on stacks from peek to bottom
                var peg_i = toClone.Pegs[i].Reverse();
                //
                //are we reach the destination peg
                //copy each disc from the destination peg to the source peg
                //
                int destinationPeg_pos = (int) destinationPeg;

                if (i == destinationPeg_pos
                        &&
                        //if destination peg is empty
                        isEmptyDestination
                        )
                {
                    //put the new disc
                    this.Pegs[i].Push(diskToMove);
                }
                //
                //
                foreach (var disc in peg_i)
                {
                    //
                    //if the current disk is not the disc which will be moved from the source
                    //avoid copying the disc which will be moved from the source
                    if (disc != diskToMove)
                    {
                        this.Pegs[i].Push(disc);
                    }
                    //
                    //if the current peg is the destination peg, 
                    //put the the new arrived disc from the source to the top destination
                    
                    if (i == destinationPeg_pos
                        &&
                        (
                        //if destination peg is empty
                        //emptyDestination
                        //||
                        //or if we reachs the top of the destination peg
                        disc == toClone.PeekPeg(destinationPeg)
                        )
                        )
                    {
                        //put the new disc
                        this.Pegs[i].Push(diskToMove);
                    }
                }
            }
        }

        private static int[] sort(int[] intArr)
        {
            //when initializing the init state and goal test
            //sort inputed peg accordig to game rules 
            int[] sortedDiscs = intArr.OrderByDescending(l => l).ToArray();
            return sortedDiscs;
        }
    }
}

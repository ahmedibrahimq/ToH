using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Hanoi;

namespace hanoi.GUI
{
    public partial class HanoiUI : Form
    {
        public HanoiUI()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //
            btnPlay.Visible = false;
            //
            Node initState = initialState();
            //
            //goal state
            Hanoi.State goalTest = new Hanoi.State(new int[] { }, new int[] { }, new int[] { 2, 1, 0 });
            //
            //
            Node goal = Hanoi.Program.BFS(initState, goalTest);
            //
            var solutionPath = Hanoi.Action.getSolutionPath(goal);
            //
            //visualize
            //
            FlowLayoutPanel[] pegs = { peg0, peg1, peg2 };
            //
            play(solutionPath, pegs);
        }

        //
        //input:
        //pegs: for easy access using pointers
        private void play(Stack<Hanoi.Action> solutionPath, FlowLayoutPanel[] pegs)
        {
            //
            foreach (var action in solutionPath)
            {
                var sourcePeg = (int) action.Source;
                var destinationPeg = (int) action.Destination;
                //
                //get index of the disc on the top of source peg
                var top = pegs[sourcePeg].Controls.Count - 1;
                //point to the top of the source
                var disc = pegs[sourcePeg].Controls[top];
                //wait for visualization
                System.Threading.Thread.Sleep(333);
                //move to the top of the destination
                pegs[destinationPeg].Controls.Add(disc);
            }
        }

        private static Node initialState()
        {
            //init state
            Hanoi.Node init = new Hanoi.Node();
            init.Depth = 0;
            init.Parent = null;
            init.Action = null;
            init.State = new Hanoi.State(new int[] { 2, 1, 0 }, new int[] { }, new int[] { });
            return init;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnPlay2_Click(object sender, EventArgs e)
        {

            //
            btnPlay2.Visible = false;
            //init
            Node init = initialState2();
            //
            //test
            Hanoi.State goalTest = new Hanoi.State(new int[] { }, new int[] { }, new int[] { 3, 2, 1, 0 });
            //
            //            //
            var limit = (int)Math.Pow(2, goalTest.Pegs[2].Count) - 1;
            //
            //
            lblDLS.Text = "SOLVED";
            Node goal = Hanoi.Program.DLS(init, goalTest, limit);
            //
            var solutionPath = Hanoi.Action.getSolutionPath(goal);
            //

            //for easy access using pointers
            FlowLayoutPanel[] pegs = { peg02, peg12, peg22 };
            //
            play(solutionPath, pegs);
        }

        private static Node initialState2()
        {
            Hanoi.Node init = new Hanoi.Node();
            init.Depth = 0;
            init.Parent = null;
            init.Action = null;
            init.State = new Hanoi.State(new int[] { 3, 2, 1, 0 }, new int[] { }, new int[] { });
            return init;
        }
    }
}

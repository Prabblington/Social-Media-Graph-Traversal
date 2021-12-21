using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5_TaskB_SocialNetwork
{
    public partial class Form1 : Form
    {
        Graph<string> personGraph = new Graph<string>();
        LinkedList<Person> pList = new LinkedList<Person>();
        public Form1()
        {
            InitializeComponent();
        }   

        private void InsertNode_Click(object sender, EventArgs e)
        {
            string name = InsertBox.Text;
            Person person = new Person(name);
            pList.AddLast(person);
            personGraph.AddNode(pList.Last().Name);
            Update();
        }
        private void TotalNodes_Click(object sender, EventArgs e)
        {
            if (personGraph.NumNodesGraph() == 0)
            {
                MessageBox.Show("There are currently no people in the graph");
            }
            else
            {
                MessageBox.Show("The current graph has: " + personGraph.NumNodesGraph().ToString() + " people");
            }
        }
        private void ContainsGraphID_Click(object sender, EventArgs e)
        {
            string name = InsertBox.Text;
            if (personGraph.ContainsGraphID(name))
            {
                MessageBox.Show("Graph contains " + name);
            }
            else
            {
                MessageBox.Show("Graph does not contain " + name);
            }
        }
        private void RemoveNode_Click(object sender, EventArgs e)
        {
            string name = InsertBox.Text;
            personGraph.RemoveNode(personGraph.GetNodeByID(name));
            Update();
        }
        private void AdjNode_Click(object sender, EventArgs e)
        {
            string nameA = personABox.Text;
            string nameB = personBBox.Text;
            if (personGraph.IsAdjacent(personGraph.GetNodeByID(nameA), personGraph.GetNodeByID(nameB)))
            {
                MessageBox.Show("Node " + nameA + " and node " + nameA + " are adjacent");
            }
            else
            {
                MessageBox.Show("Node " + nameB + " and node " + nameB + " are NOT adjacent");
            }
        }
        private void InsertDirectedEdge_Click(object sender, EventArgs e)
        {
            string nameA = personABox.Text;
            string nameB = personBBox.Text;
            personGraph.AddEdge(nameA, nameB);
            MessageBox.Show("Edge between node " + nameA + " and node " + nameB + " has been created");
            Update();
        }
        private void showConnected_Click(object sender, EventArgs e)
        {
            AllConnectedPeople.ForeColor = Color.Red;
            AllConnectedPeople.Text += "\n" + personGraph.CheckAllAdj();
        }
        private void AllConnectedToPerson_Click(object sender, EventArgs e)
        {
            AllConnectedPeople.ForeColor = Color.Red;
            AllConnectedPeople.Text += "\n" + personGraph.AllAdjTo(InsertBox.Text);
        }
        private void Update()
        {
            displayGraphList.Text = personGraph.Display();
        }
        private void InsertBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PersonABox_TextChanged(object sender, EventArgs e)
        {

        }
        private void PersonBBox_TextChanged(object sender, EventArgs e)
        {

        }        
    }
}

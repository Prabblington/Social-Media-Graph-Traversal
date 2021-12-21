using System;
using System.Collections.Generic;
using System.Text;

namespace Week5_TaskB_SocialNetwork
{
    class GraphNode<T> where T : IComparable<T>
    {
        private T id;
        private LinkedList<T> adjList;

        public GraphNode(T item)
        {
            id = item;
            adjList = new LinkedList<T>();
        }
        public T ID
        {
            get { return id; }
            set { id = value; }
        }
        public LinkedList<T> AdjList
        {
            get { return adjList; }
        }
        public void AddEdge(GraphNode<T> node)
        {
            adjList.AddFirst(node.ID);
        }
        public void AddEdge(T node)
        {
            adjList.AddFirst(node);
        }
        public void RemoveEdge(GraphNode<T> node)
        {
            adjList.Remove(node.ID);
        }
        public void RemoveEdge(T node)
        {
            adjList.Remove(node);
        }

        public int CompareTo(Object obj)
        {
            GraphNode<T> other = (GraphNode<T>)obj;
            return id.CompareTo(other.id);
        }
    }

    class Graph<T> where T : IComparable<T>
    {
        LinkedList<GraphNode<T>> nodes;
        public Graph()
        {
            nodes = new LinkedList<GraphNode<T>>();
        }
        public GraphNode<T> GetNodeByID(T id)
        {
            GraphNode<T> locatedNode = null;

            if (ContainsGraphID(id))
            {
                foreach (GraphNode<T> n in nodes)
                {
                    if (n.ID.CompareTo(id) == 0)
                    {
                        locatedNode = n;
                    }
                }
            }
            return locatedNode;
        }
        public GraphNode<T> GetIDByNode(GraphNode<T> node)
        {
            GraphNode<T> locatedNode = null;

            if (ContainsGraphNode(node))
            {
                foreach (GraphNode<T> n in nodes)
                {
                    if (n.CompareTo(node) == 0)
                    {
                        locatedNode = n;
                    }
                }
            }
            return locatedNode;
        }
        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }
        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null && n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
            {
                Console.WriteLine("Node/s not found in the graph. Unable to add edge");
            }
        }
        public void RemoveNodeID(T id)
        {
            nodes.Remove(GetNodeByID(id));
        }
        public void RemoveNode(GraphNode<T> node)
        {
            nodes.Remove(node);
        }
        public void RemoveEdgeID(T from, T toNode)
        {
            GetNodeByID(from).RemoveEdge(toNode);
        }
        public void RemoveEdge(GraphNode<T> from, GraphNode<T> toNode)
        {
            GetIDByNode(from).RemoveEdge(GetIDByNode(toNode));
        }
        public int NumNodesGraph()
        {
            return nodes.Count;
        }
        public bool IsEmptyGraph()
        {
            return nodes.Count == 0;
        }
        public bool ContainsGraphID(T item)
        {
            bool found = false;
            if (item == null)
            {
                return false;

            }
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(item) == 0)
                {
                    found = true;
                    return found;
                }
            }
            return found;
        }
        public bool ContainsGraphNode(GraphNode<T> node)
        {
            bool found = false;
            if (node == null)
            {
                return false;
            }
            foreach (GraphNode<T> n in nodes)
            {
                if (n.CompareTo(node.ID) == 0)
                {
                    found = true;
                    return found;
                }
            }
            return found;
        }
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> toNode)
        {
            bool presentEdge = false;
            if (from == null || toNode == null)
            {
                return false;
            }
            foreach (GraphNode<T> n in nodes)
            {
                if (n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.AdjList.Contains(toNode.ID))
                    {
                        presentEdge = true;
                    }
                }
            }
            return presentEdge;
        }
        public string Display()
        {
            string buffer = "";
            foreach (GraphNode<T> data in nodes)
            {
                buffer += data.ID.ToString() + ", ";
            }
            return buffer;
        }        
        public string CheckAllAdj()
        {
            //starting at each node, use foreach to search all nodes and check for and edge
            //which is adjacent, if it is, add to string of adjacent and return string
            string adj = "";
            foreach(GraphNode<T> n in nodes)
            {
                if(n.AdjList.Count != 0)
                {
                    LinkedListNode<T> checkList = n.AdjList.First;
                    adj += "\n" + (n.ID.ToString());
                    while(checkList != null)
                    {
                        adj += " -> " + checkList.Value;
                        checkList = checkList.Next;
                    }
                }
                else
                {
                    adj += "\nNothing is connected to " + n.ID;             
                }
            }
            return adj.ToString();
        }
        public string AllAdjTo(T node)
        {
            string adj = "";
            GraphNode<T> insertedNode = GetNodeByID(node);
            if(insertedNode.AdjList.Count != 0)
            {
                LinkedListNode<T> adjacent = insertedNode.AdjList.First;
                adj += "\n" + (node.ToString());
                while(adjacent != null)
                {
                    adj += " -> " + adjacent.Value;
                    adjacent = adjacent.Next;
                }                
            }
            else
            {
                adj += "\nNothing is connected to " + node;
            }
            return adj.ToString();
        }        
        public int CompareTo(Object obj)
        {
            Graph<T> other = (Graph<T>)obj;
            return other.CompareTo(obj);
        }        
    }
}

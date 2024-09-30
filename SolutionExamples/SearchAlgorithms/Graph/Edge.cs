using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExamples { 
    public class Edge
{
    public Vertex From { get; }
    public Vertex To { get; }
    public int Weight { get; }

    public Edge(Vertex from, Vertex to, int weight)
    {
        From = from;
        To = to;
        Weight = weight;
    }
}
}

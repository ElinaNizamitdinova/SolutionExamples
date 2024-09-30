using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionExamples
{
    public class Dijkstra
    {
        public  Vertex DijkstraAlgorithm(Graph graph, Vertex source, Vertex endVertex)
        {
            var distances = graph.Vertices.ToDictionary(v => v, v => int.MaxValue);
            var previous = new Dictionary<Vertex, Vertex>();
            var notVisited = new HashSet<Vertex>(graph.Vertices);

            distances[source] = 0;

            while (notVisited.Any())
            {
                var nearestVertex = notVisited.OrderBy(v => distances[v]).FirstOrDefault();
                notVisited.Remove(nearestVertex);

                foreach (var edge in nearestVertex.Edges)
                {
                    var neighbor = edge.To;
                    if (notVisited.Contains(neighbor))
                    {
                        var currentDistance = distances[nearestVertex] + edge.Weight;
                        if (currentDistance < distances[neighbor])
                        {
                            distances[neighbor] = currentDistance;
                            previous[neighbor] = nearestVertex;
                        }
                    }
                }
            }

            foreach (var path in distances)
            {
                if (path.Key.Name == endVertex.Name)
                {
                    Console.WriteLine($"Shortest path from {source.Name} to {path.Key.Name} : {path.Value}");
                    return path.Key;
                }
            }
            Console.WriteLine("Path not found");
            return null;

        }
    }
}

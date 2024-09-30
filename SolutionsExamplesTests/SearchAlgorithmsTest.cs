using SolutionExamples;

namespace SolutionExamplesTests
{
    [TestClass]
    public class SearchAlgorithmsTest
    {
        SearchAlgorithms searchAlgorithms = new SearchAlgorithms();
        int[] arrayEven = SearchAlgorithms.NewArray(20);
        int[] arrayOdd = SearchAlgorithms.NewArray(23);


        [TestMethod]
        public void TestEvenLinearSearch()
        {
            searchAlgorithms.LinearSearch(arrayEven, 5);

        }

        [TestMethod]
        public void TestOddLinearSearch()
        {
            searchAlgorithms.LinearSearch(arrayOdd, 5);

        } 
        [TestMethod]
        public void TestNullLinearSearch()
        {
            searchAlgorithms.LinearSearch(null, 5);

        }
        [TestMethod]
        public void TestEmptyLinearSearch()
        {
            int[] num = { };
            searchAlgorithms.LinearSearch(num, 5);
        }
        [TestMethod]
        public void TestEvenBinarySearch()
        {
            searchAlgorithms.LinearSearch(arrayEven, 5);

        }
        [TestMethod]
        public void TestOddBinarySearch()
        {
            searchAlgorithms.LinearSearch(arrayOdd, 5);

        }

        [TestMethod]
        public void TestNullBinarySearch()
        {
            searchAlgorithms.LinearSearch(null, 5);

        }
        [TestMethod]
        public void TestEmptyBinarySearch()
        {
            int[] num = { };
            searchAlgorithms.LinearSearch(num, 5);
        }
        [TestMethod]
        public void TestDijkstra()
        {
            var graph = new Graph();

            var vertexA = new Vertex("A");
            var vertexB = new Vertex("B");
            var vertexC = new Vertex("C");
            var vertexD = new Vertex("D");
            var vertexE = new Vertex("E");


            graph.Vertices.AddRange(new[] { vertexA, vertexB, vertexC, vertexD, vertexE });

            vertexA.Edges.Add(new Edge(vertexA, vertexB, 1));
            vertexB.Edges.Add(new Edge(vertexB, vertexC, 2));
            vertexA.Edges.Add(new Edge(vertexA, vertexC, 1));
            vertexC.Edges.Add(new Edge(vertexC, vertexD, 4));
            vertexC.Edges.Add(new Edge(vertexC, vertexE, 1));
            vertexE.Edges.Add(new Edge(vertexE, vertexD, 6));

            Dijkstra dijkstra = new Dijkstra();
            var shortestPaths = dijkstra.DijkstraAlgorithm(graph, vertexA, vertexD);

        }
    }
}

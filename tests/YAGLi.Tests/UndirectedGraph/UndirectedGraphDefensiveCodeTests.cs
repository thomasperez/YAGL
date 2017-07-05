﻿using NFluent;
using NUnit.Framework;
using System.Collections.Generic;
using YAGLi.Tests.Utils;

namespace YAGLi.Tests.UndirectedGraph
{
    [TestFixture]
    public class UndirectedGraphDefensiveCodeTests
    {
        private readonly Edge<Vertex>[] NULL_EDGE_ARRAY = null;
        private readonly IEnumerable<Edge<Vertex>> NULL_EDGE_COLLECTION = null;
        private readonly Edge<Vertex>[] EDGE_ARRAY_WHO_CONTAINS_NULL = new Edge<Vertex>[] { null };
        private readonly IEnumerable<Edge<Vertex>> EDGE_COLLECTION_WHO_CONTAINS_NULL = new Edge<Vertex>[] { null };
        private readonly Vertex[] NULL_VERTEX_ARRAY = null;
        private readonly IEnumerable<Vertex> NULL_VERTEX_COLLECTION = null;
        private readonly Vertex[] VERTEX_ARRAY_WHO_CONTAINS_NULL = new Vertex[] { null };
        private readonly IEnumerable<Vertex> VERTEX_COLLECTION_WHO_CONTAINS_NULL = new Vertex[] { null };

        private UndirectedGraph<Vertex, Edge<Vertex>> _newGraph;
        private readonly UndirectedGraph<Vertex, Edge<Vertex>> _originalGraph = new UndirectedGraph<Vertex, Edge<Vertex>>(
            true,
            true,
            new Edge<Vertex>[]
            {
                new Edge<Vertex>("v0", "v1"),
                new Edge<Vertex>("v1", "v4"),
                new Edge<Vertex>("v4", "v4"),
                new Edge<Vertex>("v3", "v4"),
                new Edge<Vertex>("v4", "v3")
            },
            new Vertex[]
            {
                "v0",
                "v1",
                "v2",
                "v3",
                "v4"
            }, new VertexEqualityComparer());

        [TearDown]
        public void TearDown()
        {
            Check.That(_newGraph).IsSameReferenceAs(_originalGraph);
        }

        [Test]
        public void UndirectedGraph_AddEdges_when_the_array_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddEdges(NULL_EDGE_ARRAY);
        }

        [Test]
        public void UndirectedGraph_AddEdges_when_the_collection_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddEdges(NULL_EDGE_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_AddEdges_with_Array_should_filter_edges_equal_to_null()
        {
            _newGraph = _originalGraph.AddEdges(EDGE_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_AddEdges_with_IEnumerable_should_filter_edges_equal_to_null()
        {
            _newGraph = _originalGraph.AddEdges(EDGE_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_AddEdgesAndVertices_when_the_array_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddEdgesAndVertices(NULL_EDGE_ARRAY);
        }

        [Test]
        public void UndirectedGraph_AddEdgesAndVertices_when_the_collection_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddEdgesAndVertices(NULL_EDGE_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_AddEdgesAndVertices_with_Array_should_filter_null_edges()
        {
            _newGraph = _originalGraph.AddEdgesAndVertices(EDGE_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_AddEdgesAndVertices_with_IEnumerable_should_filter_null_edges()
        {
            _newGraph = _originalGraph.AddEdgesAndVertices(EDGE_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_AddVertices_when_the_array_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddVertices(NULL_VERTEX_ARRAY);
        }

        [Test]
        public void UndirectedGraph_AddVertices_when_the_collection_is_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.AddVertices(NULL_VERTEX_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_AddVertices_with_Array_should_filter_the_null_vertices()
        {
            _newGraph = _originalGraph.AddVertices(VERTEX_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_AddVertices_with_IEnumerable_should_filter_the_null_vertices()
        {
            _newGraph = _originalGraph.AddVertices(VERTEX_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveEdge_with_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdge(null);
        }

        [Test]
        public void UndirectedGraph_RemoveEdgeAndVertices_with_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdgeAndVertices(null);
        }

        [Test]
        public void UndirectedGraph_RemoveEdges_with_null_IEnumerable_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdges(NULL_EDGE_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_RemoveEdges_with_null_Array_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdges(NULL_EDGE_ARRAY);
        }

        [Test]
        public void UndirectedGraph_RemoveEdges_with_IEnumerable_should_filter_null_edges()
        {
            _newGraph = _originalGraph.RemoveEdges(EDGE_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveEdges_with_Array_should_filter_null_edges()
        {
            _newGraph = _originalGraph.RemoveEdges(EDGE_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveEdgesAndVertices_with_null_IEnumerable_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdgesAndVertices(NULL_EDGE_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_RemoveEdgesAndVertices_with_null_Array_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveEdgesAndVertices(NULL_EDGE_ARRAY);
        }

        [Test]
        public void UndirectedGraph_RemoveEdgesAndVertices_IEnumerable_should_filter_null_edges()
        {
            _newGraph = _originalGraph.RemoveEdgesAndVertices(EDGE_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveEdgesAndVertices_with_Array_should_filter_null_edges()
        {
            _newGraph = _originalGraph.RemoveEdgesAndVertices(EDGE_ARRAY_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveVertex_with_null_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveVertex(null);
        }

        [Test]
        public void UndirectedGraph_RemoveVertices_with_null_IEnumerable_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveVertices(NULL_VERTEX_COLLECTION);
        }

        [Test]
        public void UndirectedGraph_RemoveVertices_with_null_Array_should_return_the_same_instance()
        {
            _newGraph = _originalGraph.RemoveVertices(NULL_VERTEX_ARRAY);
        }

        [Test]
        public void UndirectedGraph_RemoveVertices_with_IEnumerable_should_filter_null_vertices()
        {
            _newGraph = _originalGraph.RemoveVertices(VERTEX_COLLECTION_WHO_CONTAINS_NULL);
        }

        [Test]
        public void UndirectedGraph_RemoveVertices_with_Array_should_filter_null_vertices()
        {
            _newGraph = _originalGraph.RemoveVertices(VERTEX_ARRAY_WHO_CONTAINS_NULL);
        }
    }
}

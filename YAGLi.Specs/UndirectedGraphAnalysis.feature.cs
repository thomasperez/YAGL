﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace YAGLi.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("UndirectedGraphAnalysis")]
    public partial class UndirectedGraphAnalysisFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UndirectedGraphAnalysis.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UndirectedGraphAnalysis", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent edges of an edge located into a undirected graph who allow loops" +
            " and parallel edges")]
        public virtual void GetTheAdjacentEdgesOfAnEdgeLocatedIntoAUndirectedGraphWhoAllowLoopsAndParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent edges of an edge located into a undirected graph who allow loops" +
                    " and parallel edges", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "v0"});
            table1.AddRow(new string[] {
                        "v1"});
            table1.AddRow(new string[] {
                        "v2"});
            table1.AddRow(new string[] {
                        "v3"});
            table1.AddRow(new string[] {
                        "v4"});
#line 6
 testRunner.And("the vertices", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table2.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table2.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table2.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table2.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
            table2.AddRow(new string[] {
                        "e4",
                        "v3",
                        "v4"});
#line 13
 testRunner.And("the edges", ((string)(null)), table2, "And ");
#line 20
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table3.AddRow(new string[] {
                        "e1"});
            table3.AddRow(new string[] {
                        "e2"});
            table3.AddRow(new string[] {
                        "e4"});
#line 21
 testRunner.Then("the adjacent edges of the edge \"e3\" should be", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent edges of an edge not located into a undirected graph who allow l" +
            "oops and parallel edges")]
        public virtual void GetTheAdjacentEdgesOfAnEdgeNotLocatedIntoAUndirectedGraphWhoAllowLoopsAndParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent edges of an edge not located into a undirected graph who allow l" +
                    "oops and parallel edges", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table4.AddRow(new string[] {
                        "v0"});
            table4.AddRow(new string[] {
                        "v1"});
            table4.AddRow(new string[] {
                        "v2"});
            table4.AddRow(new string[] {
                        "v3"});
            table4.AddRow(new string[] {
                        "v4"});
#line 30
 testRunner.And("the vertices", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table5.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table5.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table5.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table5.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
            table5.AddRow(new string[] {
                        "e4",
                        "v3",
                        "v4"});
#line 37
 testRunner.And("the edges", ((string)(null)), table5, "And ");
#line 44
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("the adjacent edges of the edge with the ends \"v0\" and \"v4\" should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent edges of an edge not located into a undirected graph who allow l" +
            "oops and disallow parallel edges")]
        public virtual void GetTheAdjacentEdgesOfAnEdgeNotLocatedIntoAUndirectedGraphWhoAllowLoopsAndDisallowParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent edges of an edge not located into a undirected graph who allow l" +
                    "oops and disallow parallel edges", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 48
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
 testRunner.And("the property disallow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table6.AddRow(new string[] {
                        "v0"});
            table6.AddRow(new string[] {
                        "v1"});
            table6.AddRow(new string[] {
                        "v2"});
            table6.AddRow(new string[] {
                        "v3"});
            table6.AddRow(new string[] {
                        "v4"});
#line 50
 testRunner.And("the vertices", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table7.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table7.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table7.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table7.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
#line 57
 testRunner.And("the edges", ((string)(null)), table7, "And ");
#line 63
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the adjacent edges of the edge with the ends \"v0\" and \"v4\" should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent edges of an edge equal to an edge located into a undirected grap" +
            "h who allow loops and disallow parallel edges")]
        public virtual void GetTheAdjacentEdgesOfAnEdgeEqualToAnEdgeLocatedIntoAUndirectedGraphWhoAllowLoopsAndDisallowParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent edges of an edge equal to an edge located into a undirected grap" +
                    "h who allow loops and disallow parallel edges", ((string[])(null)));
#line 66
this.ScenarioSetup(scenarioInfo);
#line 67
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 68
 testRunner.And("the property disallow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table8.AddRow(new string[] {
                        "v0"});
            table8.AddRow(new string[] {
                        "v1"});
            table8.AddRow(new string[] {
                        "v2"});
            table8.AddRow(new string[] {
                        "v3"});
            table8.AddRow(new string[] {
                        "v4"});
#line 69
 testRunner.And("the vertices", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table9.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table9.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table9.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table9.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
#line 76
 testRunner.And("the edges", ((string)(null)), table9, "And ");
#line 82
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table10.AddRow(new string[] {
                        "e1"});
            table10.AddRow(new string[] {
                        "e2"});
#line 83
 testRunner.Then("the adjacent edges of the edge with the ends \"v3\" and \"v4\" should be", ((string)(null)), table10, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent vertices of a vertex contained in a UndirectedGraph")]
        public virtual void GetTheAdjacentVerticesOfAVertexContainedInAUndirectedGraph()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent vertices of a vertex contained in a UndirectedGraph", ((string[])(null)));
#line 88
this.ScenarioSetup(scenarioInfo);
#line 89
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table11.AddRow(new string[] {
                        "v0"});
            table11.AddRow(new string[] {
                        "v1"});
            table11.AddRow(new string[] {
                        "v2"});
            table11.AddRow(new string[] {
                        "v3"});
            table11.AddRow(new string[] {
                        "v4"});
#line 91
 testRunner.And("the vertices", ((string)(null)), table11, "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table12.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table12.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table12.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table12.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
            table12.AddRow(new string[] {
                        "e4",
                        "v4",
                        "v3"});
#line 98
 testRunner.And("the edges", ((string)(null)), table12, "And ");
#line 105
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table13.AddRow(new string[] {
                        "v0"});
            table13.AddRow(new string[] {
                        "v4"});
#line 106
 testRunner.Then("the adjacent vertices of the vertex \"v1\" should be", ((string)(null)), table13, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Get the adjacent vertices of a vertex not contained in a UndirectedGraph")]
        public virtual void GetTheAdjacentVerticesOfAVertexNotContainedInAUndirectedGraph()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get the adjacent vertices of a vertex not contained in a UndirectedGraph", ((string[])(null)));
#line 111
this.ScenarioSetup(scenarioInfo);
#line 112
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 113
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table14.AddRow(new string[] {
                        "v0"});
            table14.AddRow(new string[] {
                        "v1"});
            table14.AddRow(new string[] {
                        "v2"});
            table14.AddRow(new string[] {
                        "v3"});
            table14.AddRow(new string[] {
                        "v4"});
#line 114
 testRunner.And("the vertices", ((string)(null)), table14, "And ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table15.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table15.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table15.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table15.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
            table15.AddRow(new string[] {
                        "e4",
                        "v4",
                        "v3"});
#line 121
 testRunner.And("the edges", ((string)(null)), table15, "And ");
#line 128
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
 testRunner.Then("the adjacent vertices of the vertex \"v5\" should be empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

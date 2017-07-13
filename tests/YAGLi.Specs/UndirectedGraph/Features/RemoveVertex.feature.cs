﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace YAGLi.Specs.UndirectedGraph.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Removing vertex/vertices from a undirected graph")]
    public partial class RemovingVertexVerticesFromAUndirectedGraphFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RemoveVertex.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Removing vertex/vertices from a undirected graph", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Remove a vertex from a undirected graph")]
        public virtual void RemoveAVertexFromAUndirectedGraph()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remove a vertex from a undirected graph", ((string[])(null)));
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
                        "End1",
                        "End2"});
            table2.AddRow(new string[] {
                        "v0",
                        "v1"});
            table2.AddRow(new string[] {
                        "v1",
                        "v4"});
            table2.AddRow(new string[] {
                        "v4",
                        "v4"});
            table2.AddRow(new string[] {
                        "v4",
                        "v3"});
            table2.AddRow(new string[] {
                        "v3",
                        "v4"});
#line 13
 testRunner.And("the edges", ((string)(null)), table2, "And ");
#line 20
 testRunner.And("the undirected graph created with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.When("I remove the vertex \"v4\" from the undirected graph", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("I get a new undirected graph", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table3.AddRow(new string[] {
                        "v0"});
            table3.AddRow(new string[] {
                        "v1"});
            table3.AddRow(new string[] {
                        "v2"});
            table3.AddRow(new string[] {
                        "v3"});
#line 23
 testRunner.And("he contains the vertices", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table4.AddRow(new string[] {
                        "v0",
                        "v1"});
#line 29
 testRunner.And("he contains the edges", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Remove vertices from a undirected graph")]
        public virtual void RemoveVerticesFromAUndirectedGraph()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Remove vertices from a undirected graph", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 34
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table5.AddRow(new string[] {
                        "v0"});
            table5.AddRow(new string[] {
                        "v1"});
            table5.AddRow(new string[] {
                        "v2"});
            table5.AddRow(new string[] {
                        "v3"});
            table5.AddRow(new string[] {
                        "v4"});
#line 36
 testRunner.And("the vertices", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table6.AddRow(new string[] {
                        "v0",
                        "v1"});
            table6.AddRow(new string[] {
                        "v1",
                        "v4"});
            table6.AddRow(new string[] {
                        "v4",
                        "v4"});
            table6.AddRow(new string[] {
                        "v4",
                        "v3"});
            table6.AddRow(new string[] {
                        "v3",
                        "v4"});
#line 43
 testRunner.And("the edges", ((string)(null)), table6, "And ");
#line 50
 testRunner.And("the undirected graph created with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table7.AddRow(new string[] {
                        "v0"});
            table7.AddRow(new string[] {
                        "v1"});
#line 51
 testRunner.When("I remove the vertices from the undirected graph", ((string)(null)), table7, "When ");
#line 55
 testRunner.Then("I get a new undirected graph", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table8.AddRow(new string[] {
                        "v2"});
            table8.AddRow(new string[] {
                        "v3"});
            table8.AddRow(new string[] {
                        "v4"});
#line 56
 testRunner.And("he contains the vertices", ((string)(null)), table8, "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table9.AddRow(new string[] {
                        "v4",
                        "v4"});
            table9.AddRow(new string[] {
                        "v4",
                        "v3"});
            table9.AddRow(new string[] {
                        "v3",
                        "v4"});
#line 61
 testRunner.And("he contains the edges", ((string)(null)), table9, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

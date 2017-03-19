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
    [NUnit.Framework.DescriptionAttribute("UndirectedGraphCreation")]
    public partial class UndirectedGraphCreationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "UndirectedGraphCreation.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UndirectedGraphCreation", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create a undirected graph who disallow loops and parallel edges")]
        public virtual void CreateAUndirectedGraphWhoDisallowLoopsAndParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a undirected graph who disallow loops and parallel edges", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("the property disallow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("the property disallow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "v0"});
            table1.AddRow(new string[] {
                        "v1"});
            table1.AddRow(new string[] {
                        "v2"});
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
                        "v0",
                        "v1"});
            table2.AddRow(new string[] {
                        "e2",
                        "v1",
                        "v1"});
#line 11
 testRunner.And("the edges", ((string)(null)), table2, "And ");
#line 16
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table3.AddRow(new string[] {
                        "v0"});
            table3.AddRow(new string[] {
                        "v1"});
            table3.AddRow(new string[] {
                        "v2"});
#line 17
 testRunner.Then("he should contains the vertices", ((string)(null)), table3, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table4.AddRow(new string[] {
                        "e0"});
#line 22
 testRunner.And("the edges", ((string)(null)), table4, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a undirected graph who disallow loops and allow parallel edges")]
        public virtual void CreateAUndirectedGraphWhoDisallowLoopsAndAllowParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a undirected graph who disallow loops and allow parallel edges", ((string[])(null)));
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given("the property disallow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
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
#line 29
 testRunner.And("the vertices", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table6.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table6.AddRow(new string[] {
                        "e1",
                        "v0",
                        "v1"});
            table6.AddRow(new string[] {
                        "e2",
                        "v1",
                        "v1"});
#line 34
 testRunner.And("the edges", ((string)(null)), table6, "And ");
#line 39
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table7.AddRow(new string[] {
                        "v0"});
            table7.AddRow(new string[] {
                        "v1"});
            table7.AddRow(new string[] {
                        "v2"});
#line 40
 testRunner.Then("he should contains the vertices", ((string)(null)), table7, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table8.AddRow(new string[] {
                        "e0"});
            table8.AddRow(new string[] {
                        "e1"});
#line 45
 testRunner.And("the edges", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a undirected graph who allow loops and disallow parallel edges")]
        public virtual void CreateAUndirectedGraphWhoAllowLoopsAndDisallowParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a undirected graph who allow loops and disallow parallel edges", ((string[])(null)));
#line 50
this.ScenarioSetup(scenarioInfo);
#line 51
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("the property disallow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table9.AddRow(new string[] {
                        "v0"});
            table9.AddRow(new string[] {
                        "v1"});
            table9.AddRow(new string[] {
                        "v2"});
#line 53
 testRunner.And("the vertices", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table10.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table10.AddRow(new string[] {
                        "e1",
                        "v0",
                        "v1"});
            table10.AddRow(new string[] {
                        "e2",
                        "v1",
                        "v1"});
#line 58
 testRunner.And("the edges", ((string)(null)), table10, "And ");
#line 63
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table11.AddRow(new string[] {
                        "v0"});
            table11.AddRow(new string[] {
                        "v1"});
            table11.AddRow(new string[] {
                        "v2"});
#line 64
 testRunner.Then("he should contains the vertices", ((string)(null)), table11, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table12.AddRow(new string[] {
                        "e0"});
            table12.AddRow(new string[] {
                        "e2"});
#line 69
 testRunner.And("the edges", ((string)(null)), table12, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create a undirected graph who allow loops and parallel edges")]
        public virtual void CreateAUndirectedGraphWhoAllowLoopsAndParallelEdges()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a undirected graph who allow loops and parallel edges", ((string[])(null)));
#line 74
this.ScenarioSetup(scenarioInfo);
#line 75
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table13.AddRow(new string[] {
                        "v0"});
            table13.AddRow(new string[] {
                        "v1"});
            table13.AddRow(new string[] {
                        "v2"});
#line 77
 testRunner.And("the vertices", ((string)(null)), table13, "And ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table14.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table14.AddRow(new string[] {
                        "e1",
                        "v0",
                        "v1"});
            table14.AddRow(new string[] {
                        "e2",
                        "v1",
                        "v1"});
#line 82
 testRunner.And("the edges", ((string)(null)), table14, "And ");
#line 87
 testRunner.When("I create a new undirected graph with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table15.AddRow(new string[] {
                        "v0"});
            table15.AddRow(new string[] {
                        "v1"});
            table15.AddRow(new string[] {
                        "v2"});
#line 88
 testRunner.Then("he should contains the vertices", ((string)(null)), table15, "Then ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table16.AddRow(new string[] {
                        "e0"});
            table16.AddRow(new string[] {
                        "e1"});
            table16.AddRow(new string[] {
                        "e2"});
#line 93
 testRunner.And("the edges", ((string)(null)), table16, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
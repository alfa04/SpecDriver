﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.7.1.0
//      SpecFlow Generator Version:1.7.0.0
//      Runtime Version:2.0.50727.5456
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Project1.Features.Etsy
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.7.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Etsy Advanced Search Functionality")]
    public partial class EtsyAdvancedSearchFunctionalityFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EtsyAdvancedSearch.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Etsy Advanced Search Functionality", "In order to show the advanced search functionality\r\nAs a user\r\nI want to search f" +
                    "or an item in a sub category", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Advanced Search for items in various categories that exist and don\'t exist")]
        [NUnit.Framework.TestCaseAttribute("Knitting", "\'hat\'", "some", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Jewelry", "\'necklace\'", "some", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Jewelry", "\'specdriver\'", "no", new string[0])]
        public virtual void AdvancedSearchForItemsInVariousCategoriesThatExistAndDonTExist(string subCategory, string searchTerm, string searchResults, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Advanced Search for items in various categories that exist and don\'t exist", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am searching on Etsy.com");
#line 8
 testRunner.When(string.Format("I specify the {0} sub category", subCategory));
#line 9
 testRunner.And(string.Format("I search for {0}", searchTerm));
#line 10
 testRunner.Then(string.Format("I should see {0} search results for {1}", searchResults, searchTerm));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Misspelling a word corrects search automatically")]
        public virtual void MisspellingAWordCorrectsSearchAutomatically()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Misspelling a word corrects search automatically", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given("I am searching on Etsy.com");
#line 19
 testRunner.When("I specify the Knitting sub category");
#line 20
 testRunner.And("I search for \'scalf\'");
#line 21
 testRunner.Then("I should see some search results for \'scarf\'");
#line 22
 testRunner.And("I should see that the search was for \'scarf\' instead of \'scalf\'");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#endregion

﻿using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Features
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberİs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberİs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

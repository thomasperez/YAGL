﻿using TechTalk.SpecFlow;
using YAGLi.Specs.Common.Validators;

namespace YAGLi.Specs.UndirectedGraph.Steps
{
    [Binding]
    public abstract class UndirectedGraphStepWithGraphValidator
    {
        protected UndirectedGraphStepWithGraphValidator(UndirectedGraphBuilder builder, GraphValidator validator)
        {
            Builder = builder;
            Validator = validator;
        }
        
        protected UndirectedGraphBuilder Builder { get; }
        protected GraphValidator Validator { get; }
    }
}

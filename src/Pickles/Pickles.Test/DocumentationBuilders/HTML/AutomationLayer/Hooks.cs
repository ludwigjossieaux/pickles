﻿//  --------------------------------------------------------------------------------------------------------------------
//  <copyright file="Hooks.cs" company="PicklesDoc">
//  Copyright 2011 Jeffrey Cameron
//  Copyright 2012-present PicklesDoc team and community contributors
//
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//  </copyright>
//  --------------------------------------------------------------------------------------------------------------------

using System;
using System.Linq;
using Autofac;
using TechTalk.SpecFlow;

namespace PicklesDoc.Pickles.Test.DocumentationBuilders.HTML.AutomationLayer
{
    [Binding]
    public class Hooks
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(typeof(Runner).Assembly);
            builder.RegisterModule<PicklesModule>();
            CurrentScenarioContext.Container = builder.Build();

            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("enableExperimentalFeatures"))
            {
                var configuration = CurrentScenarioContext.Container.Resolve<IConfiguration>();
                configuration.EnableExperimentalFeatures();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            var container = CurrentScenarioContext.Container;

            container?.Dispose();

            CurrentScenarioContext.Container = null;
        }
    }
}

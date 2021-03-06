﻿/*******************************************************************************
 * Copyright (c) 2015 Bo Kang
 *   
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *  
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *******************************************************************************/

namespace CSharpLogic
{
    public class TraceStep
    {
        public object Source { get; set; }

        public object Target { get; set; }

        // V2.0 Knowledge component the step reflects to.
        public object KC { get; set; } 

        // meta-scaffolding
        public object Rule { get; set; }

        // didactic-scaffolding
        public object AppliedRule { get; set; }

        public bool WrongStep { get; set; }

        public TraceStep(object source, object target, object concept, object rule, object appliedRule)
        {
            Source = source;
            Target = target;
            Rule = rule;
            AppliedRule = appliedRule;
            WrongStep = false;
        }

        public TraceStep(object source, object target)
        {
            Source = source;
            Target = target;
            WrongStep = true;
        }

        public TraceStep Clone()
        {
            return new TraceStep(Source, Target, KC, Rule, AppliedRule);
        }
    }
}
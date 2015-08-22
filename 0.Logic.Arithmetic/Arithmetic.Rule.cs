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
    public static class ArithRule
    {
        public static string CalcRule(object method, object left,
            object right, object result)
        {
            return string.Format("Make the calculation: {1} {0} {2}",
                method.ToString(), left.ToString(), right.ToString());
        }

        public static string CalcRule(object method)
        {
            return string.Format("Think about Calculation: {0}", method.ToString());
        }

    }
}
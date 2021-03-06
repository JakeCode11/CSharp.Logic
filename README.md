# CSharp.Logic

[![](https://travis-ci.org/buptkang/CSharp.Logic.png)](https://travis-ci.org/buptkang/CSharp.Logic)
 
<p align="justify">
This library is an embedded logic reasoning core. It supports recursive substitution based on the logic rules. Its logical form is a type of First Order Logic from <a href="https://github.com/miniKanren/miniKanren">miniKanren</a>, a scheme library for relational programming. This library further includes a rule-production engine on arithmetic and algebra computation. It traces the computing paths which can be used to build a symbolic algebraic tutoring engine.
</p>

## Recursion Loop

Loop 1: Arithmetic
Loop 2: Fraction
Loop 3: Algebra Expression (Linear and Quadratic)
Loop 4: Algebraic Equation

## Code Examples

Arithmetic Expression (no variable) -> Algebraic Expression (variable) ->
Fractional Expression  -> Equational Expression

1. Consider math arithmetic problems, such as 1+2+3=?, 1-2*3=?, check out unit test to compute the result and intermediate steps to reach that result: [ArithTest.cs](https://github.com/buptkang/CSharp.Logic/tree/master/Test/0.Logic.Arithmetic).

2. Consider math algebraic expression problems, such as simplifying 2x+3y-2x+2z, check out unit test code to compute the result and intermediate steps to reach that result: [AlgebraTest.cs](https://github.com/buptkang/CSharp.Logic/tree/master/Test/1.Logic.Algebra).

3. Consider math algebra equation problems, such as simplifying 3y+2x-x+3y=y, check out unit test code to compute the result and intermediate steps to reach that result:
[\*.Equation.\*.Test.cs](https://github.com/buptkang/CSharp.Logic/tree/master/Test/2.Logic.Equation)

## License

Copyright (c) 2015 Bo Kang
<p align="justify">
Licensed under the Apache License, Version 2.0 (the "License") you may not use this file except in compliance with the License. You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0. Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
</p>

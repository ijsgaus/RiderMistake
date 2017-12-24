namespace Lib
open System.Runtime.CompilerServices

type Test = 
    | Test of int
    [<SpecialName>]
    static member op_Implicit(v) = Test v

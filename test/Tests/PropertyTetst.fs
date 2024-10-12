namespace Tests

open FsCheck.Xunit


(*
module test =
    let f x = 2
*)


[<Properties(MaxTest=100)>]
type PlusPropertyTest () =

    [<Property>]
    member _.``Plus is commutative`` (a: int, b: int) = 
        //printfn $"{a}, {b}"
        a + b = b + a

    [<Property>]
    member _.``Div is commutative`` (a: int, b: int) = 
        //printfn $"{a}, {b}"        
        if b <> 0 && a <> 0 then a / b = b / a else true

    [<Property>]
    member _.``Plus is associative`` (a: int, b: int, c: int) = a + b + c = a + (b + c)


    [<Property>]
    member _.``Double rev is id`` (lst: List<int>) = 
        //printfn $"{a}, {b}"        
        List.rev (List.rev lst) = lst
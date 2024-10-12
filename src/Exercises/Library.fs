namespace Exercises

module Say =

    type Compare = Le | Eq | Ge

    type T = A of int | B of int

    let hello name =
        printfn "Hello %s" name
    
    let x = 1
    let s = "str"
    let c = 'c'
    let b = true
    let f = 1.0

    let d2 = (1,"d")
    let d3 = (true, "d", 1)
    let int_arr = [|1;2;3|]
    int_arr.[0] <- 2
    let (arr0 : int[]) = Array.zeroCreate 10
    let init i =  i * 2 
    let (arr1 : int[]) = Array.init 10  init
    let str_arr = [|"1"; "2"; "3"|]

    let err_arr = [|"1", "2", "3"|]

    let int_lst = [1;2;3]
    
    let fn x b = (if x then 1 else b) + 7

    let fn2 x = 
        for i in 1..2..10 do
            printfn $"{i}"

        for i in str_arr do
            printfn $"{i}"

        let  count = 0
        
        while count < 10 do
            let count = count + 1
            printfn $"{count}"


    (*let sort (arr: 'a[]) (compare: 'a -> 'a -> Compare) = 
        match compare arr.[0] arr.[1] with 
        | Eq -> ..
        | Le -> ..
        | Ge -> ..
*)
    let compareT x y =
        match x,y with 
        | A i, A j -> if i < j then Le elif i > j then Ge else Eq
        | B i, B j -> if i < j then Le elif i > j then Ge else Eq
        | A _, B _ -> Ge 
        | B _, A _ -> Le 

  //  let r = sort [|A 10; B 1|] compareT

    let rec g x = h x
    and h y= g y 

    let h1 = (+)

    let add_2 = h1 2

    let gg = (h1 2) 3
    let ex s= failwithf $"{s}" 

    let rec fib n =
        if n < 2
        then n
        else fib (n - 1) + fib (n - 2) 

module MyList = 

    type MyList<'elem> = 
        | Empty
        | Cons of 'elem * MyList<'elem>

    let rec len lst = 
        match lst with
        | Empty -> 0
        | Cons (_,tl) -> 1 + len tl 

    let rec fold f state lst =
        match lst with
        | Empty -> state
        | Cons (hd, tl) -> fold f (f state hd) tl
        //| Cons (hd, tl) -> f (fold f state tl) hd

    let rec map f lst =
        let f state elem = 
            Cons (f elem, state) 
        let state = Empty
        let lst = lst
        fold f state lst 

module main = 
    [<EntryPoint>]
    let main argv = 
        printfn "!!!!"
        0
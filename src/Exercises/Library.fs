namespace Exercises

module Say =
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

    let fn x b =
        (if x
        then 
            1
        else b)
        + 7  
    let fn2 x = 
        for i in 1..2..10 do
            printfn $"{i}"

        for i in str_arr do
            printfn $"{i}"

        let  count = 0
        
        while count < 10 do
            let count = count + 1
            printfn $"{count}"

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




namespace Benchmarks

open BenchmarkDotNet.Running
open BenchmarkDotNet.Attributes

type SortsBenchmark() =
    
    static member ArrayLengths = [|10000..10000..100000|]
    //static member ArrayLengths = [|0..100..1000|]

    member this.Random = System.Random()
    
    [<ParamsSource("ArrayLengths")>]
    member val ArrayLength = 0 with get, set

    member val ArrayToSort = [|0.0|] with get, set

    [<IterationSetup>]
    member this.GetArrayToSort () = 
        this.ArrayToSort <- Array.init this.ArrayLength (fun _ -> this.Random.NextDouble()) 

    [<Benchmark>]
    member this.Benchmark () = Array.sort this.ArrayToSort

module main =
    [<EntryPoint>]
    let main argv =
        let benchmarks =
            BenchmarkSwitcher [| typeof<SortsBenchmark> |]

        benchmarks.Run argv |> ignore
        0
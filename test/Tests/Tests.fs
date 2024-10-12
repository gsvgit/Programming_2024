namespace Tests

open Xunit

type TestClass () =

    [<Fact>]
    member this.TestMethodPassing () =
        Assert.True(true);

    

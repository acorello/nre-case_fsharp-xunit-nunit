module Tests

open Xunit

type Person = { name: string }

let john = { name = "John" }

[<Fact>]
let ``My test`` () = Assert.Equal("John", john.name)

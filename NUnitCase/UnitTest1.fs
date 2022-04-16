module NUnitCase

open NUnit.Framework

type Person = { name: string }

let john = { name = "John" }

[<SetUp>]
let Setup () = ()

[<Test>]
let Test1 () = Assert.AreEqual("John", john.name)

open System

[<EntryPoint>]
let main argv =
    printfn "test"
    printfn "Hello World from F#!"
    let website = new System.Uri("http://www.sme.sk")
    printfn "Absolute path %s" website.AbsolutePath
    0 // return an integer exit code

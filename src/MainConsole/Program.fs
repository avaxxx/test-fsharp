open System

[<EntryPoint>]
let main argv =
    printfn "test"
    printfn "Hello World from F#!"
    let website = System.Uri "http://www.sme.sk"
    printfn "Absolute path %s" website.AbsolutePath

    let name = "Pavol"

    if (name = "hal")
        then printf "ha"
    else
        printf "not ha"

    let writeTextToDisk text =
        let path = System.IO.Path.GetTempFileName()
        System.IO.File.WriteAllText(path, text)
        path
    let createManyFiles() =
        writeTextToDisk "The quick brown fox jumped over the lazy dog"
        writeTextToDisk "The quick brown fox jumped over the lazy dog"
        writeTextToDisk "The quick brown fox jumped over the lazy dog"
    createManyFiles()

    let tupleTest = 
        let firstName = "Pavol"
        let lastName = "Decky"
        firstName, lastName

    let firstName, lastName = tupleTest
    
    printf "FirstName - %s" firstName
    printf "LastName - %s" lastName

    let processTuple (firstName:string, lastName:string) = 
        true

    let result = processTuple tupleTest

    let addNumbers arguments =
        let a, b = arguments
        a + b

    0 // return an integer exit code

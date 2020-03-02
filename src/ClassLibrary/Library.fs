namespace ClassLibrary
open System.Runtime.Loader
open System

type Person = { FirstName:string; LastName:string }

type PaymentType =
    | Cash
    | Check of checkNumber:int
    | CreditCard of cardNumber:string * expiration:string
module Say =


    let hello name =
        printfn "Hello %s" name
    
    let pavol = {FirstName = "Pavol"; LastName = "Decky"}

    let peter = {pavol with FirstName = "Peter"}

    let cash = Cash
    let check = Check 150


    let tryParseDateTime (input:string) =
        let (success, result) = DateTime.TryParse input
        if success then Some result
        else None
    
    let tryParseDateTime2 (input: string) =
        match DateTime.TryParse input with
        | true, result -> Some result
        | _ -> None

    let website = System.Uri "http://www.sme.sk"

module TryScope =
    let globalvar = 10
    let fn input = 
        let output = input + globalvar
        output
    let test = globalvar
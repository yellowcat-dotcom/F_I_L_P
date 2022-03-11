open System

let rec f7 n f init = 
    if n = 0 then init 
    else 
        let cifr = n % 10
        let n1 = n / 10
        let acc = f init cifr
        f7 n1 f acc

[<EntryPoint>]
let main argv =
    System.Console.WriteLine(f7 157 (fun x y -> x * y) 1)
    0 

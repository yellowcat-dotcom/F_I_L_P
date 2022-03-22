open System

let Sdvig list n=
    let rec R list newList init =
        match list with
        |[]->newList
        |h::t->
              match init with
              |1-> 
                 let newList1= [h]@newList
                 let newI=init-1
                 R t newList1 newI
              |_->
                 let newI=init-1
                 let newList1= newList@[h]
                 R t newList1 newI
    R list [] n

[<EntryPoint>]
let main argv =
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    let l=Program.readList n
    Sdvig l n |> Program.writeList|>ignore    
    0 
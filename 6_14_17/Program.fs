open System
//Поиск максимума
let max list = 
    let rec max1 list maximum =
        match list with
        |[] -> maximum
        |h::t -> 
                let new_maximum = if h > maximum then h else maximum
                let new_list = t
                max1 new_list new_maximum
    max1 list list.Head
 
let rec NewList list min max = 
    match list with
    |[] -> []
    |h::t->
        if h=max then min::(NewList t min max) 
        else 
            if h=min then max::(NewList t min max)
            else h::(NewList t min max)
 
[<EntryPoint>]
let main argv =
    let l = Program.readData
    let minimum = Program.min l
    let maximum = max l 
    System.Console.WriteLine("Минимум: {0}   Максимум: {1}", minimum, maximum)
    NewList l minimum maximum |> Program.writeList |>ignore    
    0 

open System

//список индексов минимумов
let min_in list min =
    let rec min_in1 list min min_i =
        match list with
        |[]-> []
        |(h:int)::t ->
            let new_ind = min_i + 1
            if h = min then  new_ind::(min_in1 t min new_ind) else min_in1 t min new_ind
    min_in1 list min 0 
 
 //считает количество элементов между минимумами
let vichet list = 
    let rec v list perviy elem= 
        match list with
        |[] -> elem - perviy - 1
        |h::t -> 
            let new_elem = h
            v t perviy new_elem
    v list list.Head list.Head

[<EntryPoint>]
let main argv =
    
    let l = Program.readData
    let m = Program.min l    ///найду минимум
    let a = min_in l m // список с индексами минимумов
    //Program.writeList a |>ignore
    //result|>Program.writeList|>ignore
    min_in l m |> vichet |> Console.WriteLine
    0
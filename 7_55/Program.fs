// Для введенного списка построить новый список, который получен из начального упорядочиванием по количеству встречаемости элемента,
//То есть из списка [5,6,2,2,3,3,3,5,5,5] необходимо получить список [5,5,5,5,3,3,3,2,2,6].
open System

let sortByCount l = List.sortBy(fun x -> -(List.filter(fun v -> x=v) l).Length) l

[<EntryPoint>]
let main argv =
    let l = Program.readData
    sortByCount l |> Program.writelist |>ignore 
    0 

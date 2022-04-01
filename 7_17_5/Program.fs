// Для введенного списка построить список из элементов, 
//для которых в данном списке встречаются все простые делители.
open System
//проверка на простату kol_del=2 => число простое
let kol_del x =
    let rec kol_del1 x del kol =
        if del = 0 then kol
        else
            let new_sum = if x % del = 0 then kol + 1 else kol
            let new_del = del - 1
            kol_del1 x new_del new_sum
    kol_del1 x x 0

[<EntryPoint>]
let main argv =
    let l=Program.readData
    //List.distinct-позволяет cтроить список без повторений элементов
    let prostoy_l = List.distinct(List.filter (fun x -> kol_del x = 2) l)
    //List.scan (fun x y -> x * y) 0 prostoy_l

    Program.writelist prostoy_l
    0 

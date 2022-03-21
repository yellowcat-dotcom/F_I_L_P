//  Для введенного списка положительных чисел построить список всех 
//положительных простых делителей элементов списка без повторений
open System

let prostoy x =
    let rec pr x sum del =
        if del = 0 then sum 
        else
            let new_sum = if x % del = 0 then (sum + 1) else sum
            let new_del =del-1 
            pr x new_sum new_del
    pr x 0 x

    //Cтроит список из простых делителей числа
let rec Sp list =
    match list with
    |[]->[]
    |h::t ->
        let rec ig h del =
            if del = 0 then Sp t
            else 
                let new_del = del-1
                if h % del =0 && prostoy del = 2 then del::(ig h new_del)                        
                else ig h new_del                              
        ig h h
            
//считает сколько раз элемент находился в списке
let S list chislo =
    let rec kk list sum chislo =
        match list with
        |[]->sum
        |h::t -> 
            let new_sum = if h = chislo then sum + 1 else sum
            kk t new_sum chislo
    kk list 0 chislo

let rec NS list =
    match list with
    |[]->[]
    |h::t ->
        if S list h = 1 then h::(NS t)
        else NS t

[<EntryPoint>]
let main argv =
    let l = Program.readData
    S l 4 |> Console.WriteLine
    System.Console.WriteLine("Новый список:")
    Sp l |> NS |> Program.writeList|>ignore

    0 

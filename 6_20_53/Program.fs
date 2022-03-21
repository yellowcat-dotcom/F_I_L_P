// Для введенного списка построить новый 
//с элементами, большими, чем среднее арифметическое списка, 
//но меньшими, чем его максимальное значение.
open System

let Max list= 
    let rec max list init =
        match list with
        |[]->init
        |h::t -> 
            let new_init = if h>init then h else init
            max t new_init 
    max list list.Head

let rec Spisok list sr m = 
    match list with
    |[] -> []
    |h::t -> 
        if h>sr && h<m then h::(Spisok t sr m) else Spisok t sr m

[<EntryPoint>]
let main argv =
    let l =Program.readData
    let sum = Program.ob l 0 (fun x y -> x + y)
    let kol = Program.ob l 0 (fun x y -> x+1)      
    let sred_ar = sum/kol
    let maximum = Max l
    System.Console.WriteLine("Сумма: {0}    Кол-во: {1}    Сред.ар: {2}    Максимум: {3}",sum, kol, sred_ar, maximum )
    Spisok l sred_ar maximum |> Program.writeList|>ignore
    0 

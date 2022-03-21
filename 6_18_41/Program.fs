// Дан целочисленный массив. Найти среднее арифметическое модулей его элементов.
open System

let rec ob list init f =
    match list with
    |[]->init
    |h::t -> 
        let new_init = f init h
        ob t new_init f    

[<EntryPoint>]
let main argv =
    let l = Program.readData
    let sum = ob l 0 (fun x y -> x + Math.Abs(y))
    let kol = ob l 0 (fun x y -> x+1)
    let r = sum/kol
    System.Console.WriteLine("Сумма: {0}    Кол-во:{1}   Среднее арифметическое модулей {2}", sum, kol, r)
    0 

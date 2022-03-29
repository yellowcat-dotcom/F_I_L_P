//Дан целочисленный массив и интервал a..b. Необходимо найти сумму элементов, значение которых попадает в этот интервал.
open System

[<EntryPoint>]
let main argv =
    let l = Program.readData
    System.Console.WriteLine("Введите индекс начала интервала")
    let index_a = Convert.ToInt32(Console.ReadLine())
    System.Console.WriteLine("Введите индекс конца интервала")
    let index_b = Convert.ToInt32(Console.ReadLine())
    let new_l = List.filter (fun x -> x > index_a && x < index_b) l    
    //Program.writelist new_l    
    let o = List.sum new_l
    System.Console.WriteLine("Сумма элементов, входящих в интервал {0}", o)
    0 
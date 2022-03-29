//1.25 Дан целочисленный массив и интервал a..b. Необходимо найти максимальный из элементов в этом интервале.
open System

[<EntryPoint>]
let main argv =
    let l = Program.readData
    System.Console.WriteLine("Введите индекс начала интервала")
    let index_a = Convert.ToInt32(Console.ReadLine())
    System.Console.WriteLine("Введите индекс конца интервала")
    let index_b = Convert.ToInt32(Console.ReadLine())
    let new_l = List.filter (fun x -> x > index_a && x < index_b) l
    //System.Console.WriteLine("spisok_otvet")
    //Program.writelist new_l
    let max_new_spisok = List.max new_l
    System.Console.WriteLine("otvet: {0}", max_new_spisok)

    0 
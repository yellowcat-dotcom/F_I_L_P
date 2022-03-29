open System
// Дано вещественное число R и массив вещественных чисел. Найти элемент массива, который наиболее близок к данному числу.
let new_spisok R l= List.map(fun (x:int)-> Math.Abs(x - R)) l
[<EntryPoint>]
let main argv =
    let l=Program.readData
    System.Console.WriteLine("Введите число R")
    let R = Convert.ToInt32(Console.ReadLine())
    //List.iter(fun x->printfn "%O" x) list  //List. iter-позволяет вызывать функцию для каждого элемента списка
    let n_l = new_spisok R l
    //System.Console.WriteLine("spisok")
    //Program.writelist n_l
    let min_n_l = List.min n_l //нашла минимальную разницу
    let ind_min_n_l = List.findIndex (fun x-> x = min_n_l) n_l
    //System.Console.WriteLine("index {0}", ind_min_n_l)
    let el_po_zad_index = List.item ind_min_n_l l //List.item - находит элемент по заанному индексу
    System.Console.WriteLine("el_po_zad_index {0}", el_po_zad_index)
    0 

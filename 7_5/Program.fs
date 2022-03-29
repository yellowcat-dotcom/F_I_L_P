open System

//Дан целочисленный массив и натуральный индекс (число, меньшее размера массива). 
//Необходимо определить является ли элемент по указанному индексу глобальным минимумом.

let rec readList n =
    System.Console.WriteLine("Введите элементы")
    List.init(n) (fun index->Console.ReadLine()|>Int32.Parse)

let readData = 
    System.Console.WriteLine("Введите кол-во элементов")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    readList n

let rec writelist list=
    List.iter(fun x->printfn "%O" x) list  //List. iter-позволяет вызывать функцию для каждого элемента списка

[<EntryPoint>]
let main argv =
    let l=readData
    System.Console.WriteLine("Введите индекс")
    let index = Convert.ToInt32(Console.ReadLine())
    let min_el = List.min l //нашли минимум
    let el_po_zad_index = List.item index l //List.item - находит элемент по заанному индексу
    if min_el = el_po_zad_index then System.Console.WriteLine("Является") else System.Console.WriteLine("Не является")    
    0 

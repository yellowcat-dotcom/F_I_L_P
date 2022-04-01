// 5. Напишите программу, которая вводит с клавиатуры два непустых массива целых чисел в диапазоне от нуля до девяти,
//и, считая эти массивы десятичным представлением двух чисел, печатает их разность.

open System

let readArray n =
    let rec readArray1 n arr = 
        if n = 0 then
            arr
        else
            let tail = System.Console.ReadLine() |> Int32.Parse
            let new_arr = Array.append arr [|tail|]
            let n1 = n - 1
            readArray1 n1 new_arr

    readArray1 n Array.empty

let writeArray arr =
    printfn "%A" arr



[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Кол-во элементов в массиве 1:")
    let n1 = Console.ReadLine() |>Int32.Parse
    System.Console.WriteLine("Массив 1:")
    let arr1 = readArray n1
    System.Console.WriteLine("Кол-во элементов в массиве 2:")
    let n2 = Console.ReadLine() |> Int32.Parse
    System.Console.WriteLine("Массив 2:")
    let arr2 = readArray n2
    0
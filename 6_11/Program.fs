open System
let rec readList n = 
    if n=0 then []
    else
    let Head = System.Convert.ToInt32(System.Console.ReadLine())
    let Tail = readList (n-1)
    Head::Tail
 
let readData = 
    Console.WriteLine("Введите размерность списка:  ")
    let n=System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Введите элементы списка: ")
    readList n

let rec writeList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.WriteLine(head)
                       writeList tail  

//добавление элементом, чтобы размерность списка стала кратной трем
let dobavlenie list = 
    if List.length list % 3=0 then list
    else 
        if List.length list % 3=1 then list @ [1] @ [1]
        else list @ [1]

let Sum f list =
    let rec Sum1 list f newList = 
        match list with
        |[]->newList
        |h::tail->
            let h2 = tail.Head
            let h3 = tail.Tail.Head
            let newEl = f h h2 h3
            let NextList = newList @ [newEl]
            Sum1 tail.Tail.Tail f NextList
    Sum1 list f []

[<EntryPoint>]
let main argv =
    let l = readData
    dobavlenie l|> Sum (fun x y z-> x+y+z) |> writeList|>ignore
    0

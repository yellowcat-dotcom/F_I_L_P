
open System

let rec writeList = function
    [] ->   let z = System.Console.ReadKey()
            0
    | (head : int)::tail -> 
                       System.Console.WriteLine(head)
                       writeList tail
// Перемешать символы в слове, кроме первого и последнего
let F1 str =
    let len = String.length str
    if len <= 3 then str
    else
        let rnd = System.Random()
        let order = [0 .. len-1]
        let transposition = (List.sortBy(fun _ -> rnd.Next(0, len-1)) order)
        String.init len (fun idx -> str.[transposition.[idx]].ToString())
   

let F2 str =
    let rec F21 (str:string) (natchalo:int) (konets:int) (kol:int) (f:bool)=
        if kol = (String.length str-1) then if f= true then ("Является") else ("Не является")
        else
            if str.[natchalo] = str.[konets] then
                let nn = natchalo+1
                let kk = konets-1
                let kolkol = kol+1
                F21 str nn kk kolkol f            
            else 
                let new_f = false
                let nn = natchalo+1
                let kk = konets-1
                let kolkol = kol+1
                F21 str nn kk kolkol new_f
    F21 str 0 (String.length str-1) 0 true

//поиск ближайшего пробела
let findSpaceIndex s =
    let rec findSpaceIndex_inside s ind symbol= 
        match s with
        |""|" " -> ind + 1 
        |_->
            match symbol with
            |' ' -> ind
            |_ ->
                let newInd = ind + 1
                let newSymbol = s.[0]
                let newS = s.[1..String.length s]
                findSpaceIndex_inside newS newInd newSymbol
    findSpaceIndex_inside s 0 'a'

//разбиение строки на слова
let split (s:string) =
    let rec cutWords (s:string) (words : 'string list) = 
        match s with
        |""-> words
        |_->
            let newWord = s.[0..(findSpaceIndex s-2)]
            let newS = s.[(findSpaceIndex s) .. String.length s]
            cutWords newS (words@[newWord])
    cutWords s []


//let sort l =List.sortBy(fun x -> x.Length()) l

//let F3 str =
    //let a = split str

  
let menu = function    
    | 1 -> F1 
    | 2 -> F2
    //| 3 -> F3  

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите строку: ")
    let str = Console.ReadLine()
    (*System.Console.WriteLine("Введите номер задачи:
    1)Перемешивание символов в случайном порядке
    2)Проверка на палиндром
    3)Упорядочивание по колличеству букв в слове")
    Console.ReadLine()|> Int32.Parse |> menu <|str|> printfn "Результат: %s" *)
    let a = split str
   // let b = sortByCount a
    printfn "%A" (b)
    
    0 

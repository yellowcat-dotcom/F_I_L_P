
open System

// Перемешать символы в слове, кроме первого и последнего
let F1 str =
    let len = String.length str
    if len <= 3 then str
    else
        let rnd = System.Random()
        let order = [0 .. len-1]
        let transposition = (List.sortBy(fun _ -> rnd.Next(0, len-1)) order)
        String.init len (fun idx -> str.[transposition.[idx]].ToString())
   
(*let R f =
    if f = true then let (t:string) ="Является полиндромом" 
        else let (t:string) ="Не является полиндромом"*)

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


//let F3 str =
  
let menu = function    
    | 1 -> F1 
    | 2 -> F2
   // | 3 -> F3
    |_ -> F1 


[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите строку: ")
    let str = Console.ReadLine()
    System.Console.WriteLine("Введите номер задачи:
    1)Перемешивание символов в случайном порядке
    2)Проверка на палиндром
    3)Упорядочивание по колличеству букв в слове")
    Console.ReadLine()|> Int32.Parse |> menu <|str|> printfn "Результат: %s"
    
    //let n_s = F1 str
    //System.Console.WriteLine(n_s)
    0 

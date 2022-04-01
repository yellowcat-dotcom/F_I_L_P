
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
   



//let F3 str =
  
let menu (n:int) (str:string) = 
    match n with
    | 1 -> F1 str
    | 2 -> F2 str
   // | 3 -> F3
    |_ -> F1 str


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

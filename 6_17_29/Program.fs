open System

let Proverka (a,b) max =
        if max >a && max<b then true else false

[<EntryPoint>]
let main argv =
    let l=Program.readData
    Console.WriteLine("Введите границы интервала")
    let interval = (Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine()))
    let max= Program.max l 
    System.Console.WriteLine(Proverka interval max)
    0 // return an integer exit code
   
    

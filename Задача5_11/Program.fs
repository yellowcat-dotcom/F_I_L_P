﻿open System

let Otvet k =    
    match k with 
    |1|2 -> System.Console.WriteLine("Поздравляю, Вы - подлиза!")
    | _ ->System.Console.WriteLine("Как можно не любить F#!? Чел, ну это кринж, конечно...")
[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Какой ваш любимый язык программирования?
    1 F#
    2 Prolog
    3 C#
    4 C++")
    let k=System.Convert.ToInt32(System.Console.ReadLine())
    Otvet k 
    0 
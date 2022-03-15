open System

let obxod x F chetchik =
    let rec obxod1 x F chetchik del =
        if del=0 then chetchik
        else    
            let new_chetchik = if x % del = 0 then F chetchik del else chetchik
            let new_del= del - 1
            obxod1 x F new_chetchik new_del
    obxod1 x F chetchik x

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число:")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    let Otvet = obxod x (fun x y -> x*y) 1
    Console.Write("Ответ: {0}", Otvet) 
    0 

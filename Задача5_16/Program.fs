open System

let rec F1 a b =    //НОД
    if a=b then a
    else 
        if a>b then F1 (a-b) b 
        else F1 a (b-a) 

let obxod x F init =
    let rec obxod1 x F init chislo =
        if chislo=0 then init
        else 
            let new_init = if (F1 x chislo) =1 then F init chislo else init
            let new_chislo= chislo - 1
            obxod1 x F new_init new_chislo
    obxod1 x F init x

let Eler x F init =
    let rec Eler1 x F init chislo =
        if chislo=0 then init
        else 
            let new_init = if (F1 x chislo) =1 then F init else init
            let new_chislo= chislo - 1
            Eler1 x F new_init new_chislo
    Eler1 x F init x          

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Произведение:{0}", obxod x (fun x y -> x*y) 1)
    System.Console.WriteLine("Сумма:{0}", obxod x (fun x y -> x+y) 0)
    System.Console.WriteLine("Числа Эйлера:{0}", Eler x (fun x -> x+1) 0)
    0 
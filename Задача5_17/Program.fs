open System

let rec F1 a b =    //НОД
    if a=b then a
    else 
        if a>b then F1 (a-b) b 
        else F1 a (b-a) 

let obxod x F init p =
    let rec obxod1 x F init chislo =
        if chislo=0 then init
        else 
            let new_init = if (F1 x chislo) =1 && p chislo then F init chislo else init
            let new_chislo= chislo - 1
            obxod1 x F new_init new_chislo
    obxod1 x F init x

let obxod_Del x p F init =
    let rec obxod_Del_1 x  F init chislo =
        if chislo=0 then init
        else 
            let new_init = if x%chislo=0 && p chislo then F init chislo else init
            let new_chislo= chislo - 1
            obxod_Del_1 x F new_init new_chislo
    obxod_Del_1 x F init x          

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Произведение нечетных делителей числа:{0}", obxod_Del x (fun x -> x%2=1) (fun x y -> x*y) 1)
    System.Console.WriteLine("Произведение четных делителей числа:{0}", obxod_Del x (fun x -> x%2=0) (fun x y -> x*y) 1)
    System.Console.WriteLine("Сумма четных чисел, простых с {0}:{1}", x,  obxod x (fun x y -> x+y) 0 (fun x -> x%2=0)) 
    System.Console.WriteLine("Сумма нечетных чисел, простых с {0}:{1}", x,  obxod x (fun x y -> x+y) 0 (fun x -> x%2=1)) 
    0 
open System
//Рекурсии вверх

//Произведение цифр
let rec pr_v x =
    if x = 0 then 1
    else (x % 10)*pr_v(x / 10)

 //Максимальная цифра
let rec max_v x =
    if x<10 then x
    else max (x % 10) (max_v (x/10))

    // Минимальная цифра
let rec min_v x =
    if x<10 then x
    else min (x % 10) (min_v (x/10))

    //Рекурсии вниз

    //Произведение цифр
let pr x =
    let rec pr1 x init =
        if x = 0 then init
        else 
            let p = x % 10
            let ost = x / 10
            let proizvedenie = p* init 
            pr1 ost proizvedenie 
    pr1 x 1

// Максимальная цифра

let max x =
    let rec max1 x init =
        if x=0 then init 
        else 
            let p = x % 10
            let new_max = if p> init then p else init
            let ost = x / 10                      
            max1 ost new_max
    max1 x (x % 10)      
    
    // Минимальная цифра
let min x =
    let rec min1 x init = 
        if x=0 then init
        else
            let p = x % 10
            let new_min = if p< init then p else init
            let ost = x / 10                      
            min1 ost new_min
    min1 x (x%10)               

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine("Рекцурсии вверх:")
    System.Console.WriteLine("Произведение:{0}", pr_v x)
    System.Console.WriteLine("Максимум:{0}", max_v x)
    System.Console.WriteLine("Минимум:{0}", min_v x)
    System.Console.WriteLine("Рекцурсии вниз:{0}")
    System.Console.WriteLine("Произведение:{0}", pr x)
    System.Console.WriteLine("Максимум:{0}", max x)
    System.Console.WriteLine("Минимум:{0}", min x)
    0 

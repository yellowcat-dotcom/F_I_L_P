open System
//Кол-во делителей числа не делящихся на 3
let m_1 x =
    let rec m_11 x del sum =
        if del = 0 then sum
        else         
            let new_sum = if x % del = 0 && del % 3 <> 0 then sum + 1 else sum
            let new_del = del - 1
            m_11 x new_del new_sum
    m_11 x x 0
 
//Минимальная нечетная цифра числа
let m_2 x =
    let rec m_22 x min =
        if x = 0  then min
        else 
            let tsifra = x % 10
            let new_x = x / 10
            let new_min = if tsifra < min && tsifra % 2 <> 0 then tsifra else min
            m_22 new_x new_min
    m_22 x 9

//Найти сумму всех делителей числа, взаимно простых с СУММОЙ ЦИФР числа и не взаимно простых с ПРОИЗВЕДЕНИЕМ ЦИФР ЧИСЛА
                                                     
      // сумма
let obxod_s x =
    let rec obxod_s1 x sum =
        if x = 0 then sum
        else             
            let new_x = x / 10
            let new_sum = sum + x % 10
            obxod_s1 new_x new_sum
    obxod_s1 x 0

       // произведение
let obxod_p x =
    let rec obxod_p1 x proizv =
        if x = 0 then proizv
        else             
            let new_x = x / 10
            let new_proizv = proizv * (x % 10)
            obxod_p1 new_x new_proizv
    obxod_p1 x 1

    //НОД
let rec F1 a b =   
    if a=b then a
    else 
        if a>b then F1 (a-b) b 
        else F1 a (b-a) 

     //Сумма делителей.......
let sum_del x =
    let rec sum_del1 x del sum =
        if del = 0 then sum
        else
            let new_sum = if x % del = 0 && (F1 del (obxod_s x)) = 1 && (F1 del (obxod_p x))<> 1 then sum + 1 else sum
            let new_del = del - 1
            sum_del1 x new_del new_sum
    sum_del1 x x 0

let menu b c =
    match b with 
    | 1-> m_1 c
    | 2-> m_2 c
    | _-> sum_del c    
    
[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите два числа: номер команды и аргумент")
    let x = (Console.ReadLine() |> Int32.Parse, Console.ReadLine() |> Int32.Parse)
    let b = (fst x)
    let c = (snd x)    
    let result = menu b c
    System.Console.WriteLine(result)  
    0
     
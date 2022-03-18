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

[<EntryPoint>]
let main argv =
    System.Console.WriteLine("Введите число")
    let x = System.Convert.ToInt32(System.Console.ReadLine())
    Console.WriteLine("Кол-во делителей числа {0}, не делящихся на 3: {1}", x, m_1 x)
    0 

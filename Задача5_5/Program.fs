open System
//хвосттовая рекурсия
let sumCifr n = 
    let rec sumCifr1 n curSum = 
        if n = 0 then curSum
        else
            let n1 = n / 10
            let cifr = n % 10
            let newSum = curSum + cifr
            sumCifr1 n1 newSum
    sumCifr1 n 0

    //рекурсия вниз
let SUMcifr n =
    let rec SUMcifr1 acc n =
        if (n=0) then acc
        else SUMcifr1 (acc+n%10) (n/10)
    SUMcifr1 0 n


[<EntryPoint>]
let main argv =
    let a=System.Convert.ToInt32(System.Console.ReadLine())
    let o_1=sumCifr a
    let O_2=SUMcifr a
    System.Console.WriteLine(o_1)
    System.Console.WriteLine(O_2)
    0 

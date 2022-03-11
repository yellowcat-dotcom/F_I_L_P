open System
let sumCifr n = 
    let rec sumCifr1 n curSum = 
        if n = 0 then curSum
        else
            let n1 = n / 10
            let cifr = n % 10
            let newSum = curSum + cifr
            sumCifr1 n1 newSum
    sumCifr1 n 0

let fact n = 
    let rec fact1 n curFact = 
        match n with 
        |0 -> curFact
        | _ -> 
                let n1 = n - 1
                let newFact = curFact * n
                fact1 n1 newFact
    if n < 0 then 0
    else fact1 n 1

let f6 = function
    true -> sumCifr
    | false -> fact

let proverka_chisla n k=
    if n>0 then f6 k n
    else 0

[<EntryPoint>]
let main argv =
    System.Console.WriteLine((proverka_chisla 123 true, proverka_chisla 10 false, proverka_chisla -3 true))
    0 

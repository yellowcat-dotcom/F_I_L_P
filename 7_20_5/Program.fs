open System
let metod1 arrStr =
    let rateInAlp = [|8.17; 8.17; 1.49; 2.78; 4.25; 12.70; 2.23; 2.02; 6.09; 6.97; 0.15; 0.77; 4.03; 2.41; 6.75; 7.51; 1.93; 0.10; 5.99; 6.33; 9.06; 2.76; 0.98; 2.36; 0.15; 1.97; 0.07|]
    let KvOtkl str =
        let rec ChastSimv (str:string) ind (count:int) (letter:char)=
            if (ind = str.Length) then letter
            else
                let kol_voSimv = (String.filter (fun c -> c = str.[ind]) str).Length
                if (kol_voSimv > count) then ChastSimv str (ind+1) kol_voSimv str.[ind]
                else ChastSimv str (ind+1) count letter
        
        let mostChastSimv = ChastSimv str 0 0 ' '
        let chastotaSamoyChastoySimv = 
            (((String.filter (fun c -> c = mostChastSimv) str).Length |> Convert.ToDouble) 
                / ( str.Length |> Convert.ToDouble))
            * 100.0

        let chastotaSamoyChastoySimvINalphavit = 
            if (Char.IsLower mostChastSimv) 
            then rateInAlp.[(Convert.ToInt32(mostChastSimv) - 97)]
            else rateInAlp.[(Convert.ToInt32(mostChastSimv) - 65)]

        (chastotaSamoyChastoySimvINalphavit-chastotaSamoyChastoySimv)*(chastotaSamoyChastoySimvINalphavit-chastotaSamoyChastoySimv)

    let OtklArr = Array.map (fun str -> KvOtkl str) arrStr
    Array.sort arrStr

let writeArray arr = 
    let rec w (arr : 'T [] ) (ind : int)=
        if (ind = arr.Length) then ()
        else
            let nextind = ind+1
            System.Console.WriteLine( arr.[ind] )
            w arr nextind
    w arr 0

let maxASCII (str:string) =
    let rec m index (count:int) =
        match index with
        | index when index >= str.Length - 1 -> count
        |_ ->
            let newCount = if (str.[index] |> Convert.ToInt32)  > count then (str.[index] |> Convert.ToInt32) else count
            let newIndex = index + 1
            m newIndex newCount
    m 0 ('A' |> Convert.ToInt32)
    
let sumRazn (str:string) =
    let rec s index index2 count =
        match index with
        | index when index2 <= index -> count
        |_ ->
            let newCount = (str.[index] |> Convert.ToInt32) - (str.[index2] |> Convert.ToInt32) + count
            let newIndex = index + 1
            let newIndex2 = index2 - 1
            s newIndex  newIndex2 newCount
    s 0 ((str.Length) - 1) 0

let metod2 list =
    Array.ofList(List.sortBy (fun (x:string) -> (maxASCII x - sumRazn x)*(maxASCII x - sumRazn x) ) list)


let z n str =
    let l= List.ofArray str
    match n with    
    | 1 -> writeArray (metod1 str)
    | _ -> writeArray (metod2 l) 

[<EntryPoint>]
let main argv =
    System.Console.WriteLine( "Введите количество строк: " )
    let num = System.Convert.ToInt32(System.Console.ReadLine())
    System.Console.WriteLine( "Введите строки: " )
    let arrOfStr = [| for i in 1..num -> System.Convert.ToString(System.Console.ReadLine()) |]
    System.Console.WriteLine( "Отсортировать строки в порядке увеливения квадратичного отклонения: 
    1)частоты встречаемости самого часто встречаемого в строке символа от частоты его встречаемости в текстах на этом алфавите
    2между наибольшим ASCII-кодом символа строки и разницы в ASCII-кодах пар зеркально расположенных символов строки (относительно ее середины)" )
    let n = System.Convert.ToInt32(System.Console.ReadLine())
    z n arrOfStr
    0
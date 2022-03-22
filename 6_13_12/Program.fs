open System

let Indmax list =
    let rec max1 list max max_indx indx =
        match list with
        | [] -> (max_indx, max)
        | h::t ->
            let new_max = if h > max then h else max
            let new_max_indx = if h > max then indx else max_indx
            let new_idx = indx + 1
            max1 t new_max new_max_indx new_idx
    max1 list list.Head 0 0

let Indmin list =
    let rec min1 list min min_indx indx =
        match list with
        | [] -> (min_indx, min)
        | h::t ->
            let new_min = if h < min then h else min
            let new_min_indx = if h < min then indx else min_indx
            let new_idx = indx + 1
            min1 t new_min new_min_indx new_idx
    min1 list list.[0] 0 0

let reverse list=
    let rec rev list new_list=
        match list with
        |[]->new_list
        |h::t->
            let newnew_list=[h] @ new_list
            rev t newnew_list
    rev list []

[<EntryPoint>]
let main argv =
   System.Console.WriteLine("Введите кол-во элементов")
   let n = Console.ReadLine()|> Int32.Parse
   System.Console.WriteLine("Введите элементы списка")
   let l = Program.readList n
   Console.WriteLine()
   let max=fst (Indmax l)
   let min= fst (Indmin l)
   let start=Math.Min(max,min)
   let endpoint=Math.Max(min,max)
   let piece=l.[start+1..endpoint-1]  
   l.[0..start]@ (reverse piece) @ l.[endpoint..n-1] |> Program.writeList|>ignore
   0 
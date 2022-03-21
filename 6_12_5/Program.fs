open System

//Поиск минимума в списке
let min list = 
    let rec min1 list minimum =
        match list with
        |[] -> minimum
        |h::t -> 
                let new_minimum = if h < minimum then h else minimum
                let new_list = t
                min1 new_list new_minimum
    min1 list list.Head

//является ли элемент по указанному ииндексу глобальным минимумом
let global_min list index m =
    let rec global_min1 list index m f=
        match list with
        |[] -> f
        |h::t ->
            if index <> 1 then
                let new_list = t
                let new_index = index - 1                
                global_min1 new_list new_index m f
            else
                if h = m then f = true
                else f=false
    global_min1 list index m true


[<EntryPoint>]
let main argv =    
    let l = Program.readData
    let igig = min l
    System.Console.WriteLine("Глобальный минимум: {0}",igig)
    System.Console.WriteLine("Введите индекс предпологаемого минимума")
    let x = System.Convert.ToInt32(System.Console.ReadLine()) 
    let otvet = global_min l x (min l) 
    System.Console.WriteLine(otvet)
    0 

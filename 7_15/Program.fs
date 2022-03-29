// Дан целочисленный массив и натуральный индекс (число, меньшее размера массива). 
//Необходимо определить является ли элемент по указанному индексу локальным минимумом.
open System

[<EntryPoint>]
let main argv =
    let l=Program.readData
    System.Console.WriteLine("Введите индекс")
    let index = Convert.ToInt32(Console.ReadLine())
    let index_do = index - 1
    //System.Console.WriteLine("index do {0}", index_do)
    let index_posle = index + 1
    //System.Console.WriteLine("index posle {0}", index_posle)
    let min_el = List.min l //нашли минимум
    let el_po_zad_index = List.item index l //List.item - находит элемент по заанному индексу
    let el_po_zad_index_do = List.item index_do l
    let el_po_zad_index_posle = List.item index_posle l
    if el_po_zad_index < el_po_zad_index_do && el_po_zad_index < el_po_zad_index_posle then System.Console.WriteLine("Является локальным минимумом") else System.Console.WriteLine("Не является локальным минимумом")
    0 

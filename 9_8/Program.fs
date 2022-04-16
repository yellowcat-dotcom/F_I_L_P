open System
open System.Windows.Forms
open System.Drawing

Application.EnableVisualStyles()
// Создание формы с заголовком "Работа с массивом"
let form = new Form(Text="Работа с массивом")
// Создание подписи для поля ввода
let label1 = new Label()
label1.Location<-new Point(100,25)
label1.Text<-"массив 1"
label1.Width<-60
label1.Height<-12
// Создание подписи для поля вывода
let label2 = new Label()
label2.Location<-new Point(100,70)
label2.Text<-" массив 2"
label2.Width<-60
label2.Height<-12
let label3 = new Label()
label3.Location<-new Point(100,110)
// Создание текстового поля для ввода информации
let txtA = new TextBox()
txtA.Location<-new Point(170,25)
txtA.Width<-100
txtA.Height<-25
txtA.Text<-""
// Создание текстового поля для вывода информации
let txtB = new TextBox()
txtB.Location<-new Point(170,70)
txtB.Width<-100
txtB.Height<-25
txtB.Text<-"" 
// Создание кнопка "Вычислить!"
let button = new Button(Text="Вычислить разность")
button.Location<-new Point(15,100) // позиция кнопки

let getArrayFromTextBox (txt: TextBox) =
    let str = txt.Text.Trim()
    if String.IsNullOrEmpty str then 
        [||]
    else
        let parts = str.Split(' ')
        Array.map (fun str -> Double.Parse str) parts

//Добавление обработчика события - Нажатие на кнопку
button.Click.AddHandler(fun _ _ ->
    let array1 = getArrayFromTextBox txtA
    let array2 = getArrayFromTextBox txtB
    let cislo1 = array1|> Array.reduce (fun a b -> a * 10.0 + b)
    let cislo2 = array2|> Array.reduce (fun a b -> a * 10.0 + b)
    let v = label3.Text <- (System.Convert.ToString(cislo1-cislo2))
    v
    |> ignore)
    
let exit = new Button(Text="Выход")
exit.Location<-new Point(200,100)
exit.Click.AddHandler(fun _ _-> form.Close())

//Добавление элементов на форму
form.Controls.Add(button)
form.Controls.Add(exit)
form.Controls.Add(label1)
form.Controls.Add(label2)
form.Controls.Add(label3)
form.Controls.Add(txtA)
form.Controls.Add(txtB)
// запуск формы
Application.Run(form)
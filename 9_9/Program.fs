open System
open System.Windows.Forms
open System.Drawing

Application.EnableVisualStyles()

let form = new Form(Width=302, Height=350,Text = "Работа со списками")
let vivod = new Button(Left=21, Top=38, Text="вывод списка", Width=96, Height=23)
let list1 = new TextBox(Left=156, Top=107, Width=114, Height=20)
let list2 = new TextBox(Left=156, Top=187, Width=114, Height=20)

form.Controls.Add(list1)
form.Controls.Add(list2)
form.Controls.Add(vivod)

let getListFromTextBox (txt: TextBox) =
    let str = txt.Text.Trim()
    if String.IsNullOrEmpty str then 
        []
    else
        let parts = str.Split(' ')
        List.ofArray parts |> List.map (fun x -> Int32.Parse x)


vivod.Click.AddHandler(
    fun _ _ ->
        let a = getListFromTextBox list1
        let b = List.skip 2 a 
        list2.Text <- System.Convert.ToString(b)
)
Application.Run(form)
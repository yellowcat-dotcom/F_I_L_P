open System.Drawing
open System.Windows.Forms

let F = function
    |(true, true) -> MessageBox.Show("установлены оба флажка", "Ответ") |> ignore
    |(true, false) -> MessageBox.Show("установлен первый флажок", "Ответ") |> ignore
    |(false, true) -> MessageBox.Show("установлен второй флажок", "Ответ") |> ignore
    |(false, false) -> MessageBox.Show("флажки не установлены", "Ответ") |> ignore

let form = new Form(Width= 200, Height = 200, Visible = true, Text = "Кортежи в F#")
let button1 = new Button(Text="Кнопка", Left=100, Top=100, Width=55, Height=50)
form.Controls.Add(button1)


let chekBox1 = new CheckBox(Left=40, Top=40, Width=20, Height=20)
form.Controls.Add(chekBox1)
let chekBox2 = new CheckBox(Left=130, Top=40, Width=20, Height=20)
form.Controls.Add(chekBox2)
let p _ = F (System.Convert.ToBoolean(chekBox1.CheckState),System.Convert.ToBoolean(chekBox2.CheckState))
let _ = button1.Click.Add(p)

do Application.Run(form)


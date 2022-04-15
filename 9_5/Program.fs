open System
open System.Drawing
open System.IO
open System.Windows.Forms

let buttons =
    let button1 = new Button(Text="Январь", Top=25, Width=100, Height=25)
    let button2 = new Button(Text="Февраль", Top=55, Width=100, Height=25)
    let button3 = new Button(Text="Март", Top=85, Width=100, Height=25)
    let button4 = new Button(Text="Апрель", Top=115, Width=100, Height=25)

    let button5 = new Button(Text="Май", Top=25, Left=130, Width=100, Height=25)
    let button6 = new Button(Text="Июнь", Top=55, Left=130, Width=100, Height=25)
    let button7 = new Button(Text="Июль", Top=85, Left=130, Width=100, Height=25)////
    let button8 = new Button(Text="Август", Top=115, Left=130, Width=100, Height=25)

    let button9 = new Button(Text="Сентябрь", Top=25, Left=260, Width=100, Height=25)
    let button10 = new Button(Text="Октябрь", Top=55, Left=260, Width=100, Height=25)
    let button11 = new Button(Text="Ноябрь", Top=85, Left=260, Width=100, Height=25)
    let button12 = new Button(Text="Декабрь", Top=115, Left=260, Width=100, Height=25)
    (button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12)

[<EntryPoint>]
let main argv =
    let Form1 = new Form(Text = "Определитель времен года" ,Width = 400, Height = 300)
    let button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12 = buttons
    Form1.Controls.Add(button1)
    Form1.Controls.Add(button2)
    Form1.Controls.Add(button3)
    Form1.Controls.Add(button4)
    Form1.Controls.Add(button5)
    Form1.Controls.Add(button6)
    Form1.Controls.Add(button7)
    Form1.Controls.Add(button8)
    Form1.Controls.Add(button9)
    Form1.Controls.Add(button10)
    Form1.Controls.Add(button11)
    Form1.Controls.Add(button12)  
    let winter _ = MessageBox.Show("Зима", "Время года:") |> ignore  
    let spring _ = MessageBox.Show("Весна", "Время года:") |> ignore  
    let summer _ = MessageBox.Show("Лето", "Время года:") |> ignore
    let autumn _ = MessageBox.Show("Осень", "Время года:") |> ignore     
    let _ = button1.Click.Add(winter)
    let _ = button2.Click.Add(winter)
    let _ = button12.Click.Add(winter)
    let _ = button3.Click.Add(spring)
    let _ = button4.Click.Add(spring)
    let _ = button5.Click.Add(spring)
    let _ = button6.Click.Add(summer)
    let _ = button7.Click.Add(summer)
    let _ = button8.Click.Add(summer)
    let _ = button9.Click.Add(autumn)
    let _ = button10.Click.Add(autumn)
    let _ = button11.Click.Add(autumn)
    do Application.Run(Form1)   
    0

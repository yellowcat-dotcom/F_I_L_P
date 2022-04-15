open System
open System.Windows
open System.Windows.Controls
open System.Windows.Markup

let mwXaml = """
<Window 
xmlns='http://schemas.microsoft.com/winfx/2006/xaml/presentation'
 xmlns:x='http://schemas.microsoft.com/winfx/2006/xaml'
 xmlns:d='http://schemas.microsoft.com/expression/blend/2008' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' mc:Ignorable='d'
 Title='Определитель времени года' Height='400' Width='400'>
    <Grid Height='300' VerticalAlignment='Top'>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width='3*' />
            <ColumnDefinition Width='0*'/>
            <ColumnDefinition Width='0*'/>
            <ColumnDefinition Width='41*'/>
            <ColumnDefinition Width='0' />
            <ColumnDefinition Width='0'/>
            <ColumnDefinition Width='211'/>
        </Grid.ColumnDefinitions>
        <GroupBox Header='Времена года&#xD;&#xA;' Height='300' HorizontalAlignment='Left' x:Name='groupBox2' VerticalAlignment='Top' Width='350' Grid.ColumnSpan='7'>
        <Button Content='Выход' Height='23' HorizontalAlignment='Left' Margin='200,220,-2,0' x:Name='exit' VerticalAlignment='Top' Width='90' /> 
        </GroupBox>       
        <Button Content='Январь' Height='23' HorizontalAlignment='Left' Margin='0,30,0,0' x:Name='january' VerticalAlignment='Top' Width='70' Grid.Column='3' FontSize='14' />
        <Button Content='Февраль' Height='23' HorizontalAlignment='Left' Margin='0,60,0,0' x:Name='february' VerticalAlignment='Top' Width='70' Grid.Column='3' FontSize='14'/>
        <Button Content='Март' Height='23' HorizontalAlignment='Left' Margin='0,90,0,0' x:Name='march' VerticalAlignment='Top' Width='70' Grid.Column='3' FontSize='14'/>
        <Button Content='Апрель' Height='23' HorizontalAlignment='Left' Margin='0,120,0,0' x:Name='april' VerticalAlignment='Top' Width='70' Grid.Column='3' FontSize='14'/>
        <Button Content='Май' Height='23' HorizontalAlignment='Left' Margin='0,150,0,0' x:Name='may' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Июнь' Height='23' HorizontalAlignment='Left' Margin='0,180,0,0' x:Name='june' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>

        <Button Content='Июль' Height='23' HorizontalAlignment='Left' Margin='90,30,0,0' x:Name='july' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Август' Height='23' HorizontalAlignment='Left' Margin='90,60,0,0' x:Name='august' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Сентябрь' Height='23' HorizontalAlignment='Left' Margin='90,90,0,0' x:Name='september' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Октябрь' Height='23' HorizontalAlignment='Left' Margin='90,120,0,0' x:Name='october' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Ноябрь' Height='23' HorizontalAlignment='Left' Margin='90,150,0,0' x:Name='november' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
        <Button Content='Декабрь' Height='23' HorizontalAlignment='Left' Margin='90,180,0,0' x:Name='december' VerticalAlignment='Top' Width='70'  Grid.Column='3' FontSize='14'/>
    </Grid>
</Window>
"""

let getWindow(mwXaml) =
    let xamlObj=XamlReader.Parse(mwXaml)
    xamlObj :?> Window

let win = getWindow(mwXaml)

let january = win.FindName("january") :?> Button
let february = win.FindName("february") :?> Button
let march = win.FindName("march") :?> Button
let april = win.FindName("april") :?> Button
let may = win.FindName("may") :?> Button
let june = win.FindName("june") :?> Button
let july = win.FindName("july") :?> Button
let august = win.FindName("august") :?> Button
let september = win.FindName("september") :?> Button
let october = win.FindName("october") :?> Button
let november = win.FindName("november") :?> Button
let december = win.FindName("december") :?> Button
let exit = win.FindName("exit") :?> Button

let winter _ = MessageBox.Show("Зима", "Время года:") |> ignore  
let spring _ = MessageBox.Show("Весна", "Время года:") |> ignore  
let summer _ = MessageBox.Show("Лето", "Время года:") |> ignore
let autumn _ = MessageBox.Show("Осень", "Время года:") |> ignore 

let _ = january.Click.Add(winter)
let _ = february.Click.Add(winter)
let _ = december.Click.Add(winter)
let _ = march.Click.Add(spring)
let _ = april.Click.Add(spring)
let _ = may.Click.Add(spring)
let _ = june.Click.Add(summer)
let _ = july.Click.Add(summer)
let _ = august.Click.Add(summer)
let _ = september.Click.Add(autumn)
let _ = october.Click.Add(autumn)
let _ = november.Click.Add(autumn)

exit.Click.AddHandler(fun _ _ -> win.Close())

[<EntryPoint;STAThread>]
let main argv =
    ignore <| (new Application()).Run win
    0
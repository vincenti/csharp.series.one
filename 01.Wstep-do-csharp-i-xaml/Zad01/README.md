Wstęp do C# i XAML
==================
Zad1
----
```xaml
<Window x:Class="Zad01.MainWindow" xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        Title="Pierwszy program" Width="250" Height="150"
        Background="CadetBlue">
    <Grid>
        <Button x:Name="Przycisk" Width="80" Height="40"
                HorizontalAlignment="Center" VerticalAlignment="Center" Click="PokazKomunikat"
                Content="Komunikat" />
    </Grid>
</Window>
```
Właściwość Content
------------------
Pozwala na przypiszanie dowolnej zawartości do danej kontrolki.

Sposób 1
```xaml
<Button Content="Treść przycisku" />
```
Sposób 2
```xaml
<Button>
	<Button Content="Przycisk w przycisku" />
</Button>
```
Wł: Height, MinHeight, MaxHeight, Width, MinWitdth, MaxWidth
------------------------------------------------------------
Bardzo wygodne rozwiązanie przy skalowaniu aplikacji. Pozwala w sposób dynamiczny przystosować kontent do wymiarów okna.
```xaml
<Button MinHeight="200" MaxHeight="600" />
```
Wł: Background
--------------
Większość kontrolek posiada właściwość pozwalająca na ustawienie tła.
```xaml
<Window Background="CadetBlue" />
```
Wł: HorizontalAlignment i VerticalAlignment
--------------
Pozwalają na wyrównywane obiektu wzgłedem rodzina (przycisk względem okna)
! Wartość właściowości Stretch pozwala na rozciągnięcie obiektu
```xaml
<Button HorizontalAlignment="Center" VerticalAlignment="Center" />
```
<Window />
----------
Główny kontener naszego okna 
Przykładowe właściwości:
- Title - Tytuł
- Height - Wysokość
- Width - Szerokość
- Background - Tło
# <Button />
Pospolity przycisk, pozwalający na wykonywanie czynności przy wystąpieniu odpowiedniego zdarzenia.
Najbardziej znanym zdarzeniem jest zdarzenie Click.

Pzykład
```xaml
<Button Click="NazwaMetody" />
```
Obsługa klinięcia po stronie "code behind".
W klasie okna MainWindow.xaml.cs tworzymy metode typu void pasująca pod sygnature kliknięcia.
	
Sender to obiekt na rzecz, którego zostało wykonane zdarzenie. Parametr e to argumenty tego zdarzenia.
	
Klasa MessageBox posiada statyczna metode Show wyświetlająca komunikat na podstawie swoich parametrów.
MessageBox.Show("param1-tresc", "param2-tytul");
```csharp
private void PokazKomunikat(object sender, RoutedEventArgs e)
{
    MessageBox.Show("Witaj świecie", "Pierwszy program");
}
```

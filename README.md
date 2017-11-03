# Vivrant.DatePicker
A CSS &amp; webkit DatePicker for CSHTML5 (http://cshtml5.com/)

# Credits
BASED ON "Pure CSS DatePicker" by Mahesh: https://codepen.io/maheshambure21/pen/VYJQYG

# Milestones:
**11-03-2017: Initial Release**

# Limitations:
    Input-Mask and Calendar popups DO NOT work in Simulator! (Simulator does not appear to support webkit calendar)

# Usage:

 - Add a reference to *Vivrant.DatePicker.dll*
 
 - Create a new XAML window or Control
 
 - Add a XAML Namespace for the control: 
 
    `xmlns:control="clr-namespace:Vivrant.Controls"`
    
 - (OPTIONAL) Use the included DatePresenter class for out-of-the-box MVVM support: 
 
    `xmlns:presenter="clr-namespace:Vivrant.Presenter;assembly=Vivrant.DatePicker"`
    
 - Add the the following to your window or Control (this can replace any existing Canvas or Grid objects)
 
`<control:DatePicker
    Margin="16"
    VerticalAlignment="Top"
    HorizontalAlignment="Center"
    DateValue="{Binding Path=Date, Mode=TwoWay}">
    <control:DatePicker.DataContext>
        <presenter:DatePresenter />
    </control:DatePicker.DataContext>
</control:DatePicker>`

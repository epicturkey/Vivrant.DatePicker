# Vivrant.DatePicker
A NATIVE CSS &amp; webkit DatePicker for CSHTML5 (http://cshtml5.com/)

This uses the input[type=date] (-webkit-datepicker), as defined by Moz MDN Web Docs: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date

# Credits
BASED ON "Pure CSS DatePicker" by Mahesh: https://codepen.io/maheshambure21/pen/VYJQYG

# Milestones:
**11-03-2017: Initial Release**
Tested against CSHTML5 BETA 12.4

# Limitations:
- Input-Mask and Calendar popups DO NOT work in Simulator! (Simulator does not appear to support webkit calendar)
- Works in **Microsoft Edge**, **Google Chrome**, **Opera**, **Chrome on Android** and **Firefox BETA** *
- Does not work in Firefox Public Release or IE11 (Firefox* and IE have not yet implemented the -webkit-calendarpicker appearance on input[type=date])
* Firefox is working to implement inputType=date, but it is currently only supported in the current Firefox BETA, available here: https://www.mozilla.org/en-US/firefox/quantum/. You must download the latest Nightly BETA from Mozilla. For more information on Mozilla Firefox's adaption of the -webkit-datepicker, please see Firefox Bug 825294 https://bugzilla.mozilla.org/show_bug.cgi?id=825294 and Firefox bug 888320 https://bugzilla.mozilla.org/show_bug.cgi?id=888320.

# Usage:

 - Add a reference to *Vivrant.DatePicker.dll*
 
 - Create a new XAML window or Control
 
 - Add a XAML Namespace for the control: 
 
    `xmlns:control="clr-namespace:Vivrant.Controls;assembly=Vivrant.DatePicker`
    
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

<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128633466/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2199)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsApplication1/Form1.cs)
* [Program.cs](./CS/WindowsApplication1/Program.cs)
<!-- default file list end -->
# How to show the NavPaneForm programmatically?


<p>When the "NavigationPane" view is applied, the NavBarControl can be collapsed to save space by clicking on a small arrow button within the control's caption. When collapsed, the NavBarControl still allows the contents of the active group to be displayed. To do this, an end-user can simply click the group's caption. Once clicked, the NavPane Form, which contains the active group's content, is displayed.</p>
<p><br />Starting with version 14.2, the required code is as simple as that:</p>


```cs
navBarControl1.ShowNavPaneForm(); 

```


<p> </p>
<p>So, for example, if you want to open the form when an active group changes (the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraNavBarNavBarControl_ActiveGroupChangedtopic">NavBarControl.ActiveGroupChanged</a>  event), the required code would be:</p>


```cs
private void navBarControl1_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
{
   if (navBarControl1.OptionsNavPane.NavPaneState ==NavPaneState.Collapsed)
      {
         navBarControl1.ShowNavPaneForm();
      }
}
 

```


<p> </p>
<p><br />For previous versions, the solution is a bit more complex because you need to access internal methods of our NavBarControl. You can do this using the reflection: </p>


```cs
        private void ShowActiveGroupPopup()
        {
            if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed)
            {
                NavBarViewInfo viewInfo = navBarControl1.GetViewInfo();
                var mi = viewInfo.GetType().GetMethod("DoContentButtonPress", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                mi.Invoke(viewInfo, null);
            }
        }
        void navBarControl1_ActiveGroupChanged(object sender, NavBarGroupEventArgs e)
        {
            if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed)
            {
                ShowActiveGroupPopup();
            }
        }




```


<p> </p>
<p> If you want to show the form even when the active group is clicked again, additionally handle the <strong>Click </strong>event:</p>


```cs
void navBarControl1_Click(object sender, EventArgs e)
        {
            var args = (MouseEventArgs)e;
            var hi = navBarControl1.CalcHitInfo(args.Location);
            if (hi.InGroupCaption && hi.Group == navBarControl1.ActiveGroup)
                ShowActiveGroupPopup();
        }
 

```


<p> </p>
<p><br /><br /></p>
<p><br /><br /><br /><br /></p>

<br/>



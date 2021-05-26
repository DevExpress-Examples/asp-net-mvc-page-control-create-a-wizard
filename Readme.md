# How to organize Wizard interface within PageControl Extension
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e3403/)**
<!-- run online end -->


<p>This example is the ASP.NET MVC implementation of the <a href="https://www.devexpress.com/Support/Center/p/E3050">How to organize Wizard interface within ASPxPageControl</a> example. It illustrates to organize the so-called wizard interface within the MVC PageControl Extension. It allows you to specify the predefined content of the wizard steps within the TabPages and switching between them via user interface (via clicking the TabPage's header) or programmatically (via API).<br /><br /><strong>Updated: <br /><br /></strong></p>
<p>Starting with v14.1 this example uses jQuery Unobtrusive validation. Please refer to <a href="https://documentation.devexpress.com/#AspNet/CustomDocument12060">Unobtrusive Client Validation</a> to learn more about it.</p>


<h3>Description</h3>

<p>The validation of TagPage's (step's) editors works in the following manner:</p>
<p>Clicking the "Finish" button (a complete wizard step) calls the "ValidateEditors" function and validate form's editors. This function searches TabPage that contains the first invalid editor via the "GetTabIndexWithInvalidaEditor" function. If all editors in all steps are valid, the form is submitted.</p>
<br>
<p>In some scenarios, it is necessary to allow a user to navigate between wizard steps via clicking step's by clicking the steps' headers and sometimes - via clicking "next" / "prev" buttons (steps' headers are hidden). To specify the TabPages' header visibility, manipulate the <a href="https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.PageControlSettings.ShowTabs"><u>PageControlSettings.ShowTabs</u></a> property.</p>
<br>
<p>The "Show Tabs" checkbox is used for demonstration purposes only. Clicking this checkbox forces submission of the entire form. The corresponding Controller's logic analyzes the checkbox's state and clears the Model's state to avoid server-side editor / Model validation.</p>

<br/>

<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/E3403/Controllers/HomeController.cs)
* [Global.asax](./CS/E3403/Global.asax)
* [Global.asax.cs](./CS/E3403/Global.asax.cs)
* [Account.cs](./CS/E3403/Models/Account.cs)
* [Index.cshtml](./CS/E3403/Views/Home/Index.cshtml)
* [_ContactPartial.cshtml](./CS/E3403/Views/Home/_ContactPartial.cshtml)
* [_DatePartial.cshtml](./CS/E3403/Views/Home/_DatePartial.cshtml)
* [_PersonalPartial.cshtml](./CS/E3403/Views/Home/_PersonalPartial.cshtml)
<!-- default file list end -->

#pragma checksum "C:\Users\Admin\source\repos\App1\App1\Pages\LoginPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "37CF7430287CED2DF47BFEB6B84672B4F2E73658802B06C8CE4CE3F8EDE70D43"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1.Pages
{
    partial class LoginPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Pages\LoginPage.xaml line 23
                {
                    this.txtFirstName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // Pages\LoginPage.xaml line 24
                {
                    this.txtLastName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Pages\LoginPage.xaml line 25
                {
                    this.txtPassword = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 5: // Pages\LoginPage.xaml line 26
                {
                    this.txtAddress = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // Pages\LoginPage.xaml line 27
                {
                    this.txtPhone = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // Pages\LoginPage.xaml line 28
                {
                    this.txtEmail = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // Pages\LoginPage.xaml line 29
                {
                    this.txtIntroduction = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9: // Pages\LoginPage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.HandleLogin;
                }
                break;
            case 10: // Pages\LoginPage.xaml line 31
                {
                    this.msgFirstName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11: // Pages\LoginPage.xaml line 32
                {
                    this.msgLastName = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12: // Pages\LoginPage.xaml line 33
                {
                    this.msgPwd = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 13: // Pages\LoginPage.xaml line 34
                {
                    this.msgPhone = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 14: // Pages\LoginPage.xaml line 35
                {
                    this.msgAddress = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 15: // Pages\LoginPage.xaml line 36
                {
                    this.msgEmail = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16: // Pages\LoginPage.xaml line 37
                {
                    this.msgBirthday = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17: // Pages\LoginPage.xaml line 38
                {
                    this.msgGender = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18: // Pages\LoginPage.xaml line 39
                {
                    this.msgIntroduct = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19: // Pages\LoginPage.xaml line 40
                {
                    this.txtAvatar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20: // Pages\LoginPage.xaml line 41
                {
                    this.msgAvatar = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 21: // Pages\LoginPage.xaml line 42
                {
                    this.Birthday = (global::Windows.UI.Xaml.Controls.DatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.DatePicker)this.Birthday).SelectedDateChanged += this.CheckDate;
                }
                break;
            case 22: // Pages\LoginPage.xaml line 17
                {
                    this.TopButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.TopButton).Checked += this.HandleCheck;
                }
                break;
            case 23: // Pages\LoginPage.xaml line 19
                {
                    this.MiddleButton = (global::Windows.UI.Xaml.Controls.RadioButton)(target);
                    ((global::Windows.UI.Xaml.Controls.RadioButton)this.MiddleButton).Checked += this.HandleCheck;
                }
                break;
            case 24: // Pages\LoginPage.xaml line 21
                {
                    this.choiceTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // Pages\LoginPage.xaml line 13
                {
                    this.txtBirthday = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}


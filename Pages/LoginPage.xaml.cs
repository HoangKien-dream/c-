using App1.Entity;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace App1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LoginPage : Page
    {
        private int checkedGender;
        private DateTime date;


        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void HandleLogin(object sender, RoutedEventArgs e)
        {
            var account = new Account();
            var beginName = txtFirstName.Text;
            var endName = txtLastName.Text;
            var password = txtPassword.Password.ToString();
            var address = txtAddress.Text;
            var phone = txtPhone.Text;
            var avatar = txtAvatar.Text;
            var email = txtEmail.Text;
            var introduction = txtIntroduction.Text;
            if (string.IsNullOrEmpty(beginName))
            {
                msgFirstName.Text = "Vui lòng nhập họ";
            }
            else
            {
                account.firstName = beginName;
                msgFirstName.Text = "";
            };
            if (string.IsNullOrEmpty(endName))
            {
                msgLastName.Text = "Vui lòng nhập tên";
            }
            else
            {
                account.lastName = endName;
                msgLastName.Text = "";
            };
            if (string.IsNullOrEmpty(password))
            {
                msgPwd.Text = "Vui lòng nhập mật khẩu";
            }
            else
            {
                account.password = password;
                msgPwd.Text = "";
            };
            if (string.IsNullOrEmpty(address))
            {
                msgAddress.Text = "Vui lòng nhập địa chỉ";
            }
            else
            {
                account.address = address;
                msgAddress.Text = "";
            };
            if (string.IsNullOrEmpty(phone))
            {
                msgPhone.Text = "Vui lòng nhập số điện thoại";
            }
            else
            {
                account.phone = phone;
                msgPhone.Text = "";
            };
            if (string.IsNullOrEmpty(avatar))
            {
                msgAvatar.Text = "Vui lòng nhập link ảnh";
            }
            else
            {
                account.avatar = avatar;
                msgAvatar.Text = "";
            };
            if (string.IsNullOrEmpty(email))
            {
                msgEmail.Text = "Vui lòng nhập địa chỉ email";
            }
            else
            {
                account.email = email;
                msgEmail.Text = "";
            };
            if (string.IsNullOrEmpty(introduction))
            {
                msgIntroduct.Text = "Vui lòng nhập thông tin giới thiệu";
            }
            else
            {
                account.Introduct = introduction;
                msgIntroduct.Text = "";
            };
            account.Gender = checkedGender;
            account.Birthday = date;
            if (account.firstName != null && account.lastName != null && account.email != null && account.address != null && account.phone != null && account.avatar != null && account.Introduct != null && account.Gender != 0)
            {
                var jsonString = JsonConvert.SerializeObject(account);
                Debug.WriteLine(jsonString);
            }

            //var account = new Account()
            //{
            //    firstName = beginName,
            //    lastName = endName,
            //    password = password,
            //    address = address,
            //    phone = phone,
            //    avatar = avatar,
            //    email = email,
            //    Introduct = introduction,
            //    Gender = checkedGender,
            //    Birthday = date
            //};



        }

        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            switch (rb.Tag)
            {
                case "Male":
                    checkedGender = 1;
                    break;
                case "Female":
                    checkedGender = 2;
                    break;
            }
        }
        private void CheckDate(DatePicker sender, DatePickerSelectedValueChangedEventArgs args)
        {
            date = new DateTime(args.NewDate.Value.Year, args.NewDate.Value.Month, args.NewDate.Value.Day);
            txtBirthday.Text = date.ToString();
        }
    }
}

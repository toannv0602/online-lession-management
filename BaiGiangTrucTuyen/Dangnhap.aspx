<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dangnhap.aspx.cs" Inherits="BaiGiangTrucTuyen.Login" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Login</title>
   <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="https://fonts.googleapis.com/css?family=Roboto:100,300,400,500,700" rel="stylesheet">

    <title>Pixie - Ecommerce HTML5 Template</title>

    <!-- Bootstrap core CSS -->
    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- Additional CSS Files -->
    <link rel="stylesheet" href="assets/css/fontawesome.css">
    <link rel="stylesheet" href="assets/css/tooplate-main.css">
    <link rel="stylesheet" href="assets/css/owl.css">
    <link rel="stylesheet" href="assets/css/LoginForm.css" />
</head>
<body>
    <form  runat="server">
        <body>
            <!-- Page Content -->
            <!-- Banner Starts Here -->
            <div class="banner-login">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="caption">
                                <form action="/" id="form1" method="post">
                                    <h2>Đăng Nhập Hệ Thống</h2>
                                    <div>
                                        <div>
                                             <a class="navbar-brand" href="#"><img id="logo2" src="assets/images/logo2.png" alt=""></a>
                                        </div>
                                        <span>Tên Đăng Nhập</span><asp:TextBox ID="txtUsername" runat="server" CssClass="textbox"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="username" runat="server" ErrorMessage="Tài khoản không được để trống" Display="Dynamic" ControlToValidate="txtUsername" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                    <div>
                                        <span>Mật Khẩu</span><asp:TextBox ID="txtPassWord" runat="server" CssClass="textbox" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="password" runat="server" ErrorMessage="Mật khẩu không được để trống" Display="Dynamic" ControlToValidate="txtPassWord" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"  HeaderText="Lỗi được tìm thấy:" ShowMessageBox="true" ShowSummary="false" />
                                    <asp:Button ID="btnSubmit" runat="server" Text="Đăng nhập" CssClass="btn btn-success" OnClick="btnSubmit_Click" />
                                </form>
                                
                                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                                <asp:UpdatePanel runat="server">
                                    <ContentTemplate>
                                        <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Tick1"></asp:Timer>
                                        <asp:Label ID="lbDemtg" runat="server" Text="Label"></asp:Label>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            </div>
    <!-- Banner Ends Here -->

            <!-- Bootstrap core JavaScript -->
            <script src="vendor/jquery/jquery.min.js"></script>
            <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>


            <!-- Additional Scripts -->
            <script src="assets/js/custom.js"></script>
            <script src="assets/js/owl.js"></script>
            <script src="Scripts/CustomJS/checkform.js"></script>

            <script language="text/Javascript"> 
      cleared[0] = cleared[1] = cleared[2] = 0; //set a cleared flag for each field
      function clearField(t){                   //declaring the array outside of the
      if(! cleared[t.id]){                      // function makes it static and global
          cleared[t.id] = 1;  // you could use true and false, but that's more typing
          t.value='';         // with more chance of typos
          t.style.color='#fff';
          }
      }
            </script>


        </body>

    </form>
</body>
</html>

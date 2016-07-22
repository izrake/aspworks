<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="Flipkart.SignIn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <link rel="Stylesheet" type="text/css" href="css/GmailStyling.css" />
    <title>Sign In</title>
    <script type="text/javascript">

        $(document).ready(function () {


            $("input[type!=submit]").focus(function () {
                $(this).css("background-color", "#cccccc");
            });
            $("input[type!=submit]").blur(function () {
                $(this).css("background-color", "#ffffff");
            });



            $("#cmdSignIn").click(function (e) {
                isvalid = true;


                $("input[type!=submit]").each(function () {
                    if ($(this).val() == "") {
                        isvalid = false;
                        $(this).css("border", "2px solid red");
                    }
                    else {
                        $(this).css("border", "");
                    }
                });
                if (isvalid) {
                    alert("Succesfull");
                }
                else {
                    e.preventDefault();

                }
            });

        });
    </script>
</head>
<body>
    <form id="frmSignIn" runat="server">
    <div id="signInContainer">
        <div class="SignInLogoCenter">
            <img src="images/download.png" alt="not available" class="signInLogo" /></div>
        <div class="belowSignInLogo">
            <img src="images/signInLo.PNG" alt="not available" /></div>
        <div class="signInDetails">
            <img src="images/imageLogo.PNG" alt="not available" /><br />
            <asp:TextBox runat="server" ID="txtUsername" placeholder="Enter your name" class="resizedTextbox" />
            <asp:RequiredFieldValidator ID="vliUserName"  ControlToValidate="txtUserName"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <br />

            <asp:TextBox runat="server" TextMode="Password" ID="txtPass" placeholder="Enter your password"
                class="resizedTextPass" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  ControlToValidate="txtPass"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>

            <br />
            <asp:CheckBox Text="Remember Password" ID="chkPassword" runat="server" />
            <asp:Button Text="SignIn" runat="server" placeholder="Enter your password" 
                class="signInButton" ID="cmdSignIn" onclick="cmdSignIn_Click" />
            <p style="text-align: right; padding-right: 10px">
                <a class="anchor" href="http://www.google.com">Need Help?</a>
            </p>
        </div>
        <div class="belowSignGetDetails">
            <asp:LinkButton Text="Create Account" PostBackUrl="~/Registration.aspx" runat="server" />
        </div>
        <div class="footerSignIn">
            <img src="images/allP.PNG" alt="not available" /></div>
    </div>
    </form>
</body>
</html>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Flipkart.Registration" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <script src="js/jquery-1.12.4.js" type="text/javascript"></script>
    <link rel="Stylesheet" type="text/css" href="css/GmailStyling.css" />
    <script src="js/jquery-1.12.4.min.js" type="text/javascript"></script>
    <script src="js/jquery-ui.js" type="text/javascript"></script>
    <script src="js/jquery-ui.min.js" type="text/javascript"></script>
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:300' rel='stylesheet'
        type='text/css' />
    <title></title>
    <script type="text/javascript">
        $(document).ready(function () {
            $("input[type!=submit]").focus(function () {
                $(this).css("background-color", "#cccccc");
            });
            $("input[type!=submit]").blur(function () {
                $(this).css("background-color", "#ffffff");
            });



            $("#btnSignUpMain2").click(function (e) {
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
    <form id="signUp" runat="server">
    <div id="container">
        <div class="headerContainer">
            <img src="images/gImahe.png" alt="image not available" class="imgLogo" />
            <asp:Button Text="SignIn" runat="server" PostBackUrl="~/SignIn.aspx" 
                class="btnSignIn" ID="btnSignIn" onclick="btnSignIn_Click" />
        </div>
        <div class="belowHeader">
            <img src="images/Screen-Shot-2016-03-31-at-9.32.45-AM - Copy.png" alt="not available" />
            <!-- <h1>
                Create Your Google Account
            </h1>-->
        </div>
        <div class="blank">
        </div>
        <div class="centerContainer">
            <!-- <p style="font-family: Monospace; font-size: 20px;">
                One account is all you need</p>
            <p style="font-size: 12px">
                One free account gets you into everything Google.
            </p>-->
            <img src="images/All Google Product.PNG" alt="not available" />
            <img src="images/Capture.PNG" alt="not available" />
        </div>
        <div class="getDetails">
            <p>
                Name
            </p>
            <asp:TextBox runat="server" ID="txtFirstName" placeholder="Firstname" /> <asp:RequiredFieldValidator ID="vliFirstname"  ControlToValidate="txtFirstName"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
           
            <asp:TextBox runat="server" ID="txtLastName" placeholder="LastName" /><asp:RequiredFieldValidator ID="vliLastName"  ControlToValidate="txtLastName"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <p>
                Choose Your Username</p>
            <div class="inputContainer">
                <asp:TextBox runat="server" placeholder="Username" ID="txtUsername" /><asp:RequiredFieldValidator ID="vliUserName"  ControlToValidate="txtUserName"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            </div>
            <br />
            <p>
                Create a password</p>
            <asp:TextBox TextMode="Password" runat="server" ID="txtPassword" placeholder="Password" />
            
            <p>
                Confirm your password</p>
            <asp:TextBox runat="server" ID="txtConfirmPass" placeholder="Confirm Password" />
            <asp:CompareValidator ID="cmpPassword" ErrorMessage="errormessage" Text="*" ControlToValidate="txtPassword"
            ControlToCompare="txtConfirmPass"
                runat="server" />
           
            <p>
                BirthDay</p>
            <asp:DropDownList runat="server" ID="ddlMonth">
                <asp:ListItem Value="0" Text="Month" />
                <asp:ListItem Value="1" Text="January" />
                <asp:ListItem Value="2" Text="February" />
                <asp:ListItem Value="3" Text="March" />
                <asp:ListItem Value="4" Text="April" />
                <asp:ListItem Value="5" Text="May" />
                <asp:ListItem Value="6" Text="June" />
               

            </asp:DropDownList>
             <asp:RequiredFieldValidator ID="vliDDLMonth"  ControlToValidate="ddlMonth" InitialValue="0"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <asp:TextBox runat="server" ID="txtDay" placeholder="Day" size="9px" />
            <asp:RequiredFieldValidator ID="vliDay"  ControlToValidate="txtDay" 
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <asp:TextBox runat="server" ID="txtYear" placeholder="year" size="9px" />
             <asp:RequiredFieldValidator ID="vliYear"  ControlToValidate="txtYear" 
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <p>
                Gender</p>
            <asp:DropDownList runat="server" ID="ddlGender">
                <asp:ListItem Value="0" Text="Gender" />
                <asp:ListItem Value="1" Text="Male" />
                <asp:ListItem Value="2" Text="Female" />
                <asp:ListItem Value="3" Text="Other" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="vliDDLGender"  ControlToValidate="ddlGender" InitialValue="0"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <p>
                Mobile No.</p>
               
            <asp:TextBox runat="server" ID="txtMobileNo" placeholder="Mobile No." />
             <asp:RequiredFieldValidator ID="vliMobileNo"  ControlToValidate="txtYear" 
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <p>
                Your current emaild address</p>
            <asp:TextBox runat="server" ID="txtAltEmail" placeholder="Current Emaild Address" />
            <p>
                Location</p>
            <asp:DropDownList runat="server" ID="ddlLocation">
                <asp:ListItem Value="0" Text="City" />
                <asp:ListItem Value="1" Text="Delhi" />
                <asp:ListItem Value="2" Text="Chenna" />
                <asp:ListItem Value="3" Text="Banglore" />
                <asp:ListItem Value="4" Text="Kanpur" />
                <asp:ListItem Value="5" Text="Varanasi" />
                <asp:ListItem Value="6" Text="Allahabad" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="vliDDLLocation"  ControlToValidate="ddlLocation" InitialValue="0"
                    runat="server" Text="*" ForeColor="Red" ErrorMessage="Enter the username"></asp:RequiredFieldValidator>
            <asp:Button Text="SignUp" runat="server" ID="btnSignUpMain" class="btnSignIn" 
                onclick="btnSignUpMain_Click" />
            <br />
            <asp:CheckBox Text="Accept terms and conditions" runat="server" ID="chkAggreement" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </div>
    </form>
</body>
</html>

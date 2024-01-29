<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="WebApplication1.CustomerForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <title>Customer Registration</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Customer Registration</h2>
            <asp:TextBox ID="TxtName" runat="server" placeholder="Customer Name" Width="265px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="Name must have at least 6 characters" ValidationGroup="CustomerValidation" ClientValidationFunction="validateNameLength"></asp:CustomValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtName" ErrorMessage="Name is required" ValidationGroup="CustomerValidation"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TxtMobile" runat="server" placeholder="Mobile Number" Width="265px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtMobile" ErrorMessage="Enter a 10-digit mobile number" ValidationExpression="^\d{10}$" ValidationGroup="CustomerValidation"></asp:RegularExpressionValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtMobile" ErrorMessage="Mobile is required" ValidationGroup="CustomerValidation"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TxtEmail" runat="server" placeholder="Email" Width="265px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Enter a valid email address" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="CustomerValidation"></asp:RegularExpressionValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Email is required" ValidationGroup="CustomerValidation"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;
            <br />
            <br />
            <asp:TextBox ID="TxtPassword" runat="server" TextMode="Password" placeholder="Password" Width="265px"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtPassword" ErrorMessage="Password is required" ValidationGroup="CustomerValidation"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:TextBox ID="TxtConfirmPassword" runat="server" TextMode="Password" placeholder="Confirm Password" Width="265px"></asp:TextBox>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtPassword" ControlToCompare="TxtConfirmPassword" ErrorMessage="Passwords do not match" ValidationGroup="CustomerValidation"></asp:CompareValidator>
            <br />
            <br />
            <asp:Button ID="BtnReg" runat="server" Text="Register" OnClick="BtnReg_Click" ValidationGroup="CustomerValidation" />
            <br />
            <br />
            <asp:Label ID="LblInfo" runat="server"></asp:Label>

        </div>
    </form>
    <script type="text/javascript">
        function validateNameLength(sender, args) {
            args.IsValid = args.Value.length >= 6;
        }
    </script>
</body>
</html>
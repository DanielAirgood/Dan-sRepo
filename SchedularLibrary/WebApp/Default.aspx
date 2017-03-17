<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApp._Default" %>

<html>
<body runat="server">
    <link rel="stylesheet" href="DoomerStyle.css" />



    <div class="backGround">

            <form runat="server" class="backGround">
                <table style="padding-left:50px;">
                    <tr>
                        <td>
                            <asp:TextBox CssClass=text-field runat=server ID="UserName" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox CssClass=text-field runat=server ID="Password"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button runat=server text="Submit" OnClick="OnSubmit" />
                            </td>
                        <td><output id="output" runat="server"></output></td>
                    </tr>
                </table>
            </form>
    </div>

    


</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>


<html>
    <head>
        <title>

        </title>
        <style type="text/css">
            .auto-style1 {
                width: 14%;
                height: 23px;
            }
            .auto-style2 {
                height: 23px;
            }
        </style>
    </head>
    <body>
        <link rel="stylesheet" href="DoomerStyle.css" />
        <form runat="server">
        <div class=backGround>
            <label style="text-align:center; color:salmon; position:center;background-color:#9D9D9D;">THIS IS YOUR CALANDAAAAAAAR!</label>
            
            <table style="width:100%;">
                <tr>
                    <!-- head -->
                    <th><asp:DropDownList runat="server" ID="MonthList" OnSelectedIndexChanged=ChangeMonth OnTextChanged=UpdateContent>
                        <asp:ListItem value="1">January</asp:ListItem>
                        <asp:ListItem value="2">Febuary</asp:ListItem>
                        <asp:ListItem value="3">March</asp:ListItem>
                        
                        </asp:DropDownList></th>
                    <th><asp:DropDownList runat="server" ID="YearList" OnSelectedIndexChanged=UpdateContent>
                         <asp:ListItem value="2017">2017</asp:ListItem> 
                        
                        </asp:DropDownList></th>
                </tr>
                <tr>
                    <!-- Week1 -->
                    <td><label class=Literal><ASP:Literal runat="server" ID="Su_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="M_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Tu_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="W_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Th_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="F_W1"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Sa_W1"></ASP:Literal></label></td>
                    
                </tr>
                <tr>
                    <!-- Week2 -->
                    <td><label class=Literal><ASP:Literal runat="server" ID="Su_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="M_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Tu_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="W_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Th_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="F_W2"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Sa_W2"></ASP:Literal></label></td>
                </tr>
                <tr>
                    <!-- Week3 -->
                    <td><label class=Literal><ASP:Literal runat="server" ID="Su_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="M_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Tu_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="W_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Th_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="F_W3"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Sa_W3"></ASP:Literal></label></td>
                </tr>
                <tr>
                    <!-- Week4 -->
                    <td><label class=Literal><ASP:Literal runat="server" ID="Su_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="M_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Tu_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="W_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Th_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="F_W4"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Sa_W4"></ASP:Literal></label></td>
                </tr>
                <tr>
                    <!-- Week5 -->
                    <td><label class=Literal><ASP:Literal runat="server" ID="Su_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="M_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Tu_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="W_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Th_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="F_W5"></ASP:Literal></label></td>
                    <td><label class=Literal><ASP:Literal runat="server" ID="Sa_W5"></ASP:Literal></label></td>
                </tr>
            </table>

        </div>
      </form>
    </body>
</html>

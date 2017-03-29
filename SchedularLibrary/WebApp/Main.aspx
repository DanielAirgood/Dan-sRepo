<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebApp.WebForm1" %>

<!DOCTYPE html>


<html>
    <head>
        <style type="text/css">
            .auto-style1 {
                width: 14%;
                height: 23px;
            }
            .auto-style2 {
                height: 23px;
            }
        </style>
        <title>
            
        </title>
    </head>
    <body>
        <link rel="stylesheet" href="DoomerStyle.css" />
        <form runat="server">
        <div class=backGround>
            <label style="text-align:center; color:salmon; position:center; width: 100%;">THIS IS YOUR CALANDAAAAAAAR!</label>
            <table style="width:100%">
                <tr>
                    <!-- head -->
                    <th><asp:DropDownList runat="server" ID="MonthList" OnSelectedIndexChanged=UpdateMonth>
                         <asp:ListItem value="1">January</asp:ListItem> 
                        
                        </asp:DropDownList></th>
                    <th><asp:DropDownList runat="server" ID="YearList" OnSelectedIndexChanged=UpdateContent>
                         <asp:ListItem value="2017">2017</asp:ListItem> 
                        
                        </asp:DropDownList></th>
                </tr>
                <tr>
                    <!-- Week1 -->
                    <td> <asp:Literal runat="server" ID=D1W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D2W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D3W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D4W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D5W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D6W1>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D7W1>  </asp:Literal> </td>
                </tr>
                <tr>
                    <!-- Week2 -->
                    <td> <asp:Literal runat="server" ID=D1W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D2W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D3W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D4W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D5W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D6W2>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D7W2>  </asp:Literal> </td>
                </tr>
                <tr>
                    <!-- Week3 -->
                    <td> <asp:Literal runat="server" ID=D1W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D2W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D3W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D4W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D5W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D6W3>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D7W3>  </asp:Literal> </td>
                </tr>
                <tr>
                    <!-- Week4 -->
                    <td> <asp:Literal runat="server" ID=D1W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D2W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D3W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D4W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D5W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D6W4>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D7W4>  </asp:Literal> </td>
                </tr>
                <tr>
                    <!-- Week5 -->
                    <td> <asp:Literal runat="server" ID=D1W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D2W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D3W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D4W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D5W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D6W5>  </asp:Literal> </td>
                    <td> <asp:Literal runat="server" ID=D7W5>  </asp:Literal> </td>
                </tr>
            </table>

        </div>
            </form>
    </body>
</html>

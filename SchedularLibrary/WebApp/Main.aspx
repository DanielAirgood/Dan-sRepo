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
    </head>
    <body>
        <link rel="stylesheet" href="DoomerStyle.css" />
        <form runat="server">
        <div class=backGround>
            <label style="text-align:center; color:salmon; position:center;">THIS IS YOUR CALANDAAAAAAAR!</label>
            <table style="width:100%;">
                <tr>
                    <!-- head -->
                    <th><asp:DropDownList runat="server" ID="MonthList" OnSelectedIndexChanged=UpdateContent>
                         <asp:ListItem value="1">January</asp:ListItem> 
                        
                        </asp:DropDownList></th>
                    <th><asp:DropDownList runat="server" ID="YearList" OnSelectedIndexChanged=UpdateContent>
                         <asp:ListItem value="2017">2017</asp:ListItem> 
                        
                        </asp:DropDownList></th>
                </tr>
                <tr>
                    <!-- Week1 -->
                    <td class=DayItem><output id="Su_W1"></output></td> <td class=DayItem><output id="M_W1"></output></td> <td class=DayItem><output id="Tu_W1" class=DayItem></output></td><td class="auto-style2"><output id="W_W1" class=DayItem></output></td><td class=DayItem><output id="Th_W1" class=DayItem></output></td><td class=DayItem><output id="F_W1" class=DayItem></output></td><td class=DayItem><output id="Sa_W1" class=DayItem></output></td>
                </tr>
                <tr>
                    <!-- Week2 -->
                    <td class=DayItem><output id="Su_W2" style="width:100%"></output></td><td><output id="M_W2" class=DayItem></output></td><td><output id="Tu_W2" class=DayItem></output></td><td><output id="W_W2" class=DayItem></output></td><td><output id="Th_W2" class=DayItem></output></td><td><output id="F_W2" class=DayItem></output></td><td><output id="Sa_W2" class=DayItem></output></td>
                </tr>
                <tr>
                    <!-- Week3 -->
                    <td><output id="Su_W3" style="width:100%"></output></td><td><output id="M_W3" class=DayItem></output></td><td><output id="Tu_W3" class=DayItem></output></td><td><output id="W_W3" class=DayItem></output></td><td><output id="Th_W3" class=DayItem></output></td><td><output id="F_W3" class=DayItem></output></td><td><output id="Sa_W3" class=DayItem></output></td>
                </tr>
                <tr>
                    <!-- Week4 -->
                    <td><output id="Su_W4" class=DayItem></output></td><td><output id="M_W4" class=DayItem></output></td><td><output id="Tu_W4" class=DayItem></output></td><td><output id="W_W4" class=DayItem></output></td><td><output id="Th_W4" class=DayItem></output></td><td><output id="F_W4" class=DayItem></output></td><td><output id="Sa_W4" class=DayItem></output></td>
                </tr>
                <tr>
                    <!-- Week5 -->
                    <td><output id="Su_W5" class=DayItem></output></td><td><output id="M_W5" class=DayItem></output></td><td><output id="Tu_W5" class=DayItem></output></td><td><output id="W_W5" class=DayItem></output></td><td><output id="Th_W5" class=DayItem></output></td><td><output id="F_W5" class=DayItem></output></td><td><output id="Sa_W5" class=DayItem></output></td>
                </tr>
            </table>

        </div>
            </form>
    </body>
</html>

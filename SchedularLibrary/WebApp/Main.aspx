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
                    <th><asp:DropDownList runat="server" ID="MonthList">
                        <asp:ListItem value="1">January</asp:ListItem>
                        <asp:ListItem value="2">Febuary</asp:ListItem>
                        <asp:ListItem value="3">March</asp:ListItem>
                        <asp:ListItem value="4">April</asp:ListItem>
                        <asp:ListItem value="5">May</asp:ListItem>
                        <asp:ListItem value="6">June</asp:ListItem>
                        <asp:ListItem value="7">July</asp:ListItem>
                        <asp:ListItem value="8">August</asp:ListItem>
                        <asp:ListItem value="9">September</asp:ListItem>
                        <asp:ListItem value="10">October</asp:ListItem>
                        <asp:ListItem value="11">November</asp:ListItem>
                        <asp:ListItem value="12">December</asp:ListItem>
                        
                        </asp:DropDownList><asp:Button runat="server" Text="Change Month" OnClick=UpdateMonth /></th>
                    <th><asp:DropDownList runat="server" ID="YearList">
                         <asp:ListItem value="2017">2017</asp:ListItem> 
                        <asp:ListItem value="2018">2018</asp:ListItem> 
                        <asp:ListItem value="2019">2019</asp:ListItem> 
                        
                        </asp:DropDownList><asp:Button runat="server" Text="Change Year" OnClick=UpdateYear /></th>
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

            <div>
                Year:<asp:TextBox runat="server" ID="targetYear"></asp:TextBox>
                <br />
                Months:<asp:TextBox runat="server" ID="targetMonths"></asp:TextBox>
                <br />
                Days of Week:<asp:TextBox runat="server" ID="targetWeekDays"></asp:TextBox>
                <br />
                Days of Month:<asp:TextBox runat="server" ID="targetDays"></asp:TextBox>
                <br />
                Room Number:<asp:TextBox runat="server" ID="targetRoom"></asp:TextBox>
                <br />
                Course Name:<asp:TextBox runat="server" ID="targetCourse"></asp:TextBox>
                <br />
                Starting Time:<asp:TextBox runat="server" ID="targetStart"></asp:TextBox>
                <br />
                Ending Time:<asp:TextBox runat="server" ID="targetEnd"></asp:TextBox>
                <br />
                <asp:Button runat="server" Text="UploadToCalandar" OnClick="Upload" />
                <br />
                <asp:ScriptManager runat="server"></asp:ScriptManager>
                <asp:UpdatePanel runat="server" ID="Message"> <ContentTemplate><asp:Label runat="server" ID="MessageText"></asp:Label></ContentTemplate> </asp:UpdatePanel>
                    
            </div>
      </form>
    </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="calendar.aspx.cs"
    Inherits="pr5.calander" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>
    <form id="form1" runat="server">
        <div>

            <asp:Calendar ID="Calendar1" runat="server"
                BackColor="White"
                BorderColor="#3366CC"
                BorderWidth="1px"
                CellPadding="1"
                DayNameFormat="Shortest"
                Font-Names="Verdana"
                Font-Size="8pt"
                ForeColor="#003399"
                Height="200px"
                Width="220px"
                OnSelectionChanged="Calendar1_SelectionChanged">

                <DayHeaderStyle BackColor="#99CCCC"
                    ForeColor="#336666"
                    Height="1px" />

                <NextPrevStyle Font-Size="8pt"
                    ForeColor="#CCCCFF" />

                <OtherMonthDayStyle ForeColor="#999999" />

                <SelectedDayStyle BackColor="#009999"
                    Font-Bold="True"
                    ForeColor="#CCFF99" />

                <SelectorStyle BackColor="#99CCCC"
                    ForeColor="#336666" />

                <TitleStyle BackColor="#003399"
                    BorderColor="#3366CC"
                    BorderWidth="1px"
                    Font-Bold="True"
                    Font-Size="10pt"
                    ForeColor="#CCCCFF"
                    Height="25px" />

                <TodayDayStyle BackColor="#99CCCC"
                    ForeColor="White" />

                <WeekendDayStyle BackColor="#CCCCFF" />

            </asp:Calendar>

            <br />

            <asp:Label ID="lblSelectedDate"
                runat="server"
                Text="Select Date">
            </asp:Label>

            <br />

            <asp:Button ID="BtnApplyLeave"
                runat="server"
                Text="Apply Leave"
                OnClick="BtnApplyLeave_Click" />

        </div>
    </form>
</body>
</html>
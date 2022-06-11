<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Scheduele.aspx.cs" Inherits="final_project.Scheduele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Style/Scheduele.css"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align:center; align-items:center">
        <header>These are all of your meetings</header>
    </div>
    
    <div id="meetings">
        <%if (meetings.GetLength(0) < 1)
            {%>
        <p>There are no meetings for you to view</p>
        <%} %>
        <%for (int i = 0; i < meetings.GetLength(0); i++)
            { %>
        <div class="meeting">
            <form method="post" class="Xcontainer">
                <input type="submit" class="X" value="X" name="delete" />
                <input type="text" value="<%=meetings[i,0] %>" style="display:none;" name="Id"/>
            </form>
            <div>
            <label>Meeting Name: <%=meetings[i,1] %></label>
            <label>Meeting Date:<%=meetings[i,4] %> /<%=meetings[i,3] %>/<%=meetings[i,2] %></label>
            <label>Meeting Time:<%=meetings[i,5] %></label>
                </div>
            <div>
            <label>Comments:</label>
            <textarea><%=meetings[i,6] %></textarea>
                </div>
        </div>
        <%} %>
    </div>
</asp:Content>

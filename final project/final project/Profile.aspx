<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="final_project.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Style/Profile.css" rel="stylesheet" type="text/css"/>
    <%if (scheduele.GetLength(0) > 0)
            { %>
        <script defer src="Script/Profile.js"></script>
        <%} %>
    
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="userdata">
    <h1>Name: <%=name %></h1>
    <a href="mailto:<%=mail %>">Email: <%=mail %></a>
    <label for="sched"><%=name %>'s Scheduele</label>
    <div id="sched">
        <%if (scheduele.GetLength(0) < 1)
            { %>
        <p>There are no meetings for <%=name %></p>
        <%} %>
        <%for (int i = 0; i < scheduele.GetLength(0); i++)
            { %>
        <div class="lesson">
            <p>Date: <%=scheduele[i, 2] %>/<%=scheduele[i, 1] %>/<%=scheduele[i, 0] %>  Hour: <%=scheduele[i, 3] %></p>
            
        </div>
        <%} %>
    </div>
        <%if (Session["Id"] != null)
            { %>
        <form method="post" onsubmit=" return validate()">
            <fieldset id="createmeeting">
                <legend>Set a meeting</legend>
                <label for="Comments">Lesson name: </label>
                <input type="text" id="Title" name="name" required/>
                <label for="date">Choose a Date:</label>
                <div id="date">
                    <input type="date" name="date" required />
                    <input type="time" name="time"/>
                </div>
                <label for="Comments">Comments: (optional) </label>
                <input type="text" id="Commnets" name="comment" />
                <input type="submit" name="scheduele" value="Set up the lesson" />
                <h6 schederr></h6>
            </fieldset>
        </form>
        <%}
            else
            { %>
        <h3> to set up meetings you must be logged in</h3>
        <%} %>
        </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="final_project.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="/Style/Admin.css" />
    <script>

        
        let port = <%=p %>
        let len = <%=len%>
        let usersArr = <%=Users %>
        let users = []
        for (let i = 0; i < len; i++) {
            let place = i * 8;
            users.push({ "Id": `${ usersArr[place]}`, "Firstname": `${usersArr[place + 1]}`, "Lastname": `${usersArr[place + 2]}`, "Email": `${usersArr[place + 3]}`, "Age": `${ usersArr[place + 4]}`, "Phonenumber": `${usersArr[place + 5]}`, "City": `${usersArr[place + 6]}`, "Password": `${usersArr[place+7]}`})
        }
        
        
    </script>
    <script defer src="/Script/Admin.js"></script>
    <script src ="/Script/InfoCheck.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div id="tablecontainer">
    <table>
        <tbody id="UserTable">
           
        <tr id="headers">
            <th class="property">test</th>
            <th class="property">Firstname</th>
            <th class="property">Lastname</th>
            <th class="property">Email</th>
            <th class="property">Age</th>
            <th class="property">Phonenumber</th>
            <th class="property">City</th>
            <th class="property">Password</th>
        </tr>
           
        </tbody>
    </table>
        </div>
</asp:Content>

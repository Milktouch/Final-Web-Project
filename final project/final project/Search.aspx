<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="final_project.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="/Style/Search.css" rel="stylesheet" />
    <script defer src="/Script/Search.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="search-wrapper">
    <label for="search">Search Users</label>
    <input type="search"  data-search>
  </div>
  <div class="user-cards" data-user-cards-container>
    <%for (int i = 0; i < users.GetLength(0); i++)
        { %>
    <div class="card" id="<%=users[i,0] %>">
      <div class="header" data-header><%=users[i,1] %>  <%=users[i,2] %></div>
      <div class="body" data-body><%=users[i,3] %></div>
    </div>
  <%} %>
      </div>
</asp:Content>

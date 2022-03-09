<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="final_project.mypage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title><%=user[0] %>'s Profile</title>
    <script src="./Script/MyPage.js" ></script>
    <link href="./Style/Mypage.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="center"><%=user[0] %>'s Profile</h1>
    <div id="allcreds">
        <div class="creds">
            <fieldset class="Userdata">
                <legend>First Name</legend>
                <input value="<%=user[0] %>"class="data" type="text" oninput="$(this).siblings('Legend').text('First Name*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('First Name');" >Update Data</button>
            </fieldset>
            <fieldset class="Userdata">
                <legend>Last Name</legend>
                <input value="<%=user[1] %>" class="data" type="text" oninput="$(this).siblings('Legend').text('Last Name*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('Last Name');" >Update Data</button>
            </fieldset>
        </div>
        <div class="creds">
            <fieldset class="Userdata">
                <legend>E-mail</legend>
                <input value="<%=user[2] %>" class="data" type="text" oninput="$(this).siblings('Legend').text('E-mail*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('E-mail');" >Update Data</button>
            </fieldset>
            <fieldset class="Userdata">
                <legend>City</legend>
                <input value="<%=user[5] %>" class="data" type="text" oninput="$(this).siblings('Legend').text('City*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('City');" >Update Data</button>
            </fieldset>
        </div>
        <div class="creds">
            <fieldset class="Userdata">
                <legend>Age</legend>
                <input value="<%=user[3] %>" class="data" type="text" oninput="$(this).siblings('Legend').text('Age*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('Age');" >Update Data</button>
            </fieldset>
            <fieldset class="Userdata">
                        <legend>Phone number</legend>
                        <div>
                            <input value="<%=user[4] %>" type="text" name="phone" id="phone" class="data" oninput="$(this).parent().siblings('Legend').text('Phone number*');" />
                        </div>
                <button class="Update" onclick="$(this).siblings('Legend').text('Phone number');" >Update Data</button>
                    </fieldset>
           
        </div>
         <div class="creds">
            <fieldset class="Userdata">
                <legend>Password</legend>
                <input value="<%=user[6] %>" class="data" type="text" oninput="$(this).siblings('Legend').text('First Name*');"/>
                <button class="Update" onclick="$(this).siblings('Legend').text('First Name');" >Update Data</button>
            </fieldset>
        </div>
    </div>
</asp:Content>

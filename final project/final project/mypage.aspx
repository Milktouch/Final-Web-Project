<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="mypage.aspx.cs" Inherits="final_project.mypage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title><%=user[1] %>'s Profile</title>
    <script defer src="./Script/MyPage.js"></script>
    <script src="./Script/InfoCheck.js"></script>
    <script>
        let port = <% =port%>
            let id =<%=id %>
    </script>
    <link href="./Style/RegisterStyle.css" rel="stylesheet" type="text/css" />
    <link href="./Style/Mypage.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="center"><%=user[1] %>'s Profile</h1>
    <div id="allcreds">

        <div class="creds">
            <fieldset class="Userdata">
                <legend>First Name</legend>

                <input value="<%=user[1]%>" id="firstname" name="firstname" class="data" type="text" oninput="$(this).siblings('Legend').text('First Name*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>
            </fieldset>
            <fieldset class="Userdata">
                <legend>Last Name</legend>

                <input value="<%=user[2] %>" id="lastname" name="lastname" class="data" type="text" oninput="$(this).siblings('Legend').text('Last Name*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>
            </fieldset>
        </div>
        <div class="creds">
            <fieldset class="Userdata">
                <legend>Email</legend>
                <input value="<%=user[3] %>" id="mail" name="mail" class="data" type="text" oninput="$(this).siblings('Legend').text('E-mail*');" />
                <button class="Update button">Update</button>

                <h6 class="error"></h6>
            </fieldset>
            <fieldset class="Userdata">
                <legend>City</legend>

                <input value="<%=user[6] %>" class="data" name="city" type="text" oninput="$(this).siblings('Legend').text('City*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>

            </fieldset>
        </div>
        <div class="creds">
            <fieldset class="Userdata">
                <legend>Age</legend>

                <input value="<%=user[4] %>" id="age" name="age" class="data" type="text" oninput="$(this).siblings('Legend').text('Age*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>
            </fieldset>
            <fieldset class="Userdata">
                <legend>Phone Number</legend>


                <input value="<%=user[5] %>" type="text" id="phone" name="phone" class="data" oninput="$(this).parent().siblings('Legend').text('Phone number*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>
            </fieldset>
        </div>
        <div class="creds">

            <fieldset class="Userdata">
                <legend>Pass Word</legend>


                <input name="password" value="<%=user[7] %>" id="password" class="data" type="password" oninput="$(this).siblings('Legend').text('Pass Word*');" />
                <button class="Update button">Update</button>
                <h6 class="error"></h6>
            </fieldset>

        </div>



    </div>
</asp:Content>

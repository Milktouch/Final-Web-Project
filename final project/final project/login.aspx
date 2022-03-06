<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="final_project.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title> Login</title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h1 class="center"> Login</h1>

    <form  method="post">
        <table class="center" >
            <tr>
                <td> Username:</td>
                
                <td> <input  type="text" name="username" required/></td>
                
            </tr>
            <tr>
                <td> Password:</td>
                
                <td> <input  type="password" name="password" required /></td>
                <td></td>
            </tr>
            
            <tr>
                <td></td>
                <td> <input class="submit" type="submit" name="submit" value="Sign in" /></td>
                <td></td>
            </tr>
            
            </table>
            
    </form>
   
            
                <p  class="center" style="font-size:15px;">Dont have an account? <br />

                    <a href="register.aspx">click here</a></p>
            
        
    
</asp:Content>

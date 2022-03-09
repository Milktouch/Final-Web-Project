<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="final_project.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Style/RegisterStyle.css" rel="stylesheet" type="text/css" />
    <script src="./Script/Registerscript.js" type="text/javascript"></script>
    <title>Signup</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="center" style="margin: 10px;">Sign up form</h1>

    <form method="post" class="center" onsubmit="checkall()">
        <table class="center">

            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Firstname</legend>
                        <input oninput="checkfname()" type="text" name="firstname" id="firstname" required />
                        <h6 class="error" id="fnamev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Lastname</legend>
                        <input oninput="checklname()" type="text" name="lastname" id="lastname" required />
                        <h6 class="error" id="lnamev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>E-mail</legend>
                        <input oninput="checkmail()" type="text" name="mail" id="mail" required />
                        <h6 class="error" id="emailv"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Age</legend>

                        <input oninput="checkage()" type="text" name="age" id="age" required />
                        <h6 class="error" id="agev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Phonenumber</legend>
                        <div>
                            <select id="headers" name="phoneheader">
                                <option value="050">050</option>
                                <option value="051">051</option>
                                <option value="052">052</option>
                                <option value="053">053</option>
                                <option value="054">054</option>
                                <option value="055">055</option>
                                <option value="057">057</option>
                                <option value="058">058</option>
                                <option value="077">077</option>
                                <option value="02">02</option>
                                <option value="03">03</option>
                                <option value="04">04</option>
                                <option value="08">08</option>
                                <option value="09">09</option>
                            </select>
                            <input oninput="checkphone()" type="text" name="phone" id="phone" required />
                        </div>
                        <h6 class="error" id="phonev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>City</legend>
                        <input list="cities" name="city" required />
                        <datalist id="cities">
                            <option value="Rishon Leziyon">Rishon Leziyon</option>
                            <option value="Tel-Aviv">Tel-Aviv</option>
                            <option value="Ashdod">Ashdod</option>
                            <option value="Haifa">Haifa</option>
                            <option value="Beer-Sheva">Beer-Sheva</option>
                        </datalist>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Password</legend>
                        <input oninput="checkpass()" type="password" name="password" id="password" required />
                        <h6 class="error" id="pass1"></h6>
                        <h4 style="margin: 1px;">re-enter password</h4>
                        <input oninput="checkpass2()" type="password" id="password2" required />
                        <h6 class="error" id="pass2"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td class="center">
                    <input type="submit" class="submit" value="Register" name="register"  /></td>
                <td class="center">
                     <div class="circle1"></div>
    <div class="circle2"></div>
    <div class="circle3"></div>
                </td>
            </tr>

        </table>
    </form>
</asp:Content>

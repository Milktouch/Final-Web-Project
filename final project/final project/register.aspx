<%@ Page Title="" Language="C#" MasterPageFile="~/masterpage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="final_project.register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="./Style/RegisterStyle.css" rel="stylesheet" type="text/css" />
    <script src="./Script/Registerscript.js" type="text/javascript"></script>
    <script defer>
        
    </script>
    <title>Signup</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 class="center" style="margin: 10px;">Sign up form</h1>
    <h2 style="color:red;text-align:center;" id="errors"><%=error %></h2>
    <form method="post" class="center" onsubmit="return checkall()">
        <table class="center">

            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Firstname</legend>
                        <input oninput="checkfname()" type="text" name="firstname" id="firstname" value="<%=firstname %>" required />
                        <h6 class="error" id="fnamev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Lastname</legend>
                        <input oninput="checklname()" type="text" name="lastname" id="lastname" value="<%=lastname %>" required />
                        <h6 class="error" id="lnamev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>E-mail</legend>
                        <input oninput="checkmail()" type="text" name="mail" id="mail" value="<%=Email %>" required />
                        <h6 class="error" id="emailv"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Age</legend>

                        <input oninput="checkage()" type="text" name="age" id="age" value="<%=age %>" required />
                        <h6 class="error" id="agev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>Phonenumber</legend>
                        <div>
                            <select id="headers" name="phoneheader" >
                                <option <%if (phonenumber.Substring(0, 3) == "050")
                                    { %> selected <%} %> value="050">050</option>
                                <option <%if (phonenumber.Substring(0, 3) == "051")
                                    { %> selected <%} %> value="051">051</option>
                                <option <%if (phonenumber.Substring(0, 3) == "052")
                                    { %> selected <%} %> value="052">052</option>
                                <option <%if (phonenumber.Substring(0, 3) == "053")
                                    { %> selected <%} %> value="053">053</option>
                                <option <%if (phonenumber.Substring(0, 3) == "054")
                                    { %> selected <%} %> value="054">054</option>
                                <option <%if (phonenumber.Substring(0, 3) == "055")
                                    { %> selected <%} %> value="055">055</option>
                                <option <%if (phonenumber.Substring(0, 3) == "057")
                                    { %> selected <%} %> value="057">057</option>
                                <option <%if (phonenumber.Substring(0, 3) == "058")
                                    { %> selected <%} %> value="058">058</option>
                                <option <%if (phonenumber.Substring(0, 3) == "077")
                                    { %> selected <%} %> value="077">077</option>
                                <option <%if (phonenumber.Substring(0, 2) == "02")
                                    { %> selected <%} %> value="02">02</option>
                                <option <%if (phonenumber.Substring(0, 2) == "03")
                                    { %> selected <%} %> value="03">03</option>
                                <option <%if (phonenumber.Substring(0, 2) == "04")
                                    { %> selected <%} %> value="04">04</option>
                                <option <%if (phonenumber.Substring(0, 2) == "08")
                                    { %> selected <%} %> value="08">08</option>
                                <option <%if (phonenumber.Substring(0, 2) == "09")
                                    { %> selected <%} %> value="09">09</option>
                            </select>
                            <input oninput="checkphone()" type="text" name="phone" id="phone"<%if (phonenumber.Length > 8)
                                { %> value="<%=phonenumber.Substring(phonenumber.Length - 7) %>"<%} %> required />
                        </div>
                        <h6 class="error" id="phonev"></h6>
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset class="center">
                        <legend>City</legend>
                        <input list="cities" name="city" value="<%=city %>" required />
                        <datalist id="cities">
                            <option  value="Rishon Leziyon">Rishon Leziyon</option>
                            <option  value="Tel-Aviv">Tel-Aviv</option>
                            <option  value="Ashdod">Ashdod</option>
                            <option  value="Haifa">Haifa</option>
                            <option  value="Beer-Sheva">Beer-Sheva</option>
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
                    <input type="submit" class="submit" value="Register" name="register"  />

                </td>
            </tr>

        </table>
    </form>
</asp:Content>

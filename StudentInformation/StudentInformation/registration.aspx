<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="StudentInformation.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div>
            <h1>Student Information</h1>
            <table>
                <tr>
                    <td>ID:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td>Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>

                 <tr>
                    <td>Dept:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>CSE</asp:ListItem>
                            <asp:ListItem>EEE</asp:ListItem>
                            <asp:ListItem>BBA</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>

                 <tr>
                    <td>DOB:</td>
                    <td>
                        <asp:TextBox ID="txtbod" TextMode="Date" runat="server"></asp:TextBox>

                    </td>
                </tr>

                 <tr>
                    <td>Program:</td>
                    <td>
                        <asp:RadioButton ID="RadioButton1" GroupName="user" Text=" OUG" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" />
                        <br/>
                        <asp:RadioButton ID="RadioButton2" GroupName="user" Text="Grad" runat="server" OnCheckedChanged="RadioButton2_CheckedChanged" />
                    </td>
                </tr>
            </table>

            <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            <table align="center">
                    
                <tr>
                    <td> Remove By ID:</td>
                    <td> <asp:TextBox ID="txtremove" runat="server"></asp:TextBox> </td>
                    <td><asp:Button ID="remove" runat="server" Text="Remove" OnClick="Button2_Click" /></td>
                </tr>

            </table>

            

            <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="Show All Data" OnClick="Button4_Click" />
            <table>
                
                 <tr>
                    <td>Search By Dept:</td>
                    <td>
                        <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem>CSE</asp:ListItem>
                            <asp:ListItem>EEE</asp:ListItem>
                            <asp:ListItem>BBA</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                     <td>
                        <asp:Button ID="dptsrch" runat="server" Text="Search" OnClick="dptsrch_Click" />
                     </td>
                </tr>
           
            </table>
            <br />
            <br />
            <br />
            <h3>Data base Show</h3>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="503px"></asp:GridView>
        </div>

    </div>

</asp:Content>

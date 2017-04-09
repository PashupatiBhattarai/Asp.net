<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GRIDCRUD.aspx.cs" Inherits="DATAFIRSTCRUD.GRIDCRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand1" OnItemDataBound="Repeater1_ItemDataBound">

                <HeaderTemplate>
                    <table>
                        <tr>

                            <td>PatientLogInId </td>
                            <td>PatientINfoId </td>
                            <td>PatientName</td>
                            <td>Password</td>

                        </tr>
                </HeaderTemplate>

                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtPatientLogInId" ReadOnly="true" Text='<%# Bind("PatientLogInId")%>' runat="server"></asp:TextBox>
                            </td>
                        <td>
                            <asp:TextBox ID="txtPatientINfoId" ReadOnly="true" Text='<%# Bind("PatientINfoId")%>' runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPatientINfoId" ControlToValidate="txtPatientINfoId" ForeColor="Blue" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPatientName" ReadOnly="true" Text='<%# Bind("PatientName")%>' runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPatientName" ControlToValidate="txtPatientName" ForeColor="Blue" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtPassword" ReadOnly="true" Text='<%# Bind("Password")%>' runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rfvPassword" ControlToValidate="txtPassword" ForeColor="Blue" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>

                        <td>
                            <asp:LinkButton ID="btnSelect" CommandName="Select" runat="server" Text="Select" ></asp:LinkButton>
                            <asp:LinkButton ID="btnUpdate" CausesValidation="false" CommandName="Update" Text="Update" Visible="false" OnClientClick="return confirm('Are you sure to Update?')" runat="server"></asp:LinkButton> 
                            <asp:LinkButton ID="btnDelete" CausesValidation="false" CommandName="Delete" Text="Delete" Visible="false" OnClientClick="return confirm('Are you sure to Delete?')" runat="server"></asp:LinkButton>

                        </td>
                    </tr>

                </ItemTemplate>
                <FooterTemplate>
                    <tr>
                        <td>
                               <asp:TextBox ID="txtPatientLogInId" Visible="false" runat="server"></asp:TextBox>
                        </td>
                       
                        <td>
                            <asp:TextBox ID="ftxtPatientINfoId" Visible="false" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="frfvPatientINfoId" ControlToValidate="ftxtPatientINfoId" ForeColor="Red" runat="server" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtPatientName" Visible="false" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="frfvPatientName" ControlToValidate="ftxtPatientName" ForeColor="Red" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="ftxtPassword" Visible="false" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="frfvPassword" ControlToValidate="ftxtPassword" ForeColor="Red" runat="server" BackColor="Red" ErrorMessage="*"></asp:RequiredFieldValidator>
                        </td>

                        <td>
                            <asp:LinkButton CausesValidation="true" ID="fbtnAdd" CommandName="Add" runat="server" Text="Add" ></asp:LinkButton>
                            <asp:LinkButton CausesValidation="false" ID="fbtnSave" CommandName="Save" runat="server" Text="Save" Visible="false"></asp:LinkButton>
                            </td>
                        </tr>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>

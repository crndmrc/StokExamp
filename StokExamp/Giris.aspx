<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="StokExamp.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</head>
<body>
   <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Button ID="btnListele" runat="server" Text="Listele" Width="75px" OnClick="btnListele_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="gvMusteri" runat="server" DataKeyNames="id"  OnSelectedIndexChanged="gvMusteri_SelectedIndexChanged">
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td>
                    <table>
                        <tr>
                            <th colspan="3">
                                <b>Kayıt Formu</b>
                            </th>
                        </tr>
                        <tr>
                            <td>Id</td>
                            <td>
                                <asp:Label ID="lblId" runat="server"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnYeni" runat="server" Text="Yeni" Width="75px" OnClick="btnYeni_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>Ad</td>
                            <td>
                                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" Width="75px" OnClick="btnKaydet_Click" style="height: 26px" />
                            </td>
                        </tr>
                        <tr>
                            <td>Telefon</td>
                            <td>
                                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnSil" runat="server" Text="Sil" Width="75px" OnClick="btnSil_Click" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

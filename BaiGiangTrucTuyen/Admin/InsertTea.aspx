<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdMasterPage.Master" AutoEventWireup="true" CodeBehind="InsertTea.aspx.cs" Inherits="BaiGiangTrucTuyen.Admin.InsertTea" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 style="text-align: center">Thêm mới giáo viên</h1>
    <div class="container">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-5">
                 <span>Mã Giáo Viên</span><br>
                <asp:TextBox ID="txtMaGV" CssClass="form-control" runat="server"></asp:TextBox>
                 <span>Tên Giáo Viên </span><br>
                <asp:TextBox ID="txtHoTen" CssClass="form-control" runat="server"></asp:TextBox>
                <br>            
                <span>Số điện thoại</span><br>
                <asp:TextBox ID="txtPhone" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <span>Email</span><br>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <asp:Button Text="Thêm mới giáo viên " CssClass="btn btn-danger" ID="btnAdd" runat="server" OnClick="btnAdd_Click"   />
            </div>
        </div>
    </div>
</asp:Content>

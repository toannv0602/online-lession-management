<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdMasterPage.Master" AutoEventWireup="true" CodeBehind="InsertST.aspx.cs" Inherits="BaiGiangTrucTuyen.Admin.InsertST" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h1 style="text-align: center">Thêm mới sinh viên </h1>
    <div class="container">
        <div class="row">
            <div class="col-md-3"></div>
            <div class="col-md-5">
                 <span>Mã Sinh Viên</span><br>
                <asp:TextBox ID="txtMaSV" CssClass="form-control" runat="server"></asp:TextBox>
                 <span>Tên Học Sinh</span><br>
                <asp:TextBox ID="txtHoTen" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <span>Lớp Hành Chính</span><br>
                <asp:TextBox ID="txtLop" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <span>Giới Tính</span><br>
                <asp:TextBox ID="txtGioiTinh" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <span>Ngày Sinh</span><br>
                <asp:TextBox ID="txtNgaySinh" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <span>Email</span><br>
                <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                <br>
                <asp:Button Text="Thêm mới sinh viên " CssClass="btn btn-danger" ID="btnAdd" runat="server" OnClick="btnAdd_Click"  />
            </div>
        </div>
    </div>
</asp:Content>

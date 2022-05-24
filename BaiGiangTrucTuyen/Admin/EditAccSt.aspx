<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdMasterPage.Master" AutoEventWireup="true" CodeBehind="EditAccSt.aspx.cs" Inherits="BaiGiangTrucTuyen.Admin.EditAccSt" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align: center">Chỉnh sửa hồ sơ sinh viên </h1>
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
                <asp:Button Text="Chỉnh Sửa Hồ Sơ" CssClass="btn btn-danger" ID="txtEdit" runat="server" OnClick="txtEdit_Click"  />
            </div>
        </div>
    </div>
</asp:Content>

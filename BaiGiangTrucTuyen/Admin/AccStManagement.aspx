<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdMasterPage.Master" AutoEventWireup="true" CodeBehind="AccStManagement.aspx.cs" Inherits="BaiGiangTrucTuyen.Admin.AccManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
         <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">Quản lý tài khoản sinh viên </h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>Mã Sinh Viên</th>
                                            <th>Tên Sinh Viên</th>
                                            <th>Lớp Tín Chỉ </th>
                                            <th>Giới Tính</th>
                                            <th>Ngày Sinh</th>
                                            <th>Email</th>
                                            <th>Tùy Chỉnh <th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Literal ID="LitST" runat="server"></asp:Literal>      
                                    </tbody>
                                </table>         
                               <asp:Button ID="BtnThem" runat="server" CssClass="btn btn-danger" Text="Thêm Học Sinh" OnClick="BtnThem_Click" />
                            </div>
                        </div>
                    </div>

                </div>
</asp:Content>

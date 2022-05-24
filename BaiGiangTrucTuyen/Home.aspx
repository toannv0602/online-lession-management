<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BaiGiangTrucTuyen.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assets/css/Home.css" rel="stylesheet" />
    <!-- Page Content -->
    <!-- Single Starts Here -->
    <div class="single-product">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-heading">
                        <div class="line-dec"></div>
                        <h1>Hồ sơ</h1>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="product-slider">
                        <img src="assets/images/about-us.jpg" style="width: 300px; height: 300px;" />
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="right-content">
                        <h6>Họ và tên:
                            <asp:Literal ID="ltrTenSV" runat="server"></asp:Literal>
                        </h6>
                        <h6>Mã sinh viên:
                            <asp:Literal ID="ltrMaSV" runat="server"></asp:Literal></h6>
                        <h6>Tên Lớp hành chính:
                            <asp:Literal ID="ltrLopHC" runat="server"></asp:Literal></h6>
                        <h6><a href="DoiMatKhau.aspx">Thay đổi Mật Khẩu</a></h6>
                        <h6>Thời gian sử dụng:</h6>
                        <div>
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Timer ID="Timer1" runat="server" Interval="500" OnTick="Tick1"></asp:Timer>
                                        <asp:Label ID="lbDemtg" runat="server" Text="Label"></asp:Label>
                                    </ContentTemplate>
                       </asp:UpdatePanel>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Single Page Ends Here -->


                                    <!-- Similar Starts Here -->
                                    <div class="featured-items">
                                        <div class="container">
                                            <div class="row">
                                                <div class="col-md-12">
                                                    <div class="section-heading">
                                                        <div class="line-dec"></div>
                                                        <h1>Các khóa học của tôi</h1>
                                                    </div>
                                                </div>
                                                <div class="col-md-12">
                                                    <div class="owl-carousel owl-theme">
                                                        <asp:Literal ID="ltrListMon" runat="server"></asp:Literal>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <!-- Similar Ends Here -->
</asp:Content>

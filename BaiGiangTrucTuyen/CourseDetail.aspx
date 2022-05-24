<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CourseDetail.aspx.cs" Inherits="BaiGiangTrucTuyen.CourseDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <!-- Page Content -->
    <!-- Single Starts Here -->
    <div class="single-product">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="section-heading">
              <div class="line-dec"></div>
              <h1>
                  <asp:Literal ID="ltrTenMon" runat="server"></asp:Literal></h1>
                <h6 style="color:deepskyblue">Lớp TC:   
                    <asp:Literal ID="ltrTenLopTC" runat="server"></asp:Literal></h6>
            </div>
          </div>
          <div class="col-md-6">
          
                <img src="assets/images/khoahoc2.jpg" />
    
          </div>
          <div class="col-md-6">
            <div class="right-content">
              <h4>Giảng viên:
                  <asp:Literal ID="ltrTenGV" runat="server"></asp:Literal></h4>
              <h6>Liên hệ: 
                  <asp:Literal ID="ltrEmailGV" runat="server"></asp:Literal></h6>
              <p></p>
              
  <%--              <input type="submit" class="button" value="Đăng ký môn">--%>
              
            </div>
          </div>
        </div>
      </div>
    </div>
    <!-- Single Page Ends Here -->
    <div class="featured-items">
        <div class="container">
          <div class="row">
            <div class="col-md-12">
              <div class="section-heading">
                <div class="line-dec"></div>
                <h1>Tài liệu môn học</h1>
              </div>
            </div>
            <div class="row">
            <asp:GridView ID="GridView2" runat="server"  CssClass="table table-bordered table-hover col-md-12"  AutoGenerateColumns="False" >
            <Columns>
                <asp:TemplateField HeaderText="Tên tài liệu" ShowHeader="False">
                    
                    <ItemTemplate>
                            <asp:LinkButton ID="LinkButton" runat="server" 
                                    CausesValidation="False" 
                                    CommandArgument='<%# Eval("Tên tài liệu") %>'
                                    CommandName="Delete" Text='<%# Eval("Tên tài liệu") %>'></asp:LinkButton>
                    </ItemTemplate>
                    </asp:TemplateField>
            </Columns>
            </asp:GridView>
                <asp:GridView ID="GridView1" runat="server" CssClass="table table-bordered table-hover col-md-12"  AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand"  >
                    <Columns>
                        <asp:TemplateField HeaderText="Danh sách tài liệu" ShowHeader="False">
                            <ItemTemplate>

                                <asp:LinkButton ID="LinkButton1" runat="server" 
                                    CausesValidation="False" 
                                    CommandArgument='<%# Eval("Danh sách tài liệu") %>'
                                    CommandName="Download" Text='<%# Eval("Danh sách tài liệu") %>'></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>

            </div>
          </div>
        </div>
      </div>

    <!-- Similar Starts Here -->
    <div class="featured-items">
      <div class="container">
        <div class="row">
          <div class="col-md-12">
            <div class="section-heading">
              <div class="line-dec"></div>
              <h1>Những môn học khác</h1>
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

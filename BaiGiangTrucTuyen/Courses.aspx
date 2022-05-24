<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Courses.aspx.cs" Inherits="BaiGiangTrucTuyen.Courses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="featured-page">
      <div class="container pb-4">
        <div class="row">
          <div class="col-md-6 col-sm-12">
            <div class="section-heading">
              <div class="line-dec"></div>
              <h1>Tất cả các môn học</h1>
            </div>
          </div>
          <div class="col-md-6 col-sm-12">
            <div id="filters" class="button-group" style="display:flex">
                <asp:TextBox ID="txtTimKiem" CssClass="form-control" runat="server"></asp:TextBox>
                 <asp:Button ID="btnTimKiem" runat="server" Text="Tìm kiếm" CssClass="btn btn-success" OnClick="btnTimKiem_Click" />
            </div>
          </div>
        </div>
      </div>
    </div>
  
    <div class="featured container no-gutter mt-5 mb-5">

        <div class="row posts">
            <asp:Literal ID="ltrListMon" runat="server"></asp:Literal>
        </div>
    </div>

</asp:Content>

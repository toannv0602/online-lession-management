<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdMasterPage.Master" AutoEventWireup="true" CodeBehind="DocumentManager.aspx.cs" Inherits="BaiGiangTrucTuyen.Admin.DocumentManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="text-align:center"> Thêm tài liệu</h1>
    <div style="width:400px; height:300px; margin-left:450px; border:solid 1px;padding-top:75px;padding-left:50px;" >
        <asp:DropDownList ID="DDLMon" runat="server"></asp:DropDownList>
          <asp:DropDownList ID="DDLLop" runat="server"></asp:DropDownList>
            <asp:TextBox ID="txtTenTL" runat="server"></asp:TextBox>
           <asp:FileUpload ID="FileUpload" runat="server" />
          <asp:Button Text="Thêm tài liệu" ID="btnUpLoad" runat="server" OnClick="btnUpLoad_Click" />
    </div>
    <div>
        <h1>Danh sách các file theo Môn</h1>

        <asp:Button ID="btnXemTL" Text="Xem danh sách tài liệu" runat="server" OnClick="btnXemTL_Click" />
    </div>
    <div class="row mr-5">
          <asp:GridView ID="GridView1" runat="server"  CssClass="table table-bordered table-hover mr-5 col-md-12"  AutoGenerateColumns="False" >
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
             <asp:GridView ID="GridView" runat="server" CssClass="table table-bordered table-hover col-md-12"  AutoGenerateColumns="False" OnRowCommand="GridView_RowCommand"  >
                    
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
</asp:Content>
    
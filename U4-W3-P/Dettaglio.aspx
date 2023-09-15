<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="U4_W3_P.Dettaglio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="messaggio" runat="server" class="alert alert-success text-center" style="display: none;"></div>
    <div class="container d-flex justify-content-center align-items-center" style="height: 80vh;">
        <div class="card" style="width: 20rem;">
            <asp:Image ID="Image1" runat="server" CssClass="card-img-top" />
            <div class="card-body">
                <h5 ID="NomeProdotto" runat="server" class="card-title"></h5>
                <p ID="Descrizione" runat="server" class="card-text"></p>
                <p ID="Prezzo" runat="server"></p>
                <asp:Button ID="Carrello" runat="server" Text="Aggiungi al carrello" OnClick="Carrello_Click" CssClass="btn btn-primary"/>
            </div>
        </div>
    </div>
    
</asp:Content>

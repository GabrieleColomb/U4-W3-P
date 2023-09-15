<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U4_W3_P.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row justify-content-between">
            <asp:Repeater ID="Repeater1" runat="server" ItemType="U4_W3_P.Prodotto">
                <ItemTemplate>
                    <div class="col-lg-4 col-md-6 col-sm-12 mb-4">
                        <div class="card">
                            <img src="<%# Item.Immagine %>" class="card-img-top" alt="...">
                            <div class="card-body">
                                <h5 class="card-title"><%# Item.Nome %></h5>
                                <p class="card-text"><%# Item.Prezzo.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("it-IT")) %></p>
                                <a href="Dettaglio.aspx?IDProdotto=<%# Item.ID %>" class="btn btn-primary">Dettaglio della maglia</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U4_W3_P.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center mt-5">
        <asp:Repeater ID="Repeater1" runat="server" ItemType="U4_W3_P.Prodotto">
            <ItemTemplate>
                <div class="card mb-3">
                    <div class="card-body">
                        <h5 class="card-title"><%# Item.Nome %></h5>
                        <p class="card-text">Prezzo: €<%# string.Format("{0:0.00}", Item.Prezzo) %></p>
                        <asp:Button ID="Elimina" runat="server" Text="Elimina" CssClass="btn btn-danger" CommandName="Elimina" CommandArgument='<%# Item.Nome %>' OnCommand="Elimina_Command" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        <p class="bg-light p-2"><strong>Totale spesa:</strong><span ID="SpesaTotale" runat="server"></span></p>
        <asp:Button ID="SvuotaBtn" runat="server" Text="Svuota Carrello" CssClass="btn btn-danger" OnClick="SvuotaBtn_Click" />
    </div>
</asp:Content>
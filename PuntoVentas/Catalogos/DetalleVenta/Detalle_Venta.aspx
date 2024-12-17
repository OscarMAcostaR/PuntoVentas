<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle_Venta.aspx.cs" Inherits="PuntoVentas.Catalogos.DetalleVenta.Detalle_Venta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    
       <div class="container">
       <div class="row">
           <h3>Detalle de venta</h3>
         
       </div>
       <div class="row">
           <asp:GridView ID="GVDetVentas" runat="server" CssClass="table table-bordered table-condensed table-striped" AutoGenerateColumns="false" DataKeyNames="Id_detalle" OnRowCommand="GVDetVentas_RowCommand">

               <Columns>
                   <asp:BoundField DataField="id_detalle" HeaderText="id_detalle" ItemStyle-Width="50px" ReadOnly="true" />

                   <asp:BoundField DataField="id_venta" HeaderText="id_venta" ItemStyle-Width="50px" ReadOnly="true" />

                   <asp:BoundField DataField="id_producto" HeaderText="id_producto" ItemStyle-Width="50px" ReadOnly="true" />

                   <asp:BoundField DataField="cantidad" HeaderText="cantidad" ItemStyle-Width="50px" ReadOnly="true" />

                    <asp:BoundField DataField="subtotal" HeaderText="subtotal" ItemStyle-Width="50px" ReadOnly="true" />

                   <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Editar" ShowHeader="true" Text="Editar" ControlStyle-CssClass="btn btn-primary btn-xs" ItemStyle-Width="50px" />

               </Columns>
           </asp:GridView>
       </div>
   </div>

</div>




</asp:Content>

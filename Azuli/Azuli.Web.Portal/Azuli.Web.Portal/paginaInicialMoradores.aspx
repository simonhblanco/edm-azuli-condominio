﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="paginaInicialMoradores.aspx.cs" Inherits="Azuli.Web.Portal.paginaInicialMoradores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            font-family: "Segoe UI";
            font-size: medium;
        }
        .style2
        {
            font-family: "Segoe UI";
            font-size: medium;
            font-weight: bold;
        }
        .style4
        {
            width: 442px;
        }
        .style5
        {
            color: #0033CC;
            font-family: "Segoe UI";
            font-size: medium;
            text-decoration: underline;
        }
        .style6
        {
            width: 112px;
        }
        .style3
        {
            width: 33px;
            height: 27px;
        }
        .style7
        {
            font-family: "Segoe UI";
            font-weight: normal;
            font-size: small;
            font-variant: normal;
        }
        .style8
        {
            font-weight: normal;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"><br /><br /><br />
 <table style="text-align: justify; height: 84px; width: 683px;">
            <tr>
                <td align="center" class="style6">
                    <img src="images/azuli.jpg" style="width: 105%; height: 70px" />         
                </td>
                <td class="style4">
             <h1> &nbsp; Senhor(ª) <asp:Label ID="lblMorador" 
                        runat="server" ForeColor="Blue"></asp:Label>&nbsp;<span class="style7">- Você tem
                 <span class="style8">
                        <asp:Label ID="lblMsg" runat="server" style="color: #000099" 
                            Text="0"></asp:Label>
&nbsp;mensagens&nbsp;
                        <img alt="" class="style3" src="images/correio.jpg" /></span></span></h1>
                </td>
            </tr>
       </table>  
       
      <center> <P class="style5"> Seja bem vindo a intranet do Condominio Spazio Campo Azuli.</P></center>
    <P class="style1"> Através do menu acima, é permitido fazer reservas do salão de festa / Churrasqueira e abrir ocorrências, e consultar informações referente ao condominio, como balancete do mês, estatuto e entre mais informações importantes.
       </P>
       
       <p class="style2">
            Informações importantes sobre o spazio Azuli no link abaixo:
       </p>
      <li style="color:#000080"> <asp:LinkButton ID="link1"  runat="server">Baixar o Statuto do Condominio</asp:LinkButton></li>
  <br />
        
      <li style="color:#000080"> <asp:LinkButton ID="Link2" runat="server">Consultar Nomes e contatos: Sindico/Subsindico e Conselheiros</asp:LinkButton></li>
    <br />
      <li style="color:#000080"><asp:LinkButton ID="Link3" runat="server">Consultar prestação de contas do condominio (Balancete simplificado)</asp:LinkButton></li>
    <br />
      <li style="color:#000080"> <asp:LinkButton ID="link4" runat="server">Consultar Nomes e contatos/funções dos funcionários do Condominio</asp:LinkButton></li>

            
         <br />
        <p>
            A Solução permite gerenciar, de modo on-line, todas as funcionalidades, em um ambiente seguro e robusto.
        </p>
                

</asp:Content>
﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="Azuli.Web.Portal.contato" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style2
        {
            color: #666666;
            font-weight: bold;
            font-size: small;
        }
        .style3
        {
            font-family: Verdana;
            font-size: small;
            font-weight: 700;
            color: #666666;
            text-align: center;
            border: 1px solid #4B6C9E;
            cursor: auto;
            margin-top: 16px;
        }
        .style4
        {
            background-color: #F0F0F0;
            border-left: 2px solid #999999;
            border-right: 2px solid #999999;
            border-botom: 2px solid #999999;
            padding: 5px 5px 5px 5px;
            font-family: Verdana;
            font-size: 10pt;
            color: #666666;
            border-radius: 1em;
            height: 15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<fieldset class="loginDisplayLegend">
   
    <legend title="Abrir Ocorrência" class="style4"> Deixe aqui seu comentário, opinião e sugestão:</legend><br />
   
   
   <center>
  <div id="dvCadastro" runat="server" align="center" > 
   
      <table 
          class="accordionContent">
            <tr>
                <td class="" align="center">
                    <table class="style1" border='0'>
                        <tr>
                            <td class="">
                                <asp:Label ID="lblBloco" runat="server" CssClass="style5" Text="Bloco:" 
                                    Font-Bold="True" style="color: #666666; font-weight: bold; font-size: medium"></asp:Label>
                            </td>
                            <td class="" align="left">
&nbsp;<asp:Label ID="lblDescBloco" runat="server" CssClass="style5" 
                                    style="color: #0000FF; font-weight: bold; font-size: medium"></asp:Label>
&nbsp;-
                                <asp:Label ID="lblAp" runat="server" CssClass="style6" style="font-weight: bold; color: #666666; font-size: medium;" 
                                    Text="Apartamento:"></asp:Label>
&nbsp;<asp:Label ID="lblDescApartamento" runat="server" CssClass="style5" 
                                    style="color: #0000FF; font-weight: bold; font-size: medium"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                <asp:Label ID="lblAssunto" runat="server" Font-Bold="True" Text="Assunto:" 
                                    CssClass="style2"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="drpListSubject" runat="server" Height="29px" Width="609px" 
                                    CssClass="style3"> 
                                
                                    <asp:ListItem Value="-1">Selecionar assunto ..</asp:ListItem>
                                    <asp:ListItem Value="1">Sugestões</asp:ListItem>
                                    <asp:ListItem Value="3">Reportar Problemas do site</asp:ListItem>
                                    <asp:ListItem Value="4">Comentários</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style14">
                                <asp:Label ID="lblDescricao" runat="server" Font-Bold="True" 
                                    Text="Descrição" CssClass="style2"></asp:Label>
                            </td>
                            <td class="style14">
                                 <asp:TextBox ID="txtDescription" runat="server" Height="88px" TextMode="MultiLine" 
                                     Width="602px" ValidationGroup="validaDescricao"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="">
                                &nbsp;</td>
                            <td class="">
                                &nbsp;</td>
                            
                        </tr>
                        </table>
                    <br />
                    
                    <asp:Button ID="btnCadastro" runat="server" CssClass="botao" Text="Ok" 
                        Width="150px"  
                        ValidationGroup="validaDescricao" onclick="btnCadastro_Click" />
&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="btnLimpar" runat="server" CssClass="botao" 
                        Text="Limpar Campos" ValidationGroup="validaDescricao" 
                        onclick="btnLimpar_Click" />
                </td>
            </tr>
        </table>
                                 <br />
                                 <asp:RequiredFieldValidator ID="rfvDescription" runat="server" 
                                     ControlToValidate="txtDescription" ErrorMessage="Favor descrever seu comentário!" 
                                     Font-Bold="True" ForeColor="Red" 
          ValidationGroup="validaDescricao"></asp:RequiredFieldValidator>
    
      <center>

          <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label></center>
    </div>
     </center>
   
 </fieldset> 
 
 <center>
</center>
    
</asp:Content>

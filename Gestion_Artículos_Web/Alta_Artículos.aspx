<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Alta_Artículos.aspx.cs" Inherits="Gestion_Artículos_Web.Alta_Artículos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Alta Artículos</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js" integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js" integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="row">
                    <div class="col">
                        <h1>Alta Artículos</h1>
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <div class="form-group">
                            <label for="exampleInputEmail1">Email address</label>
                            <asp:TextBox ID="txtemail" CssClass="form-control" runat="server" />
                            <%--<input type="email" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp">--%>
                            <small id="emailHelp" class="form-text text-muted">Tu Email tiene que estar vigente.</small>
                        </div>
                        <div class="form-group">
                            <label>Password</label>
                            <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" />
                        </div>
                        <div class="form-group form-check">
                            <asp:CheckBox Text="text" runat="server" />
                            <%--<input type="checkbox" class="form-check-input" id="exampleCheck1">--%>
                            <label class="form-check-label" for="exampleCheck1">Check me out</label>
                        </div>
                        <asp:Button Text="Aceptar" ID="btnAceptar" CssClass="btn btn-primary" runat="server" OnClick="btnAceptar_Click" />
                        <%--<button type="submit" class="btn btn-primary">Submit</button>--%>

                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>

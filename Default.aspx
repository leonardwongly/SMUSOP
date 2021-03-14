<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SMUSOP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-BmbxuPwQa2lc/FVzBcNJ7UAyJxM6wuqIj61tLrc4wSX0szH/Ev+nYRRuWlolflfl" crossorigin="anonymous" />
    <!-- JavaScript Bundle with Popper -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta2/dist/js/bootstrap.bundle.min.js" integrity="sha384-b5kHyXgcpbZJO/tY9Ul7kGkf1S0CWuKcCD38l8YkeH8z8QjE0GmW1gYU5S9FOnJ0" crossorigin="anonymous"></script>
    <title>SMUSOP</title>

</head>
<body>
    <div class="row">
        <div class="container">
            <h2 style="text-align: center">SMU SOP</h2>
            <br />
            <div class="row align-items-start">
                <div class="col-s12">
                    <div class="col-12">
                        <div class="row">
                            <div class="col-2 offset-2">
                                <div style="background-color: lightgreen; width: 150px; padding: 10px; margin-right: 30px; color: black; font-size: 13px; font-weight: bold; text-align: center;">Available</div>
                            </div>
                            <div class="col-2">
                                <div style="background-color: orange; width: 150px; padding: 10px; margin-right: 30px; color: black; font-size: 13px; font-weight: bold; text-align: center">Occupied by Object</div>
                            </div>
                            <div class="col-4">
                                <div style="background-color: red; width: 150px; padding: 10px; color: white; font-size: 13px; font-weight: bold; text-align: center;">Occupied by Human</div>
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row" style="margin-top:50px;">
                        <div class="col-8 offset-4">


                            <asp:Label ID="pin1" runat="server" Style="width: 150px; height: 150px;padding:50px;">Seat 1</asp:Label>
                            
                            <asp:Label ID="pin2" runat="server" Style="width: 150px; height: 150px;padding:50px;">Seat 2</asp:Label>
                            
                            <asp:Label ID="pin3" runat="server" Style="width: 150px; height: 150px;padding:50px;">Seat 3</asp:Label>

                        </div>

                    </div>

                </div>
            </div>
        </div>


    </div>

</body>
</html>

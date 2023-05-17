<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Descarga.aspx.cs" Inherits="AplicacionWebAdministrador.Index" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="cache-control" content="no-cache, no-store, must-revalidate" />
    <meta http-equiv="Pragma" content="no-cache" />
    <meta http-equiv="Expires" content="0" />
    <script src="https://kit.fontawesome.com/a3c9717c3d.js" crossorigin="anonymous"></script>
    <link href="./css/EstilosInicio.css" rel="stylesheet" />
    <title>Inicio</title>
</head>
<body>
    <!-- #endregion -->
    <!-- #region Principal-->
    <main class="main">
        <!--Menu inicial-->
        <section class="home container" id="home">
            <div class="swiper home-swiper">
                <div class="swiper-wrapper">
                    <div class="home__content grid">
                        <div class="home__group">
                            <img
                                src="./images/Telefono.png"
                                alt=""
                                class="home__img" />
                        </div>
                        <form id="form1" runat="server">
                            <div class="Area-Input_Button">
                                <div class="about__data">
                                    <asp:Button class="button" CssClass="Download__apk" runat="server" Text="Descargar Aplicación" OnClick="Descargar" />
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
        <!-- #endregion -->
        <a href="#" class="scrollup" id="scroll-up">
            <i class="bx bx-up-arrow-alt scrollup__icon"></i>
        </a>

        <!--Deslizar elementos en una lista-->
        <script src="https://cdn.jsdelivr.net/npm/swiper@8/swiper-bundle.min.js"></script>

        <script src="./Dom/DOMinicio.js">

        </script>
</body>
</html>

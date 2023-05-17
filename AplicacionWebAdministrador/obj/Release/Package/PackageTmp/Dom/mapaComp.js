const origen = { lat: 19.696076, lng: -99.064347 };

//lOCAL
let ubicacionM;
let infoVentana;
let ubicacionComp;
//Google
let map;
let directionsService;
let directionsRenderer;
//

function initMap() {
    directionsService = new google.maps.DirectionsService();
    directionsRenderer = new google.maps.DirectionsRenderer();

    //infoVentana = new google.maps.InfoWindow({
    //    content: contenidoString,
    //    //ariaLabel: "Marcador CUSTOM",
    //});

    //Inicializar el MAPA
    map = new google.maps.Map(document.getElementById("map"), {
        center: origen,
        zoom: 15,
    });


    //Marcador de origen...
    const marcadorUno = new google.maps.Marker({
        position: origen,
        map: map,
        icon: "images/marcador/64.png",
        animation: google.maps.Animation.DROP,
        title: "Este es el punto de origen...",
        label: "Origen",
    });
    directionsRenderer.setMap(map);
}

marcadores();

function marcadores() {
    //Petición para la BD que retorna un JSON con los registros....
    fetch("/Pedidos/MostrarPedido")
        .then(response => response.json())
        .then(data => {

            var infoVentana = new google.maps.InfoWindow();

            // Procesar la lista de pedidos en JavaScript
            var pedidos = data;
            pedidos.forEach(function (pedido) {
                const contenidoStringA =
                    '<b>ID pedido: </b>' + pedido.PedidoID +
                    '<br />' +
                    '<b>Cliente: </b>' + pedido.ClienteNombre +
                    '<br />' +
                    '<b>Tel: </b>' + pedido.ClienteNumeroTelefono +
                    '<br />' +
                    '<b>Repartidor: </b>' + pedido.RepartidorNombre;
                //Crear un marcador 
                ubicacionM = { lat: parseFloat(pedido.LatitudPedido), lng: parseFloat(pedido.LongitudPedido) };
                //var idString 
                var marcadorC = new google.maps.Marker({
                    position: ubicacionM,
                    map: map,
                    icon: "images/marcador/32.png",
                    animation: google.maps.Animation.DROP,
                    label: pedido.PedidoID.toString(),
                    //labelColor: '#FF0000',
                    //label: etiquetas[etiquetaIndice++ % etiquetas.length],
                    id: pedido.PedidoID,
                });


                marcadorC.addListener("click", (event) => {
                    pedidoID = marcadorC.id;
                    if (pedido.RepartidorNombre == null) {
                        infoVentana.setContent(contenidoStringS);

                    }
                    else {
                        infoVentana.setContent(contenidoStringA);

                    }
                    infoVentana.open({
                        anchor: marcadorC,
                        map,
                    });
                });

            });
        });
}
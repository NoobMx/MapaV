const origen = { lat: 19.696076, lng: -99.064347 };
//Google
let map;
let directionsService;
let directionsRenderer;
//lOCAL
let ubicacionM;
let infoVentana;
//
var pedidoID;
//Caracteres e indíce
//const etiquetas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//let etiquetaIndice = 0;

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

//Función para abrir el modal
function abrirModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "block";
}

function asignarRepartidor() {
    const myListBox = document.getElementById("myListBox");
    var btnEnviar = document.getElementById("enviarRepartidor");

    btnEnviar.addEventListener("click", function () {
        var selectedOption = myListBox.options[myListBox.selectedIndex];
        var pedido = {
            ID: pedidoID,
            RepartidorID: selectedOption.value,
        }
        const url = "/Pedidos/AsignarRepartidor";
        const options = {
            method: "POST",
            headers: {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(pedido),
        };

        // Validar que se haya seleccionado una opción antes de enviar los datos
        if (selectedOption.value === "") {
            // Si no se ha seleccionado una opción, mostrar una alerta y no enviar nada
            alert("Por favor, seleccione una opción.");
            return false;
        } else {
            // Si se ha seleccionado una opción, enviar los datos
            fetch(url, options)
                .then(response => response.json())
                .then(data => {
                    if (Boolean(data)) // Convert the response to a boolean value
                    {
                        alert("Repartidor Asignado");
                        cerrarModal();
                        location.reload();

                    }
                    return true;
                });
        }
    });
}

//Función para cerrar el modal
function cerrarModal() {
    var modal = document.getElementById("myModal");
    modal.style.display = "none";
}

//Cerrar el modal cuando se hace clic fuera del contenido del modal
window.onclick = function (event) {
    var modal = document.getElementById("myModal");
    if (event.target == modal) {
        console.log(cerrarModal);
        cerrarModal();
        marcadores();
    }
}

marcadores();

function marcadores() {
    fetch("/Pedidos/mostrarRepartidor")
        .then(response => response.json())
        .then(data => {
            var repartidores = data;
            var listBox = document.getElementById("myListBox");
            repartidores.forEach(function (repartidor) {
                // Crear un nuevo elemento de opción
                var option = document.createElement("option");
                option.text = repartidor.Nombre;
                option.value = repartidor.ID;
                // Agregar el nuevo elemento al ListBox
                listBox.add(option);
            });
            
        });
    //Petición para la BD que retorna un JSON con los registros....
    fetch("/Pedidos/MostrarPedido")
        .then(response => response.json())
        .then(data => {

            var infoVentana = new google.maps.InfoWindow();

            // Procesar la lista de pedidos en JavaScript
            var pedidos = data;
            pedidos.forEach(function (pedido) {
                //Contenido HTML convertido a cadena para ser integrado al la 'InfoWindow' Sin asignar
                const contenidoStringS =
                    '<b>ID pedido: </b>' + pedido.PedidoID +
                    '<br />' +
                    '<b>Cliente: </b>' + pedido.ClienteNombre +
                    '<br />' +
                    '<b>Tel: </b>' + pedido.ClienteNumeroTelefono +
                    '<br />' +
                    '<button Onclick="abrirModal()">Asignar repartidor</button>';
                //Asignado
                const contenidoStringA =
                    '<b>ID pedido: </b>' + pedido.PedidoID +
                    '<br />' +
                    '<b>Cliente: </b>' + pedido.ClienteNombre +
                    '<br />' +
                    '<b>Tel: </b>' + pedido.ClienteNumeroTelefono +
                    '<br />' +
                    '<b>Repartidor: </b>' + pedido.RepartidorNombre
                    '<br />' +
                    '<button Onclick="abrirModal()">Asignar repartidor</button>';
                //Crear un marcador 
                ubicacionM = { lat: parseFloat(pedido.LatitudPedido), lng: parseFloat(pedido.LongitudPedido) };
                var idString 
                var marcadorC = new google.maps.Marker({
                    position: ubicacionM,
                    map: map,
                    //icon: "images/marcador/32.png",
                    animation: google.maps.Animation.DROP,
                    label: pedido.PedidoID.toString(),
                    //labelColor: '#FF0000',
                    //label: etiquetas[etiquetaIndice++ % etiquetas.length],
                    id: pedido.PedidoID,
                });

                if (pedido.RepartidorNombre !== null) {
                    marcadorC.setIcon("https://maps.google.com/mapfiles/ms/icons/green-dot.png");
                } else {
                    marcadorC.setIcon("https://maps.google.com/mapfiles/ms/icons/red-dot.png");
                }


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






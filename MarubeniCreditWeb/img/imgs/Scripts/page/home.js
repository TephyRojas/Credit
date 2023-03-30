
$(document).ready(function () {
    $("#formTrabNos").submit(function (e) {
        return false;
    });

    $('#fileTrabNos').change(function (e) {

        var file = $(this).val();
        var ext = file.substring(file.lastIndexOf("."));
        var fileSize = $(this)[0].files[0].size;
        var siezekiloByte = parseInt(fileSize / 1024);
        var msjExt = "";
        var msjSize = "";

        valido = true;
        if (ext != ".jpeg" && ext != ".jpg" && ext != ".png" && ext != ".pdf" && ext != ".doc" && ext != ".docx") {
            valido = false;
            msjExt = "La extensión no corresponde";
        }

        if (siezekiloByte > 2048) {
            valido = false;
            msjSize = "Tamaño del archivo mayor a 2MB";
        }

        if (valido == false) {
            $('#fileTrabNos').val("");
            $('#fileTrabNosName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#fileTrabNosName').val($(this)[0].files[0].name);
        };

    });
});


function CargaFile() {
    $('#fileTrabNos').click();
};

function recaptchaActDatosCallBack() {
    $("#btnActDatos").prop('disabled', false);
};
function recaptchaTrabNosCallback() {
    $("#btnTrabNos").prop('disabled', false);
};


function MostrarFormActDatos() {
    const url = BASE_PATH + 'Home/MostrarFormActDatos'
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "html",
        success: function (data) {
            if ($('.modal-backdrop').is(':visible')) {
                $('body').removeClass('modal-open');
                $('.modal-backdrop').remove();
            };

            $('#contenedorForm').html(escapeHtml(data));
            $('#formulario').modal('show');
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};

function GuardarActDatos() {
    
    var form = $('#formActDatos')[0];
    var formdata = new FormData(form);


    const url = BASE_PATH + 'Home/GuardarActDatos'
    $.ajax({
        url: url,
        type: "POST",
        data: formdata,
        processData: false,
        contentType: false,
        success: function (response) {
            if (response.respuesta == null) {
                $("#btnActDatos").prop('disabled', true);
                if ($('.modal-backdrop').is(':visible')) {
                    $('body').removeClass('modal-open');
                    $('.modal-backdrop').remove();
                };
                $('#contenedorForm').html(escapeHtml(response));
                $('#formulario').modal('show');

            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

            }

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });


};


function GuardarTrabNos() {
 
    var form = $('#formTrabNos')[0];
    var formdata = new FormData(form);

    const url = BASE_PATH + 'Home/GuardarTrabNos'
    $.ajax({
        url: url,
        type: "POST",
        data: formdata,
        processData: false,
        contentType: false,
        success: function (response) {
            if (response.respuesta) {

                $("#formTrabNos")[0].reset();
                $("#MsjRecibido").removeClass('visually-hidden');
                $("#btnTrabNos").prop('disabled', true);
                setTimeout(function () {                  
                    window.location.reload();
                }, 2000);
 
            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

                if ($('#fileTrabNosName').val() != "") {
                    $('#fileTrabNosName').removeClass("border-1 is-invalid");
                    $('#fileTrabNosName').addClass("border-0");
                }
            }

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });


};

$('#regionCont').change(function () {
    const id = $(this).val();
    const url = BASE_PATH + 'ServicioCliente/GetComunasByRegion'
    if (id == '0') {
        let optionsComunas = "";
        optionsComunas = `<option value=${'0'}>${'Selecciona tu Comuna'}</option>`
        $('#comunaCont').empty().html(optionsComunas);
        return false;
    };
    console.log('id: ' + id);

    $.ajax({
        url: url,
        type: 'GET',
        data: { idRegion: id },
        success: function (response) {
            console.log(response.respuesta);
            if (response.respuesta == null) {
                let options = "";
                $(response).each(function (index, value) {
                    options += `<option value=${value.idComuna}>${value.comuna}</option>`
                });
                $('#comunaCont').empty().html(options);
            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

            }
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
});

$('#regionTrabNos').change(function () {
    const id = $(this).val();
    const url = BASE_PATH + 'ServicioCliente/GetComunasByRegion'
    if (id == '0') {
        let optionsComunas = "";
        optionsComunas = `<option value=${'0'}>${'Selecciona tu Comuna'}</option>`
        $('#comunaTrabNos').empty().html(optionsComunas);
        return false;
    };
    console.log('id: ' + id);

    $.ajax({
        url: url,
        type: 'GET',
        data: { idRegion: id },
        success: function (response) {
            console.log(response.respuesta);
            if (response.respuesta == null) {
                let options = "";
                $(response).each(function (index, value) {
                    options += `<option value=${value.idComuna}>${value.comuna}</option>`
                });
                $('#comunaTrabNos').empty().html(options);
            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

            }
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
});



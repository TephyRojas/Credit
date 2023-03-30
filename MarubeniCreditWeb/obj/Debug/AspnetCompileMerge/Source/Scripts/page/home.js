
$(document).ready(function () {
    $("#formTrabNos").submit(function (e) {
        return false;
    });

    //$('#btnFileTrabNos').click(function (e) {
    //    alert("xxxx");
    //    e.stopPropagation();
    //    e.preventDefault();
    //    e = e || window.event;
    //    if (e.target.id == 'fileTrabNos') {
    //        $($('input[type=file]').get(0)).trigger('click');
    //    }
    //    //
    //    //$('#fileTrabNos').click();
    //});

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

            $('#contenedorForm').html(data);
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
    //formdata.append('nombreActDatos', $("#nombreActDatos").val());
    //formdata.append('rutActDatos', $("#rutActDatos").val());
    //formdata.append('direccionActDatos', $("#direccionActDatos").val());
    //formdata.append('comunaActDatos', $("#comunaActDatos").val());
    //formdata.append('telMovilActDatos', $("#telMovilActDatos").val());
    //formdata.append('telefonoActDatos', $("#telefonoActDatos").val());

    const url = BASE_PATH + 'Home/GuardarActDatos'
    $.ajax({
        url: url,
        type: "POST",
        data: formdata,
        processData: false,
        contentType: false,
        success: function (response) {
            if (response.respuesta == null) {
                if ($('.modal-backdrop').is(':visible')) {
                    $('body').removeClass('modal-open');
                    $('.modal-backdrop').remove();
                };
                $('#contenedorForm').html(response);
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


$(document).ready(function () {

    $('.input-number').on('input', function () {
        this.value = this.value.replace(/[^0-9]/g, '');
    });

    $('.lyrics').on('input', function () {
        this.value = this.value.replace(/[^a-zA-ZñÑÀ-ÿ ]/g, '');
    });

    $('.lyrics-number').on('input', function () {
        this.value = this.value.replace(/[^a-zA-Z0-9ñÑÀ-ÿ. ]/g, '');
    });

    //$('.letras').on('input', function () {
    //    this.value = this.value.replace(/[^a-zA-ZñÑÀ-ÿ ]/g, '');
    //});

    $('.rut').on('input', function () {
        this.value = this.value.replace(/[^0-9-.Kk]/g, '');
    });
    $('.rut2').on('input', function () {
        this.value = this.value.replace(/[^0-9-.Kk]/g, '');
    });


    $(".phone").mask("(+56) 9 9999-9999")



    $("input.rut").rut({
        formatOn: 'keyup',
        minimumLength: 8, // validar largo mínimo; default: 2
        validateOn: 'change' // si no se quiere validar, pasar null
    });

    $("input.rut2").rut({
        formatOn: 'keyup',
        minimumLength: 8, // validar largo mínimo; default: 2
        validateOn: 'change' // si no se quiere validar, pasar null
    });

});


function ValidaRut() {
    var rut = $(".rut").val()

    var isValid = $.validateRut(rut, null, { minimumLength: 8 });
    if (!isValid) {
        
        $(".rut").removeClass("border-0");
        $(".rut").addClass("is-invalid border-1");
  
    }
    else {
        $(".rut").removeClass("is-invalid border-1");
        $(".rut").addClass("border-0");
    }

};

function ValidaRut2() {
    var rut = $(".rut2").val()

    var isValid = $.validateRut(rut, null, { minimumLength: 8 });
    if (!isValid) {
        $(".rut2").removeClass("border-0");
        $(".rut2").addClass("is-invalid border-1");
    }
    else {
        $(".rut2").removeClass("is-invalid border-1");
        $(".rut2").addClass("border-0");
    }

};

function escapeHtml(string) {
    return String(string).replace(/[&]/g, function (s) {
        return entityMap[s];
    });
}


function ModContactoPaso2() {
    $("#modContactoPaso1").addClass('visually-hidden');
    $("#modContactoPaso2").removeClass('visually-hidden');
};

function ModCertPaso1() {
    $("#modCertPaso2").addClass('visually-hidden');
    $("#modCertPaso1").removeClass('visually-hidden');
};

function ModCertPaso2() {

    $("#modCertPaso1").addClass('visually-hidden');
    var certificado = $('input[name="rdbCertificado"]:checked').val();

    if (certificado == 'Certificado de prepago') {
        $("#modCertPaso2").removeClass('visually-hidden');
    }
    else {
        $("#modCertPaso3").removeClass('visually-hidden');
    }

};

function ModCertPaso3() {
    $("#modCertPaso2").addClass('visually-hidden');
    $("#modCertPaso3").removeClass('visually-hidden');
};

function ModPortCertPaso2() {
    $("#modPortCertPaso1").addClass('visually-hidden');
    $("#modPortCertPaso2").removeClass('visually-hidden');
};

function displayErrors(errors) {
    $.each(errors, function (idx, control) {
        var arr = control.split('|');
        var msj = arr[0];
        var obj = arr[0];

        if (arr[1] != "NOERROR") {
            //alert(obj);
            $(msj).text(arr[1]);
            if (obj.indexOf("file") == -1) {
                $("#" + obj).removeClass("border-0");
                $("#" + obj).addClass("is-invalid border-1");
            }
            else {
                $("#" + obj + "Name").removeClass("border-0");
                $("#" + obj + "Name").addClass("is-invalid border-1");
            }

        }
        else {

            if (obj.indexOf("file") == -1) {
                $("#" + obj).removeClass("border-1 is-invalid");
                $("#" + obj).addClass("border-0");
            }
            else {
                $("#" + obj + "Name").removeClass("border-1 is-invalid");
                $("#" + obj + "Name").addClass("border-0");
            }
        }

    });


};

function ShowCondiciones(item) {


    LimpiarCollapse();
    $("#titulo" + item + "modalCO").addClass("fw-bold");
    $("#collapse" + item + "modalCO").collapse("show");

};

$('#modalCO').on('hidden.bs.modal', function () {
    LimpiarCollapse();
})

function LimpiarCollapse() {
    for (var i = 1; i < 11; i++) {
        $("#titulo" + i + "modalCO").removeClass("fw-bold");
        $("#collapse" + i + "modalCO").collapse("hide");
    }
}

$('#regionCert').change(function () {
    const id = $(this).val();
    console.log(id);
    const url = BASE_PATH + 'ServicioCliente/GetComunasByRegion'
    if (id == '0') {
        let optionsComunas = "";
        optionsComunas = `<option value=${'0'}>${'Selecciona tu Comuna'}</option>`
        $('#comunaCert').empty().html(optionsComunas);
        return false;
    };
    console.log('id: ' + id);

    $.ajax({
        url: url,
        type: 'GET',
        data: { idRegion: id },
        success: function (response) {
            if (response.respuesta == null) {
                let options = "";
                $(response).each(function (index, value) {
                    options += `<option value=${value.idComuna}>${value.comuna}</option>`
                });
                $('#comunaCert').empty().html(options);
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

$('#regionPortCert').change(function () {
    const id = $(this).val();
    console.log(id);
    const url = BASE_PATH + 'ServicioCliente/GetComunasByRegion'
    if (id == '0') {
        let optionsComunas = "";
        optionsComunas = `<option value=${'0'}>${'Selecciona tu Comuna'}</option>`
        $('#comunaPortCert').empty().html(optionsComunas);
        return false;
    };
    console.log('id: ' + id);

    $.ajax({
        url: url,
        type: 'GET',
        data: { idRegion: id },
        success: function (response) {
            if (response.respuesta == null) {
                let options = "";
                $(response).each(function (index, value) {
                    options += `<option value=${value.idComuna}>${value.comuna}</option>`
                });
                $('#comunaPortCert').empty().html(options);
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
$(document).ready(function () {

    $('.input-number').on('input', function () {
        this.value = this.value.replace(/[^0-9]/g, '');
    });

    $('.rut').on('input', function () {
        this.value = this.value.replace(/[^0-9-.Kk]/g, '');
    });
    $('.rut2').on('input', function () {
        this.value = this.value.replace(/[^0-9-.Kk]/g, '');
    });


    //$('#btnModContacto1').click(function (e) {
    //    alert("entra");
    //    $("#modContactoPaso1").addClass('visually-hidden');
    //    $("#modContactoPaso2").removeClass('visually-hidden');
    //});

    //$(".rut").mask('Regex', { regex: "[0-9-.Kk]{10}" });
    /* $(".phone").mask("(99) 9999?9-9999");*/

    $(".phone").mask("(+56) 9 9999-9999")

    //$(".rut").on("blur", function () {
    //    var last = $(this).val().substr($(this).val().indexOf("-") + 1);

    //    if (last.length == 3) {
    //        var move = $(this).val().substr($(this).val().indexOf("-") - 1, 1);
    //        var lastfour = move + last;
    //        var first = $(this).val().substr(0, 9);

    //        $(this).val(first + '-' + lastfour);
    //    }
    //


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


    //$(".rut").on("blur", function (e) {
    //    e.preventDefault()
    //    var rut = $(this).val()
    //    alert(rut);

    //    //var dv = computeDv(rut);
    //    var isValid = $.validateRut(rut, null, { minimumLength: 8 });
    //    if (!isValid) {
    //        $(".btn-envio").prop('disabled', true);
    //        $(".rut").removeClass("border-0");
    //        $(".rut").addClass("is-invalid border-1");
    //    }
    //    else {
    //        $(".rut").removeClass("is-invalid border-1");
    //        $(".rut").addClass("border-0");
    //    }
    //    alert("isValid: " + isValid)

    //});
    ///*    $(".rut").mask("99999999-9");*/



});

function ValidaRut() {
    var rut = $(".rut").val()
    //alert(rut);

    //var dv = computeDv(rut);
    var isValid = $.validateRut(rut, null, { minimumLength: 8 });
    if (!isValid) {
       /* $(".btn-envio").prop('disabled', true);*/
        $(".rut").removeClass("border-0");
        $(".rut").addClass("is-invalid border-1");
/*        $(".rut").focus();*/
    }
    else {
        $(".rut").removeClass("is-invalid border-1");
        $(".rut").addClass("border-0");
    }

};

function ValidaRut2() {
    var rut = $(".rut2").val()
    //alert(rut);

    //var dv = computeDv(rut);
    var isValid = $.validateRut(rut, null, { minimumLength: 8 });
    if (!isValid) {
        $(".rut2").removeClass("border-0");
        $(".rut2").addClass("is-invalid border-1");
        /*        $(".rut").focus();*/
    }
    else {
        $(".rut2").removeClass("is-invalid border-1");
        $(".rut2").addClass("border-0");
    }

};

//function computeDv(rut) {
//    var suma = 0;
//    var mul = 2;
//    if (typeof (rut) !== 'number') { return; }
//    rut = rut.toString();
//    for (var i = rut.length - 1; i >= 0; i--) {
//        suma = suma + rut.charAt(i) * mul;
//        mul = (mul + 1) % 8 || 2;
//    }
//    switch (suma % 11) {
//        case 1: return 'k';
//        case 0: return 0;
//        default: return 11 - (suma % 11);
//    }
//}


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
    alert(certificado);

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

$(document).ready(function () {


    $("#formCertificado3").submit(function (e) {
        return false;
    });

    $('#btnFile1Cert').click(function (e) {
        e.preventDefault()
        $('#file1Cert').click();
    });

    $('#file1Cert').change(function (e) {

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
            $('#file1Cert').val("");
            $('#file1CertName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file1CertName').val($(this)[0].files[0].name);
            $("#btnModFormCertificado2").prop('disabled', false);
        };

    });

    $('#btnFile2Cert').click(function (e) {
        e.preventDefault()
        $('#file2Cert').click();
    });

    $('#file2Cert').change(function (e) {

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
            $('#file2Cert').val("");
            $('#file2CertName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file2CertName').val($(this)[0].files[0].name);
        };

    });

    $('#btnFile1PortCert').click(function (e) {
        e.preventDefault()
        $('#file1PortCert').click();
    });

    $('#file1PortCert').change(function (e) {

        var file = $(this).val();
        var ext = file.substring(file.lastIndexOf("."));
        var fileSize = $(this)[0].files[0].size;
        var siezekiloByte = parseInt(fileSize / 1024);
        //alert($(this)[0].files[0].name);
        //alert(siezekiloByte / 1024);
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
            $('#file1PortCert').val("");
            $('#file1PortCertName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file1PortCertName').val($(this)[0].files[0].name);
        };

    });


    //UOPLOAD FORMULARIO SOLICITUD PORTABILIDAD

    $('#btnFile1PortSoli').click(function (e) {
        e.preventDefault()
        $('#file1PortSoli').click();
    });

    $('#file1PortSoli').change(function (e) {

        var file = $(this).val();
        var ext = file.substring(file.lastIndexOf("."));
        var fileSize = $(this)[0].files[0].size;
        var siezekiloByte = parseInt(fileSize / 1024);
        //alert($(this)[0].files[0].name);
        //alert(siezekiloByte / 1024);
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
            $('#file1PortSoli').val("");
            $('#file1PortSoliName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file1PortSoliName').val($(this)[0].files[0].name);
        };

    });

    $('#btnFile2PortSoli').click(function (e) {
        e.preventDefault()
        $('#file2PortSoli').click();
    });

    $('#file2PortSoli').change(function (e) {

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
            $('#file2PortSoli').val("");
            $('#file2PortSoliName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file2PortSoliName').val($(this)[0].files[0].name);
        };

    });

    $('#btnFile3PortSoli').click(function (e) {
        e.preventDefault()
        $('#file3PortSoli').click();
    });

    $('#file3PortSoli').change(function (e) {

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
            $('#file3PortSoli').val("");
            $('#file3PortSoliName').val("");
            alert(msjExt + "\n" + msjSize);
        }
        else {
            $('#file3PortSoliName').val($(this)[0].files[0].name);
        };

    });


    
});

function recaptchaContactoCallback() {
    $("#btnModFormContacto2").prop('disabled', false);
};

function recaptchaCertCallback() {
    $("#btnModFormCertificado3").prop('disabled', false);
};

function recaptchaPortSoliCallback() {

    if ($("#chkFirmaPortSoli").is(":checked")) {
        $("#btnFormPortSolicitud1").prop('disabled', false);

        $("#chkFirmaPortSoli").removeClass("is-invalid");
    }
    else {
        $("#btnFormPortSolicitud1").prop('disabled', true);

        $("#chkFirmaPortSoli").addClass("is-invalid");
    }
};

function recaptchaPortCertCallback() {

    if ($("#chkFirmaPortCert").is(":checked")) {
        $("#btnModFormPortCertificado2").prop('disabled', false);

        $("#chkFirmaPortCert").removeClass("is-invalid");
    }
    else {
        $("#btnModFormPortCertificado2").prop('disabled', true);

        $("#chkFirmaPortCert").addClass("is-invalid");
    }
};

function FirmaPortSoli() {
    var recaptcha = grecaptcha.getResponse();

    if ($("#chkFirmaPortSoli").is(":checked")) {

        if (recaptcha != "") {
            $("#btnFormPortSolicitud1").prop('disabled', false);
        }
        
        $("#chkFirmaPortSoli").removeClass("is-invalid");
    }
    else {
        $("#btnFormPortSolicitud1").prop('disabled', true);

        $("#chkFirmaPortSoli").addClass("is-invalid");
    }
};

function FirmaPortCert() {
    var recaptcha = grecaptcha.getResponse();
    if ($("#chkFirmaPortCert").is(":checked")) {
        if (recaptcha != "") {
            $("#btnModFormPortCertificado2").prop('disabled', false);
        }

        $("#chkFirmaPortCert").removeClass("is-invalid");
    }
    else {
        $("#btnModFormPortCertificado2").prop('disabled', true);

        $("#chkFirmaPortCert").addClass("is-invalid");
    }

};


function ValidarTipoConsulta() {
    var tipoConsulta = $("input[name='rdbTipoConsulta']:checked").val();
    if (tipoConsulta.length > 0) {
        $("#btnModFormContacto1").prop('disabled', false);
        $("#tipoConsultaCont").val(tipoConsulta);
    }
}

function ValidarCertificado() {
    var certificado = $("input[name='rdbCertificado']:checked").val();
    if (certificado.length > 0) {
        $("#btnModFormCertificado1").prop('disabled', false);
        $("#certificadoCert").val(certificado);
        $("#rdbCertificado").val(certificado);
        $('#lblCertificado').html('');
        $('#lblCertificado').append(certificado);
    }
}


function ValidarPortCertificado() {
    var certificado = $("input[name='rdbPortCertificado']:checked").val();
    if (certificado.length > 0) {
        $("#btnModFormPortCertificado1").prop('disabled', false);
        $("#certificadoPortCert").val(certificado);
    }
}

//FORMULARIOS CONTACTO

function MostrarFormContacto1() {
    const url = BASE_PATH + 'ServicioCliente/MostrarFormContacto1'

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
            //var modal = Microsoft.Security.Application.AntiXss.HtmlEncode(data);
            //var modal = System.web.HttpUtility.HtmlEncode(data);
/*            var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(response);*/
  
      
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};



function sanitize(string) {
    return string.replace('<scrip>', '&lt;script&gt;')

}

function GuardarContacto() {
    //var formulario = $("#formContacto2").serialize();
    var form = $('#formContacto')[0];
    var formdata = new FormData(form);
    const url = BASE_PATH + 'ServicioCliente/GuardarContacto'
    $.ajax({
        url: url,
        type: 'POST',
        data: formdata,
        processData: false,
        contentType: false,
        success: function (response) {
            if (response.respuesta == null) {
                if ($('.modal-backdrop').is(':visible')) {
                    $('body').removeClass('modal-open');
                    $('.modal-backdrop').remove();
                };

    /*            var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(response);*/
                //$('#contenedorForm').html(modal);
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

//FORMULARIOS CERTIFICADOS
function MostrarFormCertificado1() {
    var url = BASE_PATH + 'ServicioCliente/MostrarFormCertificado1'
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "html",
        success: function (data) {
            if ($('.modal-backdrop').is(':visible')) {
                $('body').removeClass('modal-open');
                $('.modal-backdrop').remove();
            };

            //var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(data);
            //$('#contenedorForm').html(modal);
            $('#contenedorForm').html(data);
            $('#formulario').modal('show');
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};



function GuardarCertificado() {
    var form = $('#formCertificado1')[0];
    var formdata = new FormData(form);
/*    var formdata = new FormData();*/
    //formdata.append('nombreCert', $("#nombreCert").val());
    //formdata.append('apellidoCert', $("#apellidoCert").val());
    //formdata.append('rutCert', $("#rutCert").val());
    //formdata.append('emailCert', $("#emailCert").val());

    //formdata.append('regionCert', $("#regionCert").val());
    //formdata.append('comunaCert', $("#comunaCert").val());
    //formdata.append('direccionCert', $("#direccionCert").val());
    //formdata.append('telMovilCert', $("#telMovilCert").val());

    //formdata.append('operacionCert', $("#operacionCert").val());
    //formdata.append('patenteCert', $("#patenteCert").val());
    //formdata.append('mensajeCert', $("#mensajeCert").val());
    //formdata.append('certificadoCert', $("#certificadoCert").val());
    formdata.append('file1Cert', $('#file1Cert')[0].files[0]);
    //formdata.append('file2Cert', $('#file2Cert')[0].files[0]);



    const url = BASE_PATH + 'ServicioCliente/GuardarCertificado'
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

                //var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(response);
                //$('#contenedorForm').html(modal);
                $('#contenedorForm').html(response);
                $('#formulario').modal('show');


            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

                if ($('#file2CertName').val() != "") {
                    $('#file2CertName').removeClass("border-1 is-invalid");
                    $('#file2CertName').addClass("border-0");
                }

            }

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};

//FORMULARIO SOLICITUD PORTABILIDAD

function MostrarFormPortSolicitud() {
    const url = BASE_PATH + 'ServicioCliente/MostrarFormPortSolicitud'
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "html",
        success: function (data) {
            if ($('.modal-backdrop').is(':visible')) {
                $('body').removeClass('modal-open');
                $('.modal-backdrop').remove();
            };
            //alert('ABRE');

            //var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(data);
            //$('#contenedorForm').html(modal);
            $('#contenedorForm').html(data);
            $('#formulario').modal('show');
            $("#g-recaptcha-id").hide();

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};

function GuardarPortSolicitud() {
    //var formulario = $("#formPortSolicitud").serialize();
    //var form = $('#formPortSolicitud');
    //var formdata = new FormData(form);

    var form = $('#formPortSolicitud')[0];
    var formdata = new FormData(form);

    //var formdata = new FormData();
    //formdata.append('nombrePortSoli', $("#nombrePortSoli").val());
    //formdata.append('rutPortSoli', $("#rutPortSoli").val());
    //formdata.append('telefonoPortSoli', $("#telefonoPortSoli").val());
    //formdata.append('emailPortSoli', $("#emailPortSoli").val());

    //formdata.append('file1PortSoli', $('#file1PortSoli')[0].files[0]);
    //formdata.append('file2PortSoli', $('#file2PortSoli')[0].files[0]);
    //formdata.append('file3PortSoli', $('#file3PortSoli')[0].files[0]);


    //var formdata = 'nombre=' + nombre + '&rut=' + rut + '&telefono=' + telefono + '&email=' + email + '&file=' + file + '&file2=' + file2 + '&file3=' + file3;
    const url = BASE_PATH + 'ServicioCliente/GuardarPortSolicitud'
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

                //var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(response);
                //$('#contenedorForm').html(modal);
                $('#contenedorForm').html(response);
                $('#formulario').modal('show');


            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }
                for (var i = 1; i <= 3; i++) {
                    if ($('#file' + i + 'PortSoliName').val() != "") {
                        $('#file' + i + 'PortSoliName').removeClass("border-1 is-invalid");
                        $('#file' + i + 'PortSoliName').addClass("border-0");
                    }
                }
             
            }

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};


//FORMULARIOS CERTIFICADO PORTABILIDAD

function MostrarFormPortCertificado1() {
    const url = BASE_PATH + 'ServicioCliente/MostrarFormPortCertificado1'
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "html",
        success: function (data) {
            if ($('.modal-backdrop').is(':visible')) {
                $('body').removeClass('modal-open');
                $('.modal-backdrop').remove();
            };

            //var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(data);
            //$('#contenedorForm').html(modal);
            $('#contenedorForm').html(data);
            $('#formulario').modal('show');
        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};


function AddProdFinanc() {

    const url = BASE_PATH + 'ServicioCliente/AgregarProdFinanc'
    $.ajax({
        url: url,
        type: 'POST',
        dataType: "html",
        success: function (data) {

            //var formPF = Microsoft.Security.Application.AntiXss.JavaScriptEncod(data);
            //$('#contProdFinanc').append(formPF);
            $('#contProdFinanc').append(data);

        }
    });
};


function GuardarPortCertificado() {

    var form = $('#formPortCertificado2')[0];
    var formdata = new FormData(form);

    const prodServ = $("input[name='prodServ[]']")
        .map(function () { return $(this).val(); }).get();
    const nroCred = $("input[name='nroCred[]']")
        .map(function () { return $(this).val(); }).get();
    const patente = $("input[name='patente[]']")
        .map(function () { return $(this).val(); }).get();

    var lblCorreoPortCert  = $("#chkCorreoPortCert").is(":checked") ? $("#lblCorreoPortCert").text() : "";

    var lblRetiroPortCert = $("#chkRetiroPortCert").is(":checked") ? $("#lblRetiroPortCert").text() : "";

    //var formdata = new FormData();
    //formdata.append('nombrePortCert', $("#nombrePortCert").val());
    //formdata.append('rutPortCert', $("#rutPortCert").val());
    //formdata.append('emailPortCert', $("#emailPortCert").val());

    //formdata.append('regionPortCert', $("#regionPortCert").val());
    //formdata.append('comunaPortCert', $("#comunaPortCert").val());
    //formdata.append('direccionPortCert', $("#direccionPortCert").val());
    //formdata.append('telMovilPortCert', $("#telMovilPortCert").val());

    //formdata.append('nombreRepPortCert', $("#nombreRepPortCert").val());
    //formdata.append('rutRepPortCert', $("#rutRepPortCert").val());
    //formdata.append('certificadoPortCert', $("#certificadoPortCert").val());

    //formdata.append('file1PortCert', $('#file1PortCert')[0].files[0]);

    formdata.append('prodServPortCert', prodServ);
    formdata.append('nroCredPortCert', nroCred);
    formdata.append('patentePortCert', patente);

    formdata.append('recepCorreoPortCert', lblCorreoPortCert );
    formdata.append('recepRetiroPortCert', lblRetiroPortCert );

    const url = BASE_PATH + 'ServicioCliente/GuardarPortCertificado'
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
       /*         var modal = Microsoft.Security.Application.AntiXss.HtmlAttributeEncode(response);*/
                $('#contenedorForm').html(response);
                $('#formulario').modal('show');


            }
            else {
                if (!response.respuesta) {
                    displayErrors(response.errorControl);
                }

                if ($('#file1PortCertName').val() != "") {
                    $('#file1PortCertName').removeClass("border-1 is-invalid");
                    $('#file1PortCertName').addClass("border-0");
                }

            }

        },
        error: function (xmlResponse) {
            alert("Error en la solicitud del modal")
        }
    });
};





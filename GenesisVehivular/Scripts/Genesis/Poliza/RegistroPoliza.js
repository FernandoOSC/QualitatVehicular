window.onload = function () {    
    Spinner_TipoVehiculo();
    Spinner_TipoUso();
    Spinner_MarcaVehiculo();
    Spinner_ModeloVehiculo(1);
    Spinner_TipoDocumento();
    Spinner_Nacionalidad();
    Spinner_Sexo();
    Spinner_EstadoCivil();
    Spinner_Departamento();
    Spinner_Provincia("01");
    Spinner_Distrito("01", "01");
    Spinner_TipoVia();
    Spinner_TipoPoliza();

    $("select[name=sp_MarcaVehiculo]").change(function () {
        idmarca = $("#sp_MarcaVehiculo").val();
        Spinner_ModeloVehiculo(idmarca);

    });

    $("select[name=sp_Departamento]").change(function () {
        vdepartamento = $("#sp_Departamento").val();
        Spinner_Provincia(vdepartamento);
        Spinner_Distrito(vdepartamento, "01");
 

    });


    $("select[name=sp_Provincia]").change(function () {

        vdepartamento = $("#sp_Departamento").val();
        vprovincia = $("#sp_Provincia").val();

        Spinner_Distrito(vdepartamento, vprovincia);

    });
}

//Llenar Spiners *********************************************************************************

//Tipo Vehiculo:
function Spinner_TipoVehiculo() {

    $.ajax({
        type: "POST",        
        url: "../Services/ListarTipoVehiculo",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_TipoVehiculo,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

   

}

function llenarSpinner_TipoVehiculo(data) {
    var selectAgregar = $("#sp_TipoVehiculo");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Tipo Uso:
function Spinner_TipoUso() {


    $.ajax({
        type: "POST",
        url: "../Services/ListarTipoUso",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_TipoUso,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });



}

function llenarSpinner_TipoUso(data) {
    var selectAgregar = $("#sp_TipoUso");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Marca Vehiculo:
function Spinner_MarcaVehiculo() {


    $.ajax({
        type: "POST",
        url: "../Services/ListarMarcaVehiculo",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_MarcaVehiculo,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });



}

function llenarSpinner_MarcaVehiculo(data) {
    var selectAgregar = $("#sp_MarcaVehiculo");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Modelo Vehiculo:
function Spinner_ModeloVehiculo(id_marca) {

    $.ajax({
        type: "POST",
        url: "../Services/ListarModeloVehiculo",
        data: "{id_marca:'" + id_marca + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_ModeloVehiculo,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_ModeloVehiculo(data) {
    var selectAgregar = $("#sp_ModeloVehiculo");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smidmodelo + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Tipo Documento:
function Spinner_TipoDocumento() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarTipoDocumento",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_TipoDocumento,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_TipoDocumento(data) {
    var selectAgregar = $("#sp_TipoDocumento");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Nacionalidad:
function Spinner_Nacionalidad() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarNacionalidad",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_Nacionalidad,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_Nacionalidad(data) {
    var selectAgregar = $("#sp_Nacionalidad");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Sexo:
function Spinner_Sexo() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarSexo",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_Sexo,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_Sexo(data) {
    var selectAgregar = $("#sp_Sexo");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Estado Civil:
function Spinner_EstadoCivil() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarEstadoCivil",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_EstadoCivil,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_EstadoCivil(data) {
    var selectAgregar = $("#sp_EstadoCivil");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Departamento:
function Spinner_Departamento() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarDepartamento",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_Departamento,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_Departamento(data) {
    var selectAgregar = $("#sp_Departamento");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].vdepartamento + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Provincia:
function Spinner_Provincia(vdepartamento) {

    $.ajax({
        type: "POST",
        url: "../Services/ListarProvincia",
        data: "{vdepartamento:'" + vdepartamento + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_Provincia,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_Provincia(data) {
    var selectAgregar = $("#sp_Provincia");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].vprovincia + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Distrito:
function Spinner_Distrito(vdepartamento, vprovincia) {

    $.ajax({
        type: "POST",
        url: "../Services/ListarDistrito",
        data: "{vdepartamento:'" + vdepartamento + "', vprovincia:'" + vprovincia + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_Distrito,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_Distrito(data) {
    var selectAgregar = $("#sp_Distrito");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].vdistrito + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Tipo Via:
function Spinner_TipoVia() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarTipoVia",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_TipoVia,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_TipoVia(data) {
    var selectAgregar = $("#sp_TipoVia");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//Tipo Poliza:
function Spinner_TipoPoliza() {

    $.ajax({
        type: "POST",
        url: "../Services/ListarTipoPoliza",
        data: "",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: llenarSpinner_TipoPoliza,
        failure: function (response) {
            alert(response.d);
        },
        error: OnError

    });

}

function llenarSpinner_TipoPoliza(data) {
    var selectAgregar = $("#sp_Poliza");
    selectAgregar.empty();

    for (i = 0; i < data.length; i++) {
        selectAgregar.append("<option value='" + data[i].smiddetalle + "'>" + data[i].vdescripcion + "</option>");
    }

}

//End Llenar Spiners *********************************************************************************

//Agregar Registro Poliza ****************************************************************************

function ErrorText(mensaje){
    $('#contenedor_errorMessage').removeClass('Ocultar');
    document.getElementById('errorMessage').innerHTML = mensaje;
}

function SuccesText() {
    $('#contenedor_errorMessage').addClass('Ocultar');
}

function RegistrarPoliza_onclick() {


    var sp_TipoVehiculo = $("#sp_TipoVehiculo").val();
    var sp_MarcaVehiculo = $("#sp_MarcaVehiculo").val();
    var sp_ModeloVehiculo = $("#sp_ModeloVehiculo").val();
    var placa_reg = $("#placa_reg").val();
    var nroasientos_reg = $("#nroasientos_reg").val();
    var sp_anioFabricacion = $("#sp_anioFabricacion").val();
    var nromotor_reg = $("#nromotor_reg").val();
    var sumaasegurada_reg = $("#sumaasegurada_reg").val();
    var vin_reg = $("#vin_reg").val();
    var nroserie_reg = $("#nroserie_reg").val();
    var sp_TipoUso = $("#sp_TipoUso").val();

    var sp_TipoDocumento = $("#sp_TipoDocumento").val();
    var nrodocumento_reg = $("#nrodocumento_reg").val();
    var sp_Nacionalidad = $("#sp_Nacionalidad").val();
    var nombres_reg = $("#nombres_reg").val();
    var paterno_reg = $("#paterno_reg").val();
    var materno_reg = $("#materno_reg").val();
    var fecnaci_reg = $("#fecnaci_reg").val();
    var sp_Sexo = $("#sp_Sexo").val();
    var sp_EstadoCivil = $("#sp_EstadoCivil").val();

    var sp_TipoVia = $("#sp_TipoVia").val();
    var direccion_reg = $("#direccion_reg").val();
    var numeroubi_reg = $("#numeroubi_reg").val();
    var referencia_reg = $("#referencia_reg").val();
    var sp_Departamento = $("#sp_Departamento").val();
    var sp_Provincia = $("#sp_Provincia").val();
    var sp_Distrito = $("#sp_Distrito").val();

    var nropoliza_reg = $("#nropoliza_reg").val();
    var vigenciaini_reg = $("#vigenciaini_reg").val();
    var vigenciafin_reg = $("#vigenciafin_reg").val();
    var sp_Poliza = $("#sp_Poliza").val();
    var sp_Plan = $("#sp_Plan").val();

    var color_reg = $("#color_reg").val();
    var celular_reg = $("#celular_reg").val();
    var telefono_reg = $("#telefono_reg").val();
    var email_reg = $("#email_reg").val();

    var sumaaseguradapost = (parseFloat(sumaasegurada_reg).toFixed(2)).toString();
    //alert(sumaaseguradapost);
    //alert("{smidtablatipopoliza:'" + parseInt(sp_Poliza) + "', vplaca:'" + placa_reg + "', smidmodelo:'" + parseInt(sp_ModeloVehiculo) + "', smaniofabrica:'" + parseInt(sp_anioFabricacion) + "', vmotor:'" + nromotor_reg + "', svin:'" + vin_reg + "', smnroasiento:'" + parseInt(nroasientos_reg) + "', vcolor:'" + color_reg + "', desumaasegurada: '8000.00', smidtablaclasevehiculo:'" + parseInt(sp_TipoVehiculo) + "', idnrodocumento:'" + nrodocumento_reg + "', vnombres:'" + nombres_reg + "', vcelular:'" + celular_reg + "', vtelefono1:'" + telefono_reg + "', vemail:'" + email_reg + "', vreferencia:'" + referencia_reg + "', vnumero:'" + numeroubi_reg + "', vnombrevia:'" + direccion_reg + "', smIdTipoVia:'" + parseInt(sp_TipoVia) + "', smestadocivil:'" + parseInt(sp_EstadoCivil) + "', vdepartamento:'" + sp_Departamento + "', vprovincia:'" + sp_Provincia + "', vdistrito:'" + sp_Distrito + "', dfechanac:'" + fecnaci_reg + "', btsexo:'" + parseInt(sp_Sexo) + "', vapellidopat:'" + paterno_reg + "', vapellidomat:'" + materno_reg + "'}");
    $.ajax({
        type: "POST",
        url: "../Services/RegistrarPoliza",
        data: "{smidtablatipopoliza:'" + parseInt(sp_Poliza) + "', vplaca:'" + placa_reg + "', smidmodelo:'" + parseInt(sp_ModeloVehiculo) + "', smaniofabrica:'" + parseInt(sp_anioFabricacion) + "', vmotor:'" + nromotor_reg + "', svin:'" + vin_reg + "', smnroasiento:'" + parseInt(nroasientos_reg) + "', vcolor:'" + color_reg + "', desumaasegurada:'" + sumaaseguradapost + "', smidtablaclasevehiculo:'" + parseInt(sp_TipoVehiculo) + "', idnrodocumento:'" + nrodocumento_reg + "', vnombres:'" + nombres_reg + "', vcelular:'" + celular_reg + "', vtelefono1:'" + telefono_reg + "', vemail:'" + email_reg + "', vreferencia:'" + referencia_reg + "', vnumero:'" + numeroubi_reg + "', vnombrevia:'" + direccion_reg + "', smIdTipoVia:'" + parseInt(sp_TipoVia) + "', smestadocivil:'" + parseInt(sp_EstadoCivil) + "', vdepartamento:'" + sp_Departamento + "', vprovincia:'" + sp_Provincia + "', vdistrito:'" + sp_Distrito + "', dfechanac:'" + fecnaci_reg + "', btsexo:'" + parseInt(sp_Sexo) + "', vapellidopat:'" + paterno_reg + "', vapellidomat:'" + materno_reg + "'}",
        //data: "{smidtablatipopoliza:'" + parseInt(sp_Poliza) + "', vplaca:'" + placa_reg + "', smidmodelo:'" + parseInt(sp_ModeloVehiculo) + "'}",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: ResponseCrearSucces,
        failure: function (response) {
            alert(response.d);
        },

        error: OnError

    });

    function ResponseCrearSucces(data) {
        
        var respuesta;

        for (i = 0; i < data.length; i++) {
            respuesta = data[i].respuesta;
        }

        alert(respuesta);
    }



}




//End Agregar Registro Poliza ************************************************************************









//Error:
function OnError(data) {
    alert("Error 404..");
}






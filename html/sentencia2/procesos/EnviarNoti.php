<h3>Proceso 9 </h3>
    <h4>Enviar Notificación de la Inscripción</h4>
    <label for="idfrente">Descripción de la Notificación</label>
    <input type="text" name="noti" value="" ><br>
    <input type="hidden" name="estado" value="<?php 
        $sql1="select estado from flujoprocesocondicionante where flujo= 'F1'";
        $r=pg_query($con,$sql1);
        $tri=pg_fetch_array($r);
        echo $tri["estado"];    
    ?>" ><br>

<!-- estilo-->
<style>
    h3{
        font-size: 30px;
        font-weight: 400;
        text-align: center;
        color: #3A4750;
    }
    h4{
        font-size: 35px;
        font-weight: bold;
        text-align: center;
        color: #3A4750;
    }
    label{
        font-size: 25px;
        margin-right: 23px;
        color:#3A4750;
        font-weight: 100;
    }
    input{
    width: 20%;
    padding: 10px 20px;
    margin: 8px 0;
    box-sizing: border-box;
    border: 3px solid #ccc;
    -webkit-transition: 0.5s;
    transition: 0.5s;
    outline: none;
    }
    input:focus {
    border: 3px solid #555;
    }
</style>
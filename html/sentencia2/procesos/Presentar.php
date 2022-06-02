<h3>Proceso 3 </h3>
<h4>Presentar Inscripción</h4>
<input type="hidden" name="id" value=""/>
<h4>Documentos Subidos</h4>
<label for="nombrefrente">Nombre Frente</label>
<input type="text" name="nombrefrente" value="<?php echo $nombrefrente; ?>"><br>

<label for="nomcandidato">Nombre Candidato</label>
<input type="text" name="nomcandidato" value="<?php echo $nomcandidato; ?>"/><br>

<label for="cidentidad">Num. Carnet de Identidad:</label>
<input type="text" name="cidentidad" value="<?php echo $cidentidad; ?>"/><br>

<label for="cnacimiento">Num. Certificado de Nacimiento:</label>
<input type="text" name="cnacimiento" value="<?php echo $cnacimiento; ?>"/><br>

<label for="ctitulo">Num Titulo Universitario</label>
<input type="text" name ="ctitulo" value="<?php echo $ctitulo; ?>"><br>

<label for="cantiguedad">NUM Certificado Antigüedad</label>
<input type="text" name ="cantiguedad" value="<?php echo $cantiguo; ?>">





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
    #presentar{
        width: 0.1px;
        height: 0.1px;
        opacity: 0;
        overflow: hidden;
        position: absolute;
        z-index: -1;
    }
    svg{
        
        width: 30px;
    }
    label{
        font-size: 14px;
        font-weight: 600;
        color: #fff;
        background-color: #106BA0;
        display: inline-block;
        transition: all .5s;
        padding: 15px 40px !important;
        text-transform: uppercase;
        width: fit-content;
        text-align: center;
        margin-left: 25%;
        margin-bottom: 20px;
        margin-top: 20px;
        border-radius: 20px;
        box-shadow: 0 6px 20px -5px rgba(0,0,0,0.4);
    }
</style>
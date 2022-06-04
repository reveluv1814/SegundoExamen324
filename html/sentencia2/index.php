<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700" rel="stylesheet">
	<link href="https://fonts.googleapis.com/css?family=Roboto+Slab:300,400" rel="stylesheet">
	
    <link rel="stylesheet" href="./css/acceso.css?2.0">
    <!--<link rel="stylesheet" href="./css/style.css?1.0">-->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
    <script src="https://code.jquery.com/jquery-3.6.0.js" integrity="sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=" crossorigin="anonymous"></script>
    <link rel="icon" type="image/png"  href="imagenes/logo3.png" sizes="70x30" >
    <title>WORKFLOW</title>
    
    </head>
<body>
<!-- 
    <form action="principal.php" method="GET">
		iframe src="pantalla.php"></iframe
		<input type="hidden" name="flujo" value="F1"/>
		<input type="hidden" name="proceso" value="P1"/>
		
		<input type="submit" name="Iniciar" value="Iniciar"/>--> 

        <div class="titulo"><h1>Flujo de proceso</h1></div>
        <div class="login-form">
            <div id="logo"><img src="imagenes/logo3.png" alt=""  style="width:390px;margin-bottom:20px;"></div>
            <!--form con el metodo POST hacia acceso.php-->
            <form action="principal.php" method="get">
                <input type="hidden" name="flujo" value="F1"/>
		        <input type="hidden" name="proceso" value="P1"/>
                <div class="form-group ">
                    <label class="text">Iniciaremos el <b> FLUJO DE PROCESO</b> de Inscripción y Recepción de Frentes para las elecciones de Director de Carrera. </label>
                </div>
                <button type="submit" class="log-btn" >Iniciar</button>
            </form>
        </div>
</body>
<script>  
    /*$(document).ready(function(){
    $('.log-btn').click(function(){
           $('.log-status').addClass('wrong-entry');
           $('.alert').fadeIn(500);
           setTimeout( "$('.alert').fadeOut(1500);",3000 );
        });
        $('.form-control').keypress(function(){
            $('.log-status').removeClass('wrong-entry');
        });
    });*/
</script>
</html>
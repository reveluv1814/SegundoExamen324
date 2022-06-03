<?php
    session_start();

    $sql="select u.Nomusuario from Usuario u, Rol r, RolUsuario rl where u.id = rl.idusuario and r.idrol = rl.idrol and r.namerol = 'Secretaria'";
    $resultado=pg_query($con,$sql);
    $fila=pg_fetch_array($resultado);

    $_SESSION["secretaria"]=$fila['nomusuario'];
?>
<h2>Bienvenido:&nbsp;&nbsp;&nbsp;<b><?php echo "".$_SESSION["secretaria"]; ?></b></h2>


<?php
    $sql="select * from Frente where nusuario='".$_SESSION["id"]."'";
    $resultado=pg_query($con,$sql);
    $fila=pg_fetch_array($resultado);


?>









<!-- estilo-->
<style>
    h2{
        padding: 30px;
        color: #fff;
        background-color: #4C6983;
        width: 20%;
        border-radius: 40px;
        margin-left: 1%;
        margin-top: 2%;
        font-weight: 100;
        font-size: 30px;
    }
    h2:hover{
        background-color: #222831;
    }
</style>
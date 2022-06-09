# Examen 2do Parcial INF-324
> Nombre: Neil Angel Graneros Flores.
>
> CI: 9911843 LP
## 1. Realice mediante notación procesos y BPMN para la inscripción y recepción de frentes a la direccion de la carrera (dos notaciones).
### DIAGRAMA DE FLUJO DE PROCESOS
![](Examen324_Modelo1.png)
### DIAGRAMA BPMN 
![](sentencia1_BPMN.png)


### Tablas a Introducir en la BD.

| **FlujoProceso** 	|             	|                      	|          	|                   	|               	|
|:----------------:	|:-----------:	|:--------------------:	|:--------:	|:-----------------:	|:-------------:	|
|     **Flujo**    	| **Proceso** 	| **ProcesoSiguiente** 	| **Tipo** 	|    **Pantalla**   	|    **Rol**    	|
|        F1        	|      P1     	|          P2          	|     I    	|       Inicio      	|   RepFrente   	|
|        F1        	|      P2     	|          P3          	|     P    	|     Documentos    	|   RepFrente   	|
|        F1        	|      P3     	|          P4          	|     P    	|     Presentar     	|   RepFrente   	|
|        F1        	|      P4     	|          P5          	|     P    	|    Recepcionar    	|   Secretaria  	|
|        F1        	|      P5     	|          P6          	|     P    	|      Entregar     	|   Secretaria  	|
|        F1        	|      P6     	|           -          	|     C    	|      Aceptado     	| TribElectoral 	|
|        F1        	|      P7     	|           -          	|     F    	|   CausaNegativa   	| TribElectoral 	|
|        F1        	|      P8     	|          P9          	|     P    	| ControlDocumentos 	| TribElectoral 	|
|        F1        	|      P9     	|          P10         	|     P    	|     EnviarNoti    	| TribElectoral 	|
|        F1        	|     P10     	|                      	|     P    	|    RecibeNotifi   	|   RepFrente   	|





| **FlujoProcesoCondicionante** 	|             	|               	|               	|
|:-----------------------------:	|:-----------:	|:-------------:	|:-------------:	|
|           **Flujo**           	| **Proceso** 	| **ProcesoSI** 	| **ProcesoNO** 	|
|               F1              	|      P5     	|       P7      	|       P6      	|




| **FlujoProcesoSeguimiento** 	|             	|                     	|             	|                 	|                	|              	|             	|
|:---------------------------:	|:-----------:	|:-------------------:	|:-----------:	|:---------------:	|:--------------:	|:------------:	|:-----------:	|
|          **Flujo**          	| **Proceso** 	| **NumeroSolicitud** 	| **Usuario** 	| **FechaInicio** 	| **HoraInicio** 	| **FechaFin** 	| **HoraFin** 	|




| **Rol** 	|                 	|
|:-------:	|:---------------:	|
|  **id** 	| **namerol** 	        |
|    1    	|    RepFrente    	|
|    2    	|    Secretaria   	|
|    3    	|  TribElectoral  	|


| **Usuario** 	|                 	|
|:-----------:	|:---------------:	|
|    **id**   	| **usuario** 	    |
|      1      	|      msilva     	|
|      2      	|    jhuaranca    	|
|      3      	|      malcon     	|


| **RolUsuario** 	|               	|
|:--------------:	|:-------------:	|
|    **IdRol**   	| **IdUsuario** 	|
|        1       	|       1       	|
|        1       	|       2       	|
|        2       	|       3       	|

|  **Frente**  	|
|:------------:	|
|   IdFrente   	|
|   nusuario   	|
|   nomFrente  	|
| nomCandidato 	|
|  ciIdentidad 	|
|  cNacimiento 	|
|  Cantiguedad 	|
|    Ctitulo   	|
| **Entrega** 	|
|:-----------:	|
|  IdEntrega  	|
|   IdFrente  	|
| horaEntrega 	|
|    Fecha    	|
| **Notifica** 	|
|:------------:	|
|    estado    	|
|  idtribunal  	|
|   idusuario  	|
|  descripcion 	|
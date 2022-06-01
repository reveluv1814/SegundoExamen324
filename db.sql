create table FlujoProceso(
    Flujo VARCHAR(3),
    Proceso VARCHAR(3),
    ProcesoSiguiente VARCHAR(3),
    Tipo VARCHAR(1),
    Pantalla VARCHAR(20),
    Rol VARCHAR(20),
);

create table FlujoProcesoCondicionante(
    Flujo VARCHAR(3),
    Proceso VARCHAR(3),
    ProcesoSI VARCHAR(3),
    ProcesoNO VARCHAR(3)
);
create table FlujoProcesoSeguimiento
(
    Flujo VARCHAR(3),
    Proceso VARCHAR(3),
    NumeroSolicitud int,
    Usuario VARCHAR(15),
    FechaInicio DATE,
    HoraInicio TIME,
    FechaFin DATE,
    HoraFin TIME
);

insert into FlujoProceso values('F1','P1','P2','I','Inicio','RepFrente');
insert into FlujoProceso values('F1','P2','P3','P','Documentos','RepFrente');
insert into FlujoProceso values('F1','P3','P4','P','Presentar','RepFrente');
insert into FlujoProceso values('F1','P4','P5','P','Recepcionar','Secretaria');
insert into FlujoProceso values('F1','P5','P6','P','Entregar','Secretaria');
insert into FlujoProceso values('F1','P6',null,'C','Aceptado','TribElectoral');
insert into FlujoProceso values('F1','P7',null,'F','CausaNegativa','TribElectoral');
insert into FlujoProceso values('F1','P8','P9','P','ControlDocumentos','TribElectoral');
insert into FlujoProceso values('F1','P9','P10','P','EnviarNoti','TribElectoral');
insert into FlujoProceso values('F1','P10',null,'P','RecibeNotifi','RepFrente');
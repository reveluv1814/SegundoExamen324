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

create table Usuario
(
    id int,
    Nomusuario VARCHAR(25)
);

insert into Usuario values(1,'ngraneros');
insert into Usuario values(2,'gpocoma');
insert into Usuario values(3,'gnova');
insert into Usuario values(4,'secreDoris');
insert into Usuario values(5,'TribunalE');

/*/DELETE from usuario;*/
create table Rol
(
    IDrol int,
    namerol VARCHAR(25)
);
insert into Rol values(1,'RepFrente');
insert into Rol values(2,'Secretaria');
insert into Rol values(3,'TribElectoral');

create table RolUsuario
(
    IdRol int,
    Idusuario int
);
insert into RolUsuario values(1,1);
insert into RolUsuario values(1,2);
insert into RolUsuario values(1,3);
insert into RolUsuario values(2,4);
insert into RolUsuario values(3,5);
create table Frente
(
    IdFrente serial,
    nusuario VARCHAR(25),
    nomFrente VARCHAR(25),
    nomCandidato VARCHAR(25),
    ciIdentidad VARCHAR(25),
    cNacimiento VARCHAR(25),
    Cantiguedad VARCHAR(25),
    Ctitulo VARCHAR(25),
    constraint PK_Frente primary key (IdFrente)
);
DROP Table frente

SELECT * from frente
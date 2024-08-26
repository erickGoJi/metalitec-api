--Fondeo de operaciones
select distinct SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5)[anio], SUBSTRING(CAST(b.MesPoliza as varchar(8)), 5, 6)[mes],
                CONVERT(datetime, SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5) + '/01/' + SUBSTRING(CAST(b.MesPoliza as varchar(8)), 5, 6), 103)[fecha],
                ((select ((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '299' and Cuenta <='331'), 2))
                    +
                          (--Ingresos 
                              select ((select ISNULL(sum(Abono) - sum(Cargo), 0)
                                       from CtbPolizasDet aa
                                                inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
                                       where bb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '40%' and len(cuenta) > 10 union select (4784))
                                         and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Costos
                             -
                         (select (ISNULL(sum(Cargo) - sum(Abono), 0))
                          from CtbPolizasDet aaa
                                   inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
                          where bbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '50%' and len(cuenta) > 10)
                            and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Gastos
                    -
                (select ISNULL(sum(Cargo) - sum(Abono), 0)
                 from CtbPolizasDet aaaa
                          inner join CtbPolizas bbbb on aaaa.idPoliza = bbbb.idPoliza
                 where bbbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '60%' and len(cuenta) = 11)
                   and bbbb.Cancelada = 0 and SUBSTRING(CAST(bbbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Gasto financieros
-
(select ISNULL(sum(Cargo) - sum(Abono), 0)
from CtbPolizasDet aaaa
    inner join CtbPolizas bbbb on aaaa.idPoliza = bbbb.idPoliza
where bbbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '70%' and len(cuenta) = 11)
  and bbbb.Cancelada = 0 and SUBSTRING(CAST(bbbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())))))
    ))[CapitalSocial],
    
(select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('208', '270')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 0)
from CtbPolizasDet aa
    inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta like '208%' and len(cuenta) > 10 or Cuenta like '270%' and len(cuenta) > 10)
  and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[FondeosBanco],
    
(((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('105','114','117','120','121','123','130','131','135','136')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 0)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1 
and idCuenta 
in (select idCuenta from CtbCuentas where 
Cuenta like '105%' and len(cuenta) > 10 
or Cuenta like '114%' and len(cuenta) > 10 
or Cuenta like '117%' and len(cuenta) > 10
or Cuenta like '120%' and len(cuenta) > 10
or Cuenta like '121%' and len(cuenta) > 10
or Cuenta like '123%' and len(cuenta) > 10
or Cuenta like '130%' and len(cuenta) > 10
or Cuenta like '131%' and len(cuenta) > 10
or Cuenta like '135%' and len(cuenta) > 10
or Cuenta like '136%' and len(cuenta) > 10) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())))--[Activo circulante],
-
((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('200','201','202','203','204','207','231')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 2)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1 
and idCuenta 
in (select idCuenta from CtbCuentas where 
Cuenta like '200%' and len(cuenta) > 10 
or Cuenta like '201%' and len(cuenta) > 10 
or Cuenta like '202%' and len(cuenta) > 10
or Cuenta like '203%' and len(cuenta) > 3
or Cuenta like '204%' and len(cuenta) > 10
or Cuenta like '207%' and len(cuenta) > 10
or Cuenta like '231%' and len(cuenta) > 10) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))))[CapitalTrabajo],--[CuentasXpagar]
(((select ((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '299' and Cuenta <='331'), 2))
+
(--Ingresos 
select ((select ISNULL(sum(Abono) - sum(Cargo), 0)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '40%' and len(cuenta) > 10 union select (4784)) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Costos
-
(select (ISNULL(sum(Cargo) - sum(Abono), 0))
from CtbPolizasDet aaa  
inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '50%' and len(cuenta) > 10) 
and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Gastos
-
(select ISNULL(sum(Cargo) - sum(Abono), 0)
from CtbPolizasDet aaaa  
inner join CtbPolizas bbbb on aaaa.idPoliza = bbbb.idPoliza
where bbbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '60%' and len(cuenta) = 11) 
and bbbb.Cancelada = 0 and SUBSTRING(CAST(bbbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
--Gasto financieros
-
(select ISNULL(sum(Cargo) - sum(Abono), 0)
from CtbPolizasDet aaaa  
inner join CtbPolizas bbbb on aaaa.idPoliza = bbbb.idPoliza
where bbbb.MesPoliza < b.MesPoliza + 1  and idCuenta in (select idCuenta from  CtbCuentas where Cuenta like '70%' and len(cuenta) = 11) 
and bbbb.Cancelada = 0 and SUBSTRING(CAST(bbbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())))))
))
+
(select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('208', '270')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 0)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1
and idCuenta 
in (select idCuenta from CtbCuentas where Cuenta like '208%' and len(cuenta) > 10 or Cuenta like '270%' and len(cuenta) > 10) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))
-
(((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('105','114','117','120','121','123','130','131','135','136')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 0)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1 
and idCuenta 
in (select idCuenta from CtbCuentas where 
Cuenta like '105%' and len(cuenta) > 10 
or Cuenta like '114%' and len(cuenta) > 10 
or Cuenta like '117%' and len(cuenta) > 10
or Cuenta like '120%' and len(cuenta) > 10
or Cuenta like '121%' and len(cuenta) > 10
or Cuenta like '123%' and len(cuenta) > 10
or Cuenta like '130%' and len(cuenta) > 10
or Cuenta like '131%' and len(cuenta) > 10
or Cuenta like '135%' and len(cuenta) > 10
or Cuenta like '136%' and len(cuenta) > 10) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())))--[Activo circulante],
-
((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('200','201','202','203','204','207','231')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 2)
from CtbPolizasDet aa
inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1 
and idCuenta 
in (select idCuenta from CtbCuentas where 
Cuenta like '200%' and len(cuenta) > 10 
or Cuenta like '201%' and len(cuenta) > 10 
or Cuenta like '202%' and len(cuenta) > 10
or Cuenta like '203%' and len(cuenta) > 3
or Cuenta like '204%' and len(cuenta) > 10
or Cuenta like '207%' and len(cuenta) > 10
or Cuenta like '231%' and len(cuenta) > 10) 
and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())))))[OtrasInversiones]
from CtbPolizasDet a
    inner join CtbPolizas b on a.idPoliza = b.idPoliza
where SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())
order by anio, mes

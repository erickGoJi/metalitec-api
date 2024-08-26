--Evalucion de cuentas pricipales
--123 y 207 agregar como columnas
select distinct SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5)[anio], SUBSTRING(CAST(b.MesPoliza as varchar(8)), 5, 6)[mes],

                (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('123')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 2)
                 from CtbPolizasDet aa
                          inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
                 where bb.MesPoliza < b.MesPoliza + 1 and idCuenta in (
                     select idCuenta
                     from CtbCuentas
                     where Cuenta like '123%' and len(cuenta) > 10
                 )
                   and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[CuentasXcobrarCuenta123], 
(select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('207')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 2)
from CtbPolizasDet aaa
    inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1
  and idCuenta in (
    select idCuenta
    from CtbCuentas
    where Cuenta like '207%' and len(cuenta) > 10
    )
  and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[AcredoresDiversos],
    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('114','117')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 2)
from CtbPolizasDet aa
    inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1 and idCuenta in (
    select idCuenta
    from CtbCuentas
    where Cuenta like '114%' and len(cuenta) > 10
   or Cuenta like '117%' and len(cuenta) > 10
    )
  and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[CuentasXcobrar],

    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('200','201','202','203','204')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 2)
from CtbPolizasDet aaa
    inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1
  and idCuenta in (
    select idCuenta
    from CtbCuentas
    where Cuenta like '200%' and len(cuenta) > 10
   or Cuenta like '201%' and len(cuenta) > 10
   or Cuenta like '202%' and len(cuenta) > 10
   or Cuenta like '203%' and len(cuenta) > 3
   or Cuenta like '204%' and len(cuenta) > 10
    )
  and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[CuentasXpagar],

    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('120')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 2)
from CtbPolizasDet aaa
    inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta like '120%' and len(cuenta) > 10)--(select idCuenta from CtbCuentas where Cuenta >= '199%' and Cuenta <='236%' and len(cuenta) > 3)
  and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[Inventarios],

    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('208', '270')) + (ISNULL(sum(Abono) - sum(Cargo), 0)), 0)
from CtbPolizasDet aa
    inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta like '208%' and len(cuenta) > 10 or Cuenta like '270%' and len(cuenta) > 10)
  and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[CreditosBancarios]

from CtbPolizasDet a
    inner join CtbPolizas b on a.idPoliza = b.idPoliza
--inner join Proyectos c on b.IdProyecto = c.IdProyecto
where SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())
order by anio, mes




/*
(select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta in ('208')) + (ISNULL(sum(Cargo) - sum(Abono), 0)), 2)
from CtbPolizasDet aaa  
inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1 
and idCuenta 
in (select idCuenta from CtbCuentas where Cuenta like '120%' and len(cuenta) > 10)--(select idCuenta from CtbCuentas where Cuenta >= '199%' and Cuenta <='236%' and len(cuenta) > 3)
and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[CreditosBancarios]
*/
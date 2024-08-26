--Evalucion de cuentas pricipales
select distinct SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5)[anio], SUBSTRING(CAST(b.MesPoliza as varchar(8)), 5, 6)[mes],
                (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '104' and Cuenta <='142') + (ISNULL(sum(Cargo) - sum(Abono), 0)), 2)
                 from CtbPolizasDet aa
                          inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
                 where bb.MesPoliza < b.MesPoliza + 1
                   and idCuenta
                     in (select idCuenta from CtbCuentas where Cuenta >= '104%' and Cuenta <='142%' and len(cuenta) > 10)
                   and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[ActivoCirculante], -- 441,611,788.47
--+
(select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '169' and Cuenta <='194') + (ISNULL(sum(Cargo) - sum(Abono), 0)), 0)
from CtbPolizasDet aa
    inner join CtbPolizas bb on aa.idPoliza = bb.idPoliza
where bb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta >= '169%' and Cuenta <='194%' and len(cuenta) > 10)
  and bb.Cancelada = 0 and SUBSTRING(CAST(bb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[ActivoFijo], --143,428,745.85

    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '199' and Cuenta <='236') + (ISNULL(sum(Abono) - sum(Cargo), 0)), 0)
from CtbPolizasDet aaa
    inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta >= '199%' and Cuenta <='236%' and len(cuenta) > 10 union select(148))
  and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[PasivoCortoPlazo],
--+
    (select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '239' and Cuenta <='282') + (ISNULL(sum(Abono) - sum(Cargo), 0)), 0)
from CtbPolizasDet aaa
    inner join CtbPolizas bbb on aaa.idPoliza = bbb.idPoliza
where bbb.MesPoliza < b.MesPoliza + 1
  and idCuenta
    in (select idCuenta from CtbCuentas where Cuenta >= '239%' and Cuenta <='282%' and len(cuenta) > 10)
  and bbb.Cancelada = 0 and SUBSTRING(CAST(bbb.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE()))[PasivoLargoPlazo],
--+
    (select ((select round((select sum(saldoInicial) from saldoInicial2021 where Cuenta >= '299' and Cuenta <='331'), 2))
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
    )[CapitalSocial]
from CtbPolizasDet a
    inner join CtbPolizas b on a.idPoliza = b.idPoliza
where SUBSTRING(CAST(b.MesPoliza as varchar(6)), 0, 5) = YEAR(GETDATE())
order by anio, mes

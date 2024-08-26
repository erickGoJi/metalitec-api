select top 5  upper(left(b.Observaciones,1)) + lower(substring(b.Observaciones,2,len(b.Observaciones)))[RazonSocial], b.RFC, sum(a.MontoPesos)[Cantidad]
from AcBancosEgresos a
    inner join AcProveedores b on a.Beneficiario = b.RazonSocial
where YEAR(a.Fecha) = 2021 and b.idTipoProveedor = 5 and b.idtipoMoneda = 1--and a.Beneficiario = 'FERRECABSA SA DE CV'
group by a.beneficiario, b.rfc,b.Observaciones
order by Cantidad desc
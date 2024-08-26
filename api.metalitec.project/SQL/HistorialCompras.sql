--Historial de compras 
select distinct a.RazonSocialEmisor[RazonSocial], e.Insumo, b.FechaPedido, aa.idProveedor, b.idProyecto,e.Descripcion, g.Descripcion[Tipo], e.DescripcionLarga, e.idInsumo
from AcProveedoresXML a
         inner join AcFacturasProveedores aa on a.IdXMLProveedor = aa.IdXMLProveedor
         inner join AcPedidos b on aa.idProveedor = b.idProveedor
         inner join AcPedidosDet c on b.idPedido = c.idPedido
         inner join AcRequisicionDet cc on b.idRequisicion = cc.idRequisicion
         inner join AcExplosionInsumos d on d.idExplosionInsumos = cc.idExplosionInsumos
         inner join AcCatInsumos e on d.idInsumo = e.idInsumo
         inner join AcFamilias f on f.idFamilia = e.idFamilia
         inner join AcTiposInsumos g on e.idTipoInsumo = g.idTipoInsumo
where YEAR(b.FechaPedido) = YEAR(GETDATE())
order by b.FechaPedido desc
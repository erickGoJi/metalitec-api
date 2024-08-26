select distinct a.RazonSocialEmisor[RazonSocial], g.Descripcion, e.Insumo, e.idInsumo, b.FechaPedido, aa.idProveedor, b.idProyecto, e.DescripcionLarga, a.RFCemisor
from AcProveedoresXML a
         inner join AcFacturasProveedores aa on a.IdXMLProveedor = aa.IdXMLProveedor
         inner join AcPedidos b on aa.idProveedor = b.idProveedor
         inner join AcPedidosDet c on b.idPedido = c.idPedido
         inner join AcRequisicionDet cc on b.idRequisicion = cc.idRequisicion
         inner join AcExplosionInsumos d on d.idExplosionInsumos = cc.idExplosionInsumos
         inner join AcCatInsumos e on d.idInsumo = e.idInsumo
         inner join AcFamilias f on f.idFamilia = e.idFamilia
         inner join AcTiposInsumos g on e.idTipoInsumo = g.idTipoInsumo
where YEAR(b.FechaPedido) = YEAR(GETDATE()) --and a.idProveedor = 7416
--group by b.FechaPedido, aa.idProveedor,b.idProyecto, a.RazonSocialEmisor, e.DescripcionLarga, g.Descripcion,e.Insumo,e.idInsumo,a.RFCemisor
order by b.FechaPedido desc
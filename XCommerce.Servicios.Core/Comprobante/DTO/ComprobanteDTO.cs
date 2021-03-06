﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XCommerce.AccesoDatos;
using static XCommerce.Servicios.Core.Comprobante.Descuento;

namespace XCommerce.Servicios.Core.Comprobante.DTO
{
    public class ComprobanteDTO
    {
        public ComprobanteDTO()
        {
            if (Items == null)
            {
                Items = new List<DetalleComprobanteDTO>();
            }
        }

        public long ComprobanteId { get; set; }

        public DateTime Fecha { get; set; }

        public long UsuarioId { get; set; }

        public long ClienteId { get; set; }

        public decimal SubTotal => Items.Sum(x => x.SubtotalLinea);

        public decimal Descuento { get; set; }

        public decimal Total => SubTotal - CalcularDescuento(Descuento, SubTotal);

        public List<DetalleComprobanteDTO> Items { get; set; }
    }
}

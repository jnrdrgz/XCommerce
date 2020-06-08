﻿using Presentacion.FormulariosBase;
using Presentacion.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XCommerce.AccesoDatos;
using XCommerce.Servicios.Core.Caja.DetalleCaja;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Empleado.Mozo;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Salon.Mesa;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioComprobanteMesa : FormularioBase
    {
        private readonly long _mesaId;

        private int row;

        private readonly IComprobanteSalonServicio _comprobanteSalonServicio;

        private readonly IMovimientoServicio _movimientoServicio;

        private readonly IDetalleCajaServicio _detalleCajaServicio;

        private readonly IProductoServicio _productoServicio;

        private readonly IMozoServicio _mozoServicio;

        private readonly IMesaServicio _mesaServicio;

        private  TipoFormaPago _tfPAgo;

        private  TipoPago _tPago;


        public FormularioComprobanteMesa() : this(new ComprobanteSalonServicio(),
                                                  new ProductoServicio(),
                                                  new MozoServicio(),
                                                  new MovimientoServicio(),
                                                  new DetalleCajaServicio(),
                                                  new MesaServicio())
        {
            InitializeComponent();
            


        }
    
        public FormularioComprobanteMesa(IComprobanteSalonServicio comprobanteSalonServicio, 
                                         IProductoServicio productoServicio,
                                         IMozoServicio mozoServicio,
                                         IMovimientoServicio movimientoServicio,
                                         IDetalleCajaServicio detalleCajaServicio,
                                         IMesaServicio mesaServicio)
        {
            _comprobanteSalonServicio = comprobanteSalonServicio;
            _productoServicio = productoServicio;
            _mozoServicio = mozoServicio;
            _movimientoServicio = movimientoServicio;
            _detalleCajaServicio = detalleCajaServicio;
            _mesaServicio = mesaServicio;         


        }

     
        public void ResetearGrilla(DataGridView grilla)
        {
            for (int i = 0; i < grilla.ColumnCount; i++)
            {
                grilla.Columns[i].Visible = false;
            }

            grilla.Columns["CodigoProducto"].Visible = true;
            grilla.Columns["CodigoProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CodigoProducto"].HeaderText = "Codigo del Producto";

            grilla.Columns["DescripcionProducto"].Visible = true;
            grilla.Columns["DescripcionProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["DescripcionProducto"].HeaderText = "Descripcion";

            grilla.Columns["CantidadProducto"].Visible = true;
            grilla.Columns["CantidadProducto"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["CantidadProducto"].HeaderText = "Cantidad";

            grilla.Columns["PrecioUnitario"].Visible = true;
            grilla.Columns["PrecioUnitario"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["PrecioUnitario"].HeaderText = "Precio Unitario";

            grilla.Columns["SubtotalLinea"].Visible = true;
            grilla.Columns["SubtotalLinea"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grilla.Columns["SubtotalLinea"].HeaderText = "Sub-Total";

        }
        public FormularioComprobanteMesa(long mesaId, int _numeroMesa, bool cerrarMesa) : this()
        {
            if (cerrarMesa)
            {
                cerrarLaMesa(mesaId, _numeroMesa);
            }
        }
        

        public FormularioComprobanteMesa(long mesaId, int _numeroMesa) :this()
        {
            this.Text = $"Venta -- Mesa: {_numeroMesa}";
            _mesaId = mesaId;
          
            ObtenerComprobanteMesa(mesaId);

            ResetearGrilla(dgvGrilla);
           
        }
             

        private void ObtenerComprobanteMesa(long mesaId)
        {
            var comprobanteMesaDTO = new ComprobanteMesaDTO();
          
            
                 comprobanteMesaDTO = _comprobanteSalonServicio.Obtener(mesaId);
            
         

            if(comprobanteMesaDTO == null)
            {
                MessageBox.Show("Ocurrió un Error");
                this.Close();
            }

            txtMozoLegajo.Text = Convert.ToString(comprobanteMesaDTO.Legajo);
            txtApyNomMozo.Text = comprobanteMesaDTO.ApyNomMozo;
            

            nudSubTotal.Value = comprobanteMesaDTO.SubTotal;
            nudDescuento.Value = comprobanteMesaDTO.Descuento;
            nudTotal.Value = comprobanteMesaDTO.Total; 

            dgvGrilla.DataSource = comprobanteMesaDTO.Items.ToList();

            

        }


        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                busquedaArticulo();
            }
        }

        private void busquedaArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigoBarras.Text))
            {
                MessageBox.Show("Por favor ingrese un codigo");
                return;
            }
            var producto = _productoServicio.ObtenerPorCodigo(_mesaId, txtCodigoBarras.Text);

            if (producto != null)
            {
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = Convert.ToString(producto.Precio);
                _comprobanteSalonServicio.AgregarItems(_mesaId, nudCantidadArticulo.Value, producto);

                ObtenerComprobanteMesa(_mesaId);
            }
        }

        private void txtMozoLegajo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                buscarMozo();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            busquedaArticulo();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarMozo();
        }

        private void buscarMozo()
        {
            if (string.IsNullOrEmpty(txtMozoLegajo.Text))
            {
                MessageBox.Show("Por favor ingrese un legajo");
                return;
            }

            var mozo = _mozoServicio.ObtenerMozoPorLegajo(Convert.ToInt32(txtMozoLegajo.Text));

            if (mozo != null)
            {
                txtMozoLegajo.Text = Convert.ToString(mozo.Legajo);
                txtApyNomMozo.Text = mozo.ApyNom;
                _mozoServicio.asignarMozoAMesa(_mesaId, mozo);

            }
        }

        private void btnCerrarMesa_Click(object sender, EventArgs e)
        {
            var mesaNumero = _mesaServicio.ObtenerPorId(_mesaId).Numero;
            cerrarLaMesa(_mesaId, mesaNumero);
            
        }


        private void cerrarLaMesa(long mesaId,int numeroMesa)
        {
           
            if(rdbCheque.Checked == true)
            {
               _tfPAgo = TipoFormaPago.Cheque;
               
            }
            if(rdbEfectivo.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Efectivo;
                _tPago = TipoPago.Efectivo;
            }
            if(rdbTarjeta.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Tarjeta;
                _tPago = TipoPago.Tarjeta;
            }
            if(rdbCtaCte.Checked == true)
            {
                _tfPAgo = TipoFormaPago.CuentaCorriente;
                _tPago = TipoPago.CtaCte;
            }

            var comprobanteMesaDto = _comprobanteSalonServicio.Obtener(mesaId);
            
            _comprobanteSalonServicio.FacturarComprobanteSalon(mesaId,comprobanteMesaDto);
            
            var mesaParaCerrar = _mesaServicio.ObtenerPorId(mesaId);
            mesaParaCerrar.estadoMesa = EstadoMesa.Cerrada;
            _mesaServicio.Modificar(mesaParaCerrar);          
            
            _movimientoServicio.GenerarMovimiento(DatosSistema.CajaId, comprobanteMesaDto.ComprobanteId, TipoMovimiento.Ingreso, DatosSistema.UsuarioId, nudTotal.Value, $" Ingreso de Mesa n°:{numeroMesa}");
            _detalleCajaServicio.GenerarDetalleCaja(DatosSistema.CajaId, nudTotal.Value, _tPago);

            this.Close();
            

        }

        private void nudCantidadArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter == e.KeyChar)
            {
                if (string.IsNullOrEmpty(txtCodigoBarras.Text))
                {
                    txtCodigoBarras.Focus();
                }
                else
                {
                    busquedaArticulo();
                }
            }
        }

        
        private void dgvGrilla_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
               
                dgvGrilla.CurrentCell = dgvGrilla.Rows[e.RowIndex].Cells[e.ColumnIndex];
                row = e.RowIndex;            

                Rectangle coordenada = dgvGrilla.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                int anchoCelda = coordenada.Location.X; //Ancho de la localizacion de la celda
                int altoCelda = coordenada.Location.Y;  //Alto de la localizacion de la celda

                // mostrar el menú en la posicion  
                int X = anchoCelda;
                int Y = altoCelda;

                menu.Show(dgvGrilla, new Point(X, Y));

            }
        }

             

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvGrilla.SelectedRows == null)
            {
                MessageBox.Show("Por favor seleccione un item");
                return;
            }


           
           List<DetalleComprobanteSalonDTO> listaItems = (List< DetalleComprobanteSalonDTO>)dgvGrilla.DataSource;
          
           var itemSelectedDetalleId = listaItems[row].DetalleId;

           _comprobanteSalonServicio.QuitarItems(itemSelectedDetalleId);

            ObtenerComprobanteMesa(_mesaId);

        }

        private void cambiarCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DetalleComprobanteSalonDTO> listaItems = (List<DetalleComprobanteSalonDTO>)dgvGrilla.DataSource;
        
            var itemSelectedDetalleId = listaItems[row].DetalleId;
            var itemSelectedCodigo = listaItems[row].CodigoProducto;
            var itemSelectedDescripcion = listaItems[row].DescripcionProducto;
            var itemSelectedPrecio = listaItems[row].PrecioUnitario;

            txtCodigoBarras.Text = itemSelectedCodigo;
            txtDescripcion.Text = itemSelectedDescripcion;
            txtPrecioUnitario.Text = Convert.ToString(itemSelectedPrecio);
            nudCantidadArticulo.Value = 1.00m;
            nudCantidadArticulo.Focus();

            _comprobanteSalonServicio.QuitarItems(itemSelectedDetalleId);
            ObtenerComprobanteMesa(_mesaId);
        }
    }
}

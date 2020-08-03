﻿using Presentacion.Core.Articulo;
using Presentacion.Core.Cliente;
using Presentacion.FormulariosBase;
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
using XCommerce.Servicio.Core.Banco;
using XCommerce.Servicio.Core.Banco.DTO;
using XCommerce.Servicios.Core.Articulo;
using XCommerce.Servicios.Core.Caja.DetalleCaja;
using XCommerce.Servicios.Core.Cliente;
using XCommerce.Servicios.Core.Comprobante;
using XCommerce.Servicios.Core.Comprobante.DTO;
using XCommerce.Servicios.Core.Empleado.Mozo;
using XCommerce.Servicios.Core.FormaPago;
using XCommerce.Servicios.Core.FormaPago.DTO;
using XCommerce.Servicios.Core.Movimiento;
using XCommerce.Servicios.Core.Producto;
using XCommerce.Servicios.Core.Salon.Mesa;
using XCommerce.Servicios.Core.Tarjeta;
using XCommerce.Servicios.Core.Tarjeta.DTO;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta;
using XCommerce.Servicios.Core.Tarjeta.PlanTarjeta.DTO;

namespace Presentacion.Core.VentaSalon
{
    public partial class FormularioComprobanteMesa : FormularioBase
    {
        private readonly string _listaPrecio;
        private readonly long _mesaId;
        private long idComprobante;
        private long idCliente;
        private long idArticulo;
        private readonly int _numeroMesa;
        private int row;

        private readonly IComprobanteSalonServicio _comprobanteSalonServicio;

        private readonly IMovimientoServicio _movimientoServicio;

        private readonly IFormaPagoServicio _formaPagoServicio;

        private readonly ITarjetaServicio _tarjetaServicio;

        private readonly IPlanTarjetaServicio _planTarjetaServicio;

        private readonly IBancoServicio _bancoServicio;

        private readonly IClienteServicio _clienteServicio;

        private readonly IDetalleCajaServicio _detalleCajaServicio;

        private readonly IProductoServicio _productoServicio;

        private readonly IArticuloServicio _articuloServicio;

        private readonly IMozoServicio _mozoServicio;

        private readonly IMesaServicio _mesaServicio;

        private TipoFormaPago _tfPAgo;

        private TipoPago _tPago;


        public FormularioComprobanteMesa() : this(new ComprobanteSalonServicio(),
                                                  new ProductoServicio(),
                                                  new ArticuloServicio(),
                                                  new MozoServicio(),
                                                  new MovimientoServicio(),
                                                  new DetalleCajaServicio(),
                                                  new MesaServicio(),
                                                  new ClienteServicio(),
                                                  new FormaPagoServicio(),
                                                  new BancoServicio(),
                                                  new TarjetaServicio(),
                                                  new PlanTarjetaServicio())
        {
            InitializeComponent();


            if (_tfPAgo == 0) { int a = 1; a++; }


        }

        public FormularioComprobanteMesa(IComprobanteSalonServicio comprobanteSalonServicio,
                                         IProductoServicio productoServicio,
                                         IArticuloServicio articuloServicio,
                                         IMozoServicio mozoServicio,
                                         IMovimientoServicio movimientoServicio,
                                         IDetalleCajaServicio detalleCajaServicio,
                                         IMesaServicio mesaServicio,
                                         IClienteServicio clienteServicio,
                                         IFormaPagoServicio formaPagoServicio,
                                         IBancoServicio bancoServicio,
                                         ITarjetaServicio tarjetaServicio,
                                         IPlanTarjetaServicio planTarjetaServicio)
        {
            _comprobanteSalonServicio = comprobanteSalonServicio;
            _productoServicio = productoServicio;
            _articuloServicio = articuloServicio;
            _mozoServicio = mozoServicio;
            _movimientoServicio = movimientoServicio;
            _detalleCajaServicio = detalleCajaServicio;
            _mesaServicio = mesaServicio;
            _clienteServicio = clienteServicio;
            _formaPagoServicio = formaPagoServicio;
            _bancoServicio = bancoServicio;
            _tarjetaServicio = tarjetaServicio;
            _planTarjetaServicio = planTarjetaServicio;




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
            grilla.Columns["SubtotalLinea"].DefaultCellStyle.Format = "N2";



        }
        public FormularioComprobanteMesa(long mesaId, int _numeroMesa, bool cerrarMesa) : this()
        {
            ObtenerComprobanteMesa(mesaId);
            if (cerrarMesa)
            {
                this.Show();
                cerrarLaMesa(mesaId, _numeroMesa);
            }
        }


        public FormularioComprobanteMesa(long mesaId, int numeroMesa) : this()
        {
            this.Text = $"Venta -- Mesa: {numeroMesa}";
            _mesaId = mesaId;
            _numeroMesa = numeroMesa;

            _listaPrecio = _mesaServicio.ObtenerListaPrecio(_mesaId);

            ObtenerComprobanteMesa(mesaId);
            idComprobante = _comprobanteSalonServicio.Obtener(mesaId).ComprobanteId;
            ResetearGrilla(dgvGrilla);

        }


        private void ObtenerComprobanteMesa(long mesaId)
        {
            var comprobanteMesaDTO = new ComprobanteMesaDTO();


            comprobanteMesaDTO = _comprobanteSalonServicio.Obtener(mesaId);



            if (comprobanteMesaDTO == null)
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
            var producto = _productoServicio.ObtenerPorCodigoListaPrecio(_listaPrecio, txtCodigoBarras.Text);

            if (producto != null)
            {
                txtDescripcion.Text = producto.Descripcion;
                txtPrecioUnitario.Text = Convert.ToString(producto.Precio);
                _comprobanteSalonServicio.AgregarItems(_mesaId, nudCantidadArticulo.Value, producto);

                ObtenerComprobanteMesa(_mesaId);
            }
            else
            {
                MessageBox.Show($"Articulo no existe o no esta en lista precio: {_listaPrecio}.");
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


        private void cerrarLaMesa(long mesaId, int numeroMesa)
        {

            if (rdbCheque.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Cheque;

            }
            if (rdbEfectivo.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Efectivo;
                _tPago = TipoPago.Efectivo;
            }
            if (rdbTarjeta.Checked == true)
            {
                _tfPAgo = TipoFormaPago.Tarjeta;
                _tPago = TipoPago.Tarjeta;
            }
            if (rdbCtaCte.Checked == true)
            {
                _tfPAgo = TipoFormaPago.CuentaCorriente;
                _tPago = TipoPago.CtaCte;
            }

            var comprobanteMesaDto = _comprobanteSalonServicio.Obtener(mesaId);

            if (nudTotal.Value > 0)
            {

                if (_tfPAgo == TipoFormaPago.CuentaCorriente)
                {

                    if (_clienteServicio.DescontarDeCuenta(idCliente, comprobanteMesaDto.Total))
                    {
                        //nada?
                    }
                    else
                    {
                        throw new Exception("Si tiene menos de 0 deberia un cartel que no deje que siga el tema ya vemos yadayadayada");
                    }
                }
                else
                {
                    if (_tfPAgo == TipoFormaPago.Cheque)
                    {
                        FormaPagoChequeDTO fp = new FormaPagoChequeDTO
                        {
                            TipoFormaPago = TipoFormaPago.Cheque,
                            Monto = nudTotal.Value,
                            ComprobanteId = idComprobante,
                            BancoId = ((BancoDTO)cbBanco.SelectedItem).Id,
                            Dias = (int)nudDiasCheque.Value,
                            EnteEmisor = txtEnteCheque.Text,
                            FechaEmision = dtFechaCheque.Value,
                            Numero = txtNumeroCheque.Text,
                        };

                        _formaPagoServicio.Generar(fp);
                    }
                    else
                    {
                        if (_tfPAgo == TipoFormaPago.Tarjeta)
                        {
                            FormaPagoTarjetaDTO fp = new FormaPagoTarjetaDTO
                            {
                                TipoFormaPago = TipoFormaPago.Tarjeta,
                                Monto = nudTotal.Value,
                                ComprobanteId = idComprobante,
                                Numero = txtNumeroTarjeta.Text,
                                Cupon = "", //TODO ????
                                PlanTarjetaId = ((PlanTarjetaDTO)cbPlan.SelectedItem).Id,
                                NumeroTarjeta = txtClaveTarjeta.Text
                            };

                            _formaPagoServicio.Generar(fp);
                        }
                    }
                }
                _comprobanteSalonServicio.FacturarComprobanteSalon(mesaId, comprobanteMesaDto);

                _movimientoServicio.GenerarMovimiento(DatosSistema.CajaId, comprobanteMesaDto.ComprobanteId, TipoMovimiento.Ingreso, DatosSistema.UsuarioId, nudTotal.Value, $" Ingreso de Mesa n°:{numeroMesa}");
                _detalleCajaServicio.GenerarDetalleCaja(DatosSistema.CajaId, nudTotal.Value, _tPago);

            }
            else
            {
                _comprobanteSalonServicio.Eliminar(comprobanteMesaDto.ComprobanteId);

            }

            var mesaParaCerrar = _mesaServicio.ObtenerPorId(mesaId);
            mesaParaCerrar.estadoMesa = EstadoMesa.Cerrada;
            _mesaServicio.Modificar(mesaParaCerrar);

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



            List<DetalleComprobanteSalonDTO> listaItems = (List<DetalleComprobanteSalonDTO>)dgvGrilla.DataSource;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            List<DetalleComprobanteSalonDTO> listaItems = (List<DetalleComprobanteSalonDTO>)dgvGrilla.DataSource;

            foreach (var item in listaItems)
            {
                _comprobanteSalonServicio.QuitarItems(item.DetalleId);
            }

            nudTotal.Value = 0;

            cerrarLaMesa(_mesaId, _numeroMesa);


        }

        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {

            var comprobanteMesaDTO = new ComprobanteMesaDTO();


            comprobanteMesaDTO = _comprobanteSalonServicio.Obtener(_mesaId);



            if (comprobanteMesaDTO == null)
            {
                MessageBox.Show("Ocurrió un Error");
                this.Close();
            }

            nudTotal.Value = nudSubTotal.Value - (nudSubTotal.Value * nudDescuento.Value) / 100;

        }


        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            bool vieneDeSelecFPago = true;
            FormularioClienteConsulta f = new FormularioClienteConsulta(vieneDeSelecFPago);

            f.ShowDialog();

            idCliente = f.clienteSeleccionado;



            var cliente = _clienteServicio.ObtenerClientePorId(idCliente);
            if (cliente != null)
            {
                txtClienteDni.Text = cliente.Dni;

                txtClienteApyNom.Text = $"{cliente.Apellido} {cliente.Nombre}";
            }

            //ObtenerClientePorId
        }



        private void btnBuscarArticulo_Click_1(object sender, EventArgs e)
        {
            bool vieneDeMesaKiosco = true;
            FormularioArticuloConsulta fAConsulta = new FormularioArticuloConsulta(vieneDeMesaKiosco);

            fAConsulta.ShowDialog();

            idArticulo = fAConsulta.articuloSeleccionado;

            if (idArticulo == 0)
            {
                MessageBox.Show("No se seleccionó ningún artículo");
            }
            else
            {
                var articulo = _articuloServicio.ObtenerPorId(idArticulo);
                if (articulo == null)
                {
                    MessageBox.Show("Articulo no existe o no se encuentra en lista precio de este Salon.");
                }
                else
                {
                    var salonDescripcion = _mesaServicio.ObtenerPorId(_mesaId).SalonDescripcion;
                    var producto = _productoServicio.ObtenerPorCodigoSalon(salonDescripcion, articulo.Codigo);
                    if (producto != null)
                    {
                        txtCodigoBarras.Text = producto.CodigoBarra;
                        txtDescripcion.Text = producto.Descripcion;
                        txtPrecioUnitario.Text = Convert.ToString(producto.Precio);

                    }
                    else
                    {
                        MessageBox.Show("Articulo no existe o no se encuentra en lista precio de este Salon.");

                    }
                }
            }

        }

        private void FormularioComprobanteMesa_Load(object sender, EventArgs e)
        {
            gbTarjeta.Visible = false;
            gbCheqe.Visible = false;
        }

        private void rdbCheque_Click(object sender, EventArgs e)
        {
            gbTarjeta.Visible = false;
            gbCheqe.Visible = true;

            CargarComboBox(cbBanco, _bancoServicio.Obtener(string.Empty), "Descripcion", "Id");
        }

        private void rdbTarjeta_Click(object sender, EventArgs e)
        {
            gbTarjeta.Visible = true;
            gbCheqe.Visible = false;

            CargarComboBox(cbTarjeta, _tarjetaServicio.Obtener(string.Empty), "Descripcion", "Id");

            if (cbTarjeta.Items.Count > 0)
            {
                CargarComboBox(cbPlan, _planTarjetaServicio.ObtenerPorIdTarjeta(((TarjetaDTO)cbTarjeta.Items[0]).Id), "Descripcion", "Id");
            }
        }
    }
}

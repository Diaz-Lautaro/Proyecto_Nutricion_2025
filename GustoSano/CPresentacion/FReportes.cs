using GustoSano.CLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;



namespace GustoSano.CPresentacion
{
    public partial class FReportes : Form
    {
        public FReportes()
        {
            InitializeComponent();
            label1.ForeColor = Color.Silver;
        }

        // Cuando abro el buscar paciente
        public string nombrePaciente { get; set; }
        public string apellidoPaciente { get; set; }
        public int idPaciente { get; set; }

        // Cuando abro el buscar menu
        public string nombreMenu { get; set; }


        ClsReporte_L logica = new ClsReporte_L();


        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            FBuscarPaciente fBuscarPaciente = new FBuscarPaciente(this, "freporte");

            if (fBuscarPaciente.ShowDialog() == DialogResult.OK)
            {
                label1.ForeColor = Color.Green;
                txtPaciente.Texts = nombrePaciente + " " + apellidoPaciente;
                mostrarTurnos();

                logica.cargarHistoriaClinica_L(idPaciente);
                logica.cargarTurnosCompletos_L(txtPaciente.Texts);
            }
        }

        private void btnBuscarMenu_Click(object sender, EventArgs e)
        {
            FBuscarMenus fBuscarMenus = new FBuscarMenus(this);

            if (fBuscarMenus.ShowDialog() == DialogResult.OK)
            {
                txtNombreMenu.Texts = nombreMenu;
            }

            logica.cargarMenuCompleto_L(txtNombreMenu.Texts);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPaciente.Texts) || string.IsNullOrEmpty(txtNombreMenu.Texts))
            {
                MessageBox.Show("Seleccione un paciente y un menú antes de generar el logica.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog guardar = new SaveFileDialog
            {
                Filter = "Archivo PDF|*.pdf",
                FileName = $"{txtPaciente.Texts}_{DateTime.Now:dd-MM-yy_HHmm}.pdf"

            };

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                generarPDF(guardar.FileName);
                MessageBox.Show("Reporte generado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarCampos();
            }
        }

        private void mostrarTurnos()
        {
            dgvTurnos.DataSource = logica.buscarProximosTurnos_L(txtPaciente.Texts);
            dgvTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTurnos.ReadOnly = true;
        }

        private void limpiarCampos()
        {
            txtPaciente.Texts = string.Empty;
            txtNombreMenu.Texts = string.Empty;
            dgvTurnos.DataSource = null;
            label1.ForeColor = Color.Silver;
        }

        //==============================================================================================================================


        public void generarPDF(string rutaArchivo)
        {
            // ===============================================
            // CONFIGURACIÓN BÁSICA DEL DOCUMENTO PDF
            // ===============================================

            // Crear el documento con tamaño A4 y márgenes
            Document pdfDoc = new Document(PageSize.A4, 40, 40, 40, 40);

            // Crear el escritor que genera el archivo
            PdfWriter.GetInstance(pdfDoc, new FileStream(rutaArchivo, FileMode.Create));

            // Abrir el documento para escribir
            pdfDoc.Open();


            // ===============================================
            // FUENTES UTILIZADAS EN EL PDF
            // ===============================================
            Font tituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Font subtituloFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            Font textoFont = FontFactory.GetFont(FontFactory.HELVETICA, 11);
            Font tablaHeader = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
            Font tablaFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);


            // ===============================================
            //   TÍTULO PRINCIPAL DEL DOCUMENTO
            // ===============================================
            Paragraph titulo = new Paragraph("Informe General del Paciente\n\n", tituloFont);
            titulo.Alignment = Element.ALIGN_CENTER;
            pdfDoc.Add(titulo);



            // =====================================================
            //                SECCIÓN HISTORIA CLÍNICA
            // =====================================================
            Paragraph subtituloClinica = new Paragraph("Historia Clínica", subtituloFont);
            subtituloClinica.SpacingAfter = 5f;

            Paragraph subtituloClinica2 = new Paragraph($"Paciente: {txtPaciente.Texts}", subtituloFont);
            subtituloClinica2.SpacingAfter = 10f;

            pdfDoc.Add(subtituloClinica);
            pdfDoc.Add(subtituloClinica2);

            // Agregar cada dato clínico
            pdfDoc.Add(new Paragraph($"Peso: {logica.peso}", textoFont));
            pdfDoc.Add(new Paragraph($"Altura: {logica.altura}", textoFont));
            pdfDoc.Add(new Paragraph($"Diagnóstico: {logica.diagnostico}", textoFont));
            pdfDoc.Add(new Paragraph($"Alergias: {logica.alergias}", textoFont));
            pdfDoc.Add(new Paragraph($"Patologías: {logica.patologias}", textoFont));
            pdfDoc.Add(new Paragraph($"Medicamentos: {logica.medicamentos}", textoFont));
            pdfDoc.Add(new Paragraph($"Tipo de dieta actual: {logica.tipoDietaActual}", textoFont));
            pdfDoc.Add(new Paragraph($"Comidas diarias: {logica.comidasDiarias}", textoFont));
            pdfDoc.Add(new Paragraph($"Horarios: {logica.horarios}", textoFont));
            pdfDoc.Add(new Paragraph($"Consumo de agua: {logica.consumoAgua}", textoFont));
            pdfDoc.Add(new Paragraph($"Objetivo: {logica.objetivo}", textoFont));
            pdfDoc.Add(new Paragraph($"Actividad física: {logica.actividadFisica}\n\n", textoFont));


            pdfDoc.Add(new Paragraph("\n\n")); // ESPACIO


            // =====================================================
            //                      SECCIÓN MENÚ
            // =====================================================
            Paragraph subtituloMenu = new Paragraph("Menú recomendado\n\n", subtituloFont);
            pdfDoc.Add(subtituloMenu);

            // Si existen ítems en la lista del menú
            if (logica.menuCompleto.Count > 0)
            {
                // Crear tabla con 3 columnas
                PdfPTable tablaMenu = new PdfPTable(3);
                tablaMenu.WidthPercentage = 100;

                // Encabezados de la tabla
                tablaMenu.AddCell(new PdfPCell(new Phrase("Nombre del menú", tablaHeader)));
                tablaMenu.AddCell(new PdfPCell(new Phrase("Tipo de comida", tablaHeader)));
                tablaMenu.AddCell(new PdfPCell(new Phrase("Descripción", tablaHeader)));

                // Recorrer todos los ítems agregados a la lista
                foreach (var item in logica.menuCompleto)
                {
                    tablaMenu.AddCell(new PdfPCell(new Phrase(item.nombreMenu, tablaFont)));
                    tablaMenu.AddCell(new PdfPCell(new Phrase(item.TipoComida, tablaFont)));
                    tablaMenu.AddCell(new PdfPCell(new Phrase(item.Descripcion, tablaFont)));
                }

                pdfDoc.Add(tablaMenu);
            }
            else
            {
                // Texto alternativo si no hay menú cargado
                pdfDoc.Add(new Paragraph("No se registraron menús para este paciente.\n\n", textoFont));
            }



            pdfDoc.Add(new Paragraph("\n\n")); // ESPACIO



            // =====================================================
            //                      SECCIÓN TURNOS
            // =====================================================
            Paragraph subtituloTurnos = new Paragraph("Próximos turno/s\n\n", subtituloFont);
            pdfDoc.Add(subtituloTurnos);

            if (logica.turnosCompletos.Count > 0)
            {
                // Tabla de los turnos con 3 columnas
                PdfPTable tablaTurnos = new PdfPTable(3);
                tablaTurnos.WidthPercentage = 100;

                // Encabezados
                tablaTurnos.AddCell(new PdfPCell(new Phrase("Fecha", tablaHeader)));
                tablaTurnos.AddCell(new PdfPCell(new Phrase("Hora", tablaHeader)));
                tablaTurnos.AddCell(new PdfPCell(new Phrase("Motivo", tablaHeader)));

                // Agregar todos los turnos cargados en la lista
                foreach (var item in logica.turnosCompletos)
                {
                    tablaTurnos.AddCell(new PdfPCell(new Phrase(item.fecha, tablaFont)));
                    tablaTurnos.AddCell(new PdfPCell(new Phrase(item.hora, tablaFont)));
                    tablaTurnos.AddCell(new PdfPCell(new Phrase(item.motivos, tablaFont)));
                }

                pdfDoc.Add(tablaTurnos);
            }
            else
            {
                pdfDoc.Add(new Paragraph("No se registraron turnos para este paciente.\n\n", textoFont));
            }



            // =====================================================
            //               FINALIZAR DOCUMENTO
            // =====================================================
            pdfDoc.Close();
        }

    }
}

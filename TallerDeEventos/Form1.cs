using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using TallerDeEventos.Clases;

namespace TallerDeEventos
{
    public partial class ControlTareas : Form
    {
        List<Tarea> Tareas = new List<Tarea>();

        private FlowLayoutPanel panelSeleccionado;

        public ControlTareas()
        {
            InitializeComponent();

            ConfigurarEventosDragDrop(PnlTareasPorRealizar);
            ConfigurarEventosDragDrop(PnlTareasEnProceso);
            ConfigurarEventosDragDrop(PnlTareasTerminadas);

            CmbPanelTareas.Items.Add("Tareas por Realizar");
            CmbPanelTareas.Items.Add("Tareas en Ejecución");
            CmbPanelTareas.Items.Add("Tareas Terminadas");


            CmbPanelTareas.SelectedIndex = 0;

            CmbPanelTareas.SelectedIndexChanged += CmbPanelTareas_SelectedIndexChanged;
        }

        private void ConfigurarEventosDragDrop(FlowLayoutPanel panel)
        {
            panel.AllowDrop = true;
            panel.DragEnter += new DragEventHandler(Pnl_DragEnter);
            panel.DragDrop += new DragEventHandler(Pnl_DragDrop);
        }

        private void BtnAgregarTareas_Click(object sender, EventArgs e)
        {
            if (TxtIngresarTarea.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre para la tarea");
                return;
            }

            Tarea nuevatarea = new Tarea(TxtIngresarTarea.Text, "Pendiente");

            Tareas.Add(nuevatarea);

            Label etiquetaTarea = new Label
            {
                Text = nuevatarea.nombre,
                AutoSize = true,
                MinimumSize = new Size(100, 30),
                MaximumSize = new Size(300, 30),
                ForeColor = Color.White,
                Padding = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };

            switch (CmbPanelTareas.SelectedIndex)
            {
                case 0: 
                    etiquetaTarea.BackColor = Color.Red;
                    break;
                case 1: 
                    etiquetaTarea.BackColor = Color.Orange;
                    break;
                case 2: 
                    etiquetaTarea.BackColor = Color.Green;
                    break;
            }

            etiquetaTarea.Size = new Size(etiquetaTarea.PreferredWidth + 10, etiquetaTarea.Height);

            etiquetaTarea.MouseDown += new MouseEventHandler(etiquetaTarea_MouseDown);

            panelSeleccionado.Controls.Add(etiquetaTarea);

            TxtIngresarTarea.Clear();
        }

        private void BtnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (PnlTareasPorRealizar.Controls.Count > 0)
            {
                PnlTareasPorRealizar.Controls.RemoveAt(PnlTareasPorRealizar.Controls.Count - 1);
            }
            else if (PnlTareasEnProceso.Controls.Count > 0)
            {
                PnlTareasEnProceso.Controls.RemoveAt(PnlTareasEnProceso.Controls.Count - 1);
            }
            else if (PnlTareasTerminadas.Controls.Count > 0)
            {
                PnlTareasTerminadas.Controls.RemoveAt(PnlTareasTerminadas.Controls.Count - 1);
            }
        }

        private void TxtIngresarTarea_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAgregarTareas.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void etiquetaTarea_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label tarea = sender as Label;
                if (tarea != null)
                {
                    tarea.DoDragDrop(tarea, DragDropEffects.Move);
                }
            }
        }

        private void Pnl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Label)))
            {
                e.Effect = DragDropEffects.Move;

            }
        }


        private void Pnl_DragDrop(object sender, DragEventArgs e)
        {
            Label tarea = e.Data.GetData(typeof(Label)) as Label;
            if (tarea != null)
            {
                FlowLayoutPanel targetPanel = sender as FlowLayoutPanel;
                if (targetPanel != null)
                {

                    if (targetPanel == PnlTareasPorRealizar)
                    {
                        tarea.BackColor = Color.Red;
                        CmbPanelTareas.Items.Add("Tareas por realizar");
                    }
                    else if (targetPanel == PnlTareasEnProceso)
                    {
                        tarea.BackColor = Color.Orange;
                        CmbPanelTareas.Items.Add("Tareas en proceso");
                    }
                    else if (targetPanel == PnlTareasTerminadas)
                    {
                        tarea.BackColor = Color.Green;
                        CmbPanelTareas.Items.Add("Tareas terminadas");
                    }


                    targetPanel.Controls.Add(tarea);
                    tarea.BringToFront();
                }
            }
        }

        private void CmbPanelTareas_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbPanelTareas.SelectedIndex)
            {
                case 0:
                    panelSeleccionado = PnlTareasPorRealizar;
                    break;
                case 1:
                    panelSeleccionado = PnlTareasEnProceso;
                    break;
                case 2:
                    panelSeleccionado = PnlTareasTerminadas;
                    break;
            }
        }
    }
}







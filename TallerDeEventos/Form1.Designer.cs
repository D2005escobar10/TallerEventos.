namespace TallerDeEventos
{
    partial class ControlTareas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtIngresarTarea = new TextBox();
            PnlTareasPorRealizar = new FlowLayoutPanel();
            PnlTareasEnProceso = new FlowLayoutPanel();
            PnlTareasTerminadas = new FlowLayoutPanel();
            LbTareasaRealizar = new Label();
            LbTareaEnProceso = new Label();
            LbTareasTerminadas = new Label();
            BtnAgregarTareas = new Button();
            CmbPanelTareas = new ComboBox();
            SuspendLayout();
            // 
            // TxtIngresarTarea
            // 
            TxtIngresarTarea.BackColor = SystemColors.ButtonHighlight;
            TxtIngresarTarea.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtIngresarTarea.ForeColor = SystemColors.ActiveCaptionText;
            TxtIngresarTarea.Location = new Point(153, 104);
            TxtIngresarTarea.Name = "TxtIngresarTarea";
            TxtIngresarTarea.PlaceholderText = "Ingresar Tareas";
            TxtIngresarTarea.Size = new Size(290, 26);
            TxtIngresarTarea.TabIndex = 0;
            TxtIngresarTarea.TextAlign = HorizontalAlignment.Center;
            TxtIngresarTarea.KeyDown += TxtIngresarTarea_KeyDown;
            // 
            // PnlTareasPorRealizar
            // 
            PnlTareasPorRealizar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasPorRealizar.AutoScroll = true;
            PnlTareasPorRealizar.BackColor = SystemColors.ButtonHighlight;
            PnlTareasPorRealizar.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasPorRealizar.FlowDirection = FlowDirection.TopDown;
            PnlTareasPorRealizar.Location = new Point(153, 226);
            PnlTareasPorRealizar.Name = "PnlTareasPorRealizar";
            PnlTareasPorRealizar.Size = new Size(211, 351);
            PnlTareasPorRealizar.TabIndex = 2;
            PnlTareasPorRealizar.Click += BtnEliminarTarea_Click;
            // 
            // PnlTareasEnProceso
            // 
            PnlTareasEnProceso.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasEnProceso.AutoScroll = true;
            PnlTareasEnProceso.BackColor = SystemColors.ButtonHighlight;
            PnlTareasEnProceso.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasEnProceso.FlowDirection = FlowDirection.TopDown;
            PnlTareasEnProceso.Location = new Point(446, 226);
            PnlTareasEnProceso.Name = "PnlTareasEnProceso";
            PnlTareasEnProceso.Size = new Size(216, 351);
            PnlTareasEnProceso.TabIndex = 3;
            PnlTareasEnProceso.Click += BtnEliminarTarea_Click;
            // 
            // PnlTareasTerminadas
            // 
            PnlTareasTerminadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            PnlTareasTerminadas.AutoScroll = true;
            PnlTareasTerminadas.BackColor = SystemColors.ButtonHighlight;
            PnlTareasTerminadas.BorderStyle = BorderStyle.Fixed3D;
            PnlTareasTerminadas.FlowDirection = FlowDirection.TopDown;
            PnlTareasTerminadas.Location = new Point(744, 226);
            PnlTareasTerminadas.Name = "PnlTareasTerminadas";
            PnlTareasTerminadas.Size = new Size(216, 351);
            PnlTareasTerminadas.TabIndex = 4;
            PnlTareasTerminadas.Click += BtnEliminarTarea_Click;
            // 
            // LbTareasaRealizar
            // 
            LbTareasaRealizar.AutoSize = true;
            LbTareasaRealizar.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareasaRealizar.ForeColor = SystemColors.ButtonHighlight;
            LbTareasaRealizar.Location = new Point(171, 186);
            LbTareasaRealizar.Name = "LbTareasaRealizar";
            LbTareasaRealizar.Size = new Size(168, 18);
            LbTareasaRealizar.TabIndex = 5;
            LbTareasaRealizar.Text = "Tareas Por Realizar";
            // 
            // LbTareaEnProceso
            // 
            LbTareaEnProceso.AutoSize = true;
            LbTareaEnProceso.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareaEnProceso.ForeColor = SystemColors.ButtonHighlight;
            LbTareaEnProceso.Location = new Point(471, 186);
            LbTareaEnProceso.Name = "LbTareaEnProceso";
            LbTareaEnProceso.Size = new Size(167, 18);
            LbTareaEnProceso.TabIndex = 6;
            LbTareaEnProceso.Text = "Tareas En Ejecución";
            // 
            // LbTareasTerminadas
            // 
            LbTareasTerminadas.AutoSize = true;
            LbTareasTerminadas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbTareasTerminadas.ForeColor = SystemColors.ButtonHighlight;
            LbTareasTerminadas.Location = new Point(777, 186);
            LbTareasTerminadas.Name = "LbTareasTerminadas";
            LbTareasTerminadas.Size = new Size(158, 18);
            LbTareasTerminadas.TabIndex = 7;
            LbTareasTerminadas.Text = "Tareas Terminadas";
            // 
            // BtnAgregarTareas
            // 
            BtnAgregarTareas.BackColor = SystemColors.ScrollBar;
            BtnAgregarTareas.FlatAppearance.BorderColor = SystemColors.ScrollBar;
            BtnAgregarTareas.FlatAppearance.BorderSize = 0;
            BtnAgregarTareas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAgregarTareas.ForeColor = SystemColors.ScrollBar;
            BtnAgregarTareas.Location = new Point(894, 194);
            BtnAgregarTareas.Margin = new Padding(0);
            BtnAgregarTareas.Name = "BtnAgregarTareas";
            BtnAgregarTareas.Size = new Size(10, 10);
            BtnAgregarTareas.TabIndex = 1;
            BtnAgregarTareas.Text = "Agregar +";
            BtnAgregarTareas.UseVisualStyleBackColor = false;
            BtnAgregarTareas.Click += BtnAgregarTareas_Click;
            // 
            // CmbPanelTareas
            // 
            CmbPanelTareas.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbPanelTareas.FormattingEnabled = true;
            CmbPanelTareas.Location = new Point(749, 104);
            CmbPanelTareas.Name = "CmbPanelTareas";
            CmbPanelTareas.Size = new Size(211, 26);
            CmbPanelTareas.TabIndex = 8;
            CmbPanelTareas.SelectedIndexChanged += CmbPanelTareas_SelectedIndexChanged;
            // 
            // ControlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1119, 608);
            Controls.Add(CmbPanelTareas);
            Controls.Add(PnlTareasTerminadas);
            Controls.Add(LbTareasTerminadas);
            Controls.Add(LbTareaEnProceso);
            Controls.Add(LbTareasaRealizar);
            Controls.Add(PnlTareasEnProceso);
            Controls.Add(PnlTareasPorRealizar);
            Controls.Add(BtnAgregarTareas);
            Controls.Add(TxtIngresarTarea);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ControlTareas";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtIngresarTarea;
        private FlowLayoutPanel PnlTareasPorRealizar;
        private FlowLayoutPanel PnlTareasEnProceso;
        private FlowLayoutPanel PnlTareasTerminadas;
        private Label LbTareasaRealizar;
        private Label LbTareaEnProceso;
        private Label LbTareasTerminadas;
        private Button BtnAgregarTareas;
        private ComboBox CmbPanelTareas;
    }
}

namespace GestionPacientes
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            pacientesToolStripMenuItem = new ToolStripMenuItem();
            citasToolStripMenuItem = new ToolStripMenuItem();
            facturaciónToolStripMenuItem = new ToolStripMenuItem();
            historialClínicoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            listView1 = new ListView();
            panel2 = new Panel();
            label2 = new Label();
            listView2 = new ListView();
            panel3 = new Panel();
            label3 = new Label();
            listView3 = new ListView();
            panel4 = new Panel();
            label4 = new Label();
            listView4 = new ListView();
            label5 = new Label();
            listView5 = new ListView();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            progressBarTareas = new ProgressBar();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { pacientesToolStripMenuItem, citasToolStripMenuItem, facturaciónToolStripMenuItem, historialClínicoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(959, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            pacientesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            pacientesToolStripMenuItem.Size = new Size(95, 25);
            pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // citasToolStripMenuItem
            // 
            citasToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            citasToolStripMenuItem.Size = new Size(59, 25);
            citasToolStripMenuItem.Text = "Citas";
            // 
            // facturaciónToolStripMenuItem
            // 
            facturaciónToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            facturaciónToolStripMenuItem.Size = new Size(111, 25);
            facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // historialClínicoToolStripMenuItem
            // 
            historialClínicoToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            historialClínicoToolStripMenuItem.Name = "historialClínicoToolStripMenuItem";
            historialClínicoToolStripMenuItem.Size = new Size(144, 25);
            historialClínicoToolStripMenuItem.Text = "Historial Clínico";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cornsilk;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listView1);
            panel1.Location = new Point(684, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 232);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(61, 18);
            label1.Name = "label1";
            label1.Size = new Size(112, 21);
            label1.TabIndex = 1;
            label1.Text = "Próximas Citas";
            // 
            // listView1
            // 
            listView1.Location = new Point(37, 42);
            listView1.Name = "listView1";
            listView1.Size = new Size(181, 138);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listView2);
            panel2.Location = new Point(684, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 232);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(61, 18);
            label2.Name = "label2";
            label2.Size = new Size(128, 21);
            label2.TabIndex = 1;
            label2.Text = "Pacientes Activos";
            // 
            // listView2
            // 
            listView2.Location = new Point(37, 42);
            listView2.Name = "listView2";
            listView2.Size = new Size(181, 138);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PaleGreen;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(listView3);
            panel3.Location = new Point(414, 285);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 232);
            panel3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(61, 18);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 1;
            label3.Text = "Ingresos";
            // 
            // listView3
            // 
            listView3.Location = new Point(37, 42);
            listView3.Name = "listView3";
            listView3.Size = new Size(181, 138);
            listView3.TabIndex = 0;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(listView4);
            panel4.Location = new Point(414, 47);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 232);
            panel4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(61, 18);
            label4.Name = "label4";
            label4.Size = new Size(138, 21);
            label4.TabIndex = 1;
            label4.Text = "Pendiente de pago";
            // 
            // listView4
            // 
            listView4.Location = new Point(37, 42);
            listView4.Name = "listView4";
            listView4.Size = new Size(181, 138);
            listView4.TabIndex = 0;
            listView4.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(110, 65);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 7;
            label5.Text = "Lista de Tareas";
            // 
            // listView5
            // 
            listView5.Location = new Point(12, 98);
            listView5.Name = "listView5";
            listView5.Size = new Size(375, 419);
            listView5.TabIndex = 8;
            listView5.UseCompatibleStateImageBehavior = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(10, 35);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(220, 35);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 25);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            // 
            // progressBarTareas
            // 
            progressBarTareas.Location = new Point(20, 523);
            progressBarTareas.Name = "progressBarTareas";
            progressBarTareas.Size = new Size(200, 25);
            progressBarTareas.TabIndex = 2;
            progressBarTareas.Value = 50;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 570);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(progressBarTareas);
            Controls.Add(listView5);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pacientesToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem facturaciónToolStripMenuItem;
        private ToolStripMenuItem historialClínicoToolStripMenuItem;
        private Panel panel1;
        private ListView listView1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ListView listView2;
        private Panel panel3;
        private Label label3;
        private ListView listView3;
        private Panel panel4;
        private Label label4;
        private ListView listView4;
        private Label label5;
        private ListView listView5;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private ProgressBar progressBarTareas;
    }
}

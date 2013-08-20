namespace mg
{
    partial class menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.despachosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeDespachosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conDiferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinDiferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verificarEstadoNotaPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosMisPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadesDeMedidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.despachosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tablasToolStripMenuItem,
            this.acercaDelSoftwareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(710, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // despachosToolStripMenuItem
            // 
            this.despachosToolStripMenuItem.Name = "despachosToolStripMenuItem";
            this.despachosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.despachosToolStripMenuItem.Text = "Despachos";
            this.despachosToolStripMenuItem.Click += new System.EventHandler(this.despachosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeDespachosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeDespachosToolStripMenuItem
            // 
            this.listadoDeDespachosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.conDiferenciasToolStripMenuItem,
            this.sinDiferenciasToolStripMenuItem});
            this.listadoDeDespachosToolStripMenuItem.Name = "listadoDeDespachosToolStripMenuItem";
            this.listadoDeDespachosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.listadoDeDespachosToolStripMenuItem.Text = "Listado de Despachos";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.generalToolStripMenuItem.Text = "General";
            this.generalToolStripMenuItem.Click += new System.EventHandler(this.generalToolStripMenuItem_Click);
            // 
            // conDiferenciasToolStripMenuItem
            // 
            this.conDiferenciasToolStripMenuItem.Name = "conDiferenciasToolStripMenuItem";
            this.conDiferenciasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.conDiferenciasToolStripMenuItem.Text = "Con Diferencias";
            this.conDiferenciasToolStripMenuItem.Click += new System.EventHandler(this.conDiferenciasToolStripMenuItem_Click);
            // 
            // sinDiferenciasToolStripMenuItem
            // 
            this.sinDiferenciasToolStripMenuItem.Name = "sinDiferenciasToolStripMenuItem";
            this.sinDiferenciasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sinDiferenciasToolStripMenuItem.Text = "Sin Diferencias";
            this.sinDiferenciasToolStripMenuItem.Click += new System.EventHandler(this.sinDiferenciasToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verificarEstadoNotaPedidoToolStripMenuItem,
            this.todosMisPedidosToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // verificarEstadoNotaPedidoToolStripMenuItem
            // 
            this.verificarEstadoNotaPedidoToolStripMenuItem.Name = "verificarEstadoNotaPedidoToolStripMenuItem";
            this.verificarEstadoNotaPedidoToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.verificarEstadoNotaPedidoToolStripMenuItem.Text = "Verificar Estado Nota Pedido";
            this.verificarEstadoNotaPedidoToolStripMenuItem.Click += new System.EventHandler(this.verificarEstadoNotaPedidoToolStripMenuItem_Click);
            // 
            // todosMisPedidosToolStripMenuItem
            // 
            this.todosMisPedidosToolStripMenuItem.Name = "todosMisPedidosToolStripMenuItem";
            this.todosMisPedidosToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.todosMisPedidosToolStripMenuItem.Text = "Todos mis Pedidos";
            this.todosMisPedidosToolStripMenuItem.Click += new System.EventHandler(this.todosMisPedidosToolStripMenuItem_Click);
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.unidadesDeMedidasToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.articulosToolStripMenuItem.Text = "Articulos";
            this.articulosToolStripMenuItem.Click += new System.EventHandler(this.articulosToolStripMenuItem_Click);
            // 
            // unidadesDeMedidasToolStripMenuItem
            // 
            this.unidadesDeMedidasToolStripMenuItem.Name = "unidadesDeMedidasToolStripMenuItem";
            this.unidadesDeMedidasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.unidadesDeMedidasToolStripMenuItem.Text = "Unidades de Medidas";
            this.unidadesDeMedidasToolStripMenuItem.Click += new System.EventHandler(this.unidadesDeMedidasToolStripMenuItem_Click);
            // 
            // acercaDelSoftwareToolStripMenuItem
            // 
            this.acercaDelSoftwareToolStripMenuItem.Name = "acercaDelSoftwareToolStripMenuItem";
            this.acercaDelSoftwareToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDelSoftwareToolStripMenuItem.Text = "Acerca de";
            this.acercaDelSoftwareToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSoftwareToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 17);
            this.toolStripStatusLabel1.Text = "Version 0 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Cliente a Trabajar";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.clientesBindingSource;
            this.comboBox1.DisplayMember = "NombreCliente";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(451, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Cliente";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataSource = typeof(mg.Clientes);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MEGALOG DESPACHO";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem despachosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeDespachosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conDiferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinDiferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarEstadoNotaPedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosMisPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSoftwareToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadesDeMedidasToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
    }
}
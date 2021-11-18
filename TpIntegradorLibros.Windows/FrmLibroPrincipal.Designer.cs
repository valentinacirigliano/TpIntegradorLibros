
namespace TpIntegradorLibros.Windows
{
    partial class FrmLibroPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibroPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NuevoTSB = new System.Windows.Forms.ToolStripButton();
            this.BorrarTSB = new System.Windows.Forms.ToolStripButton();
            this.EditarTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.cienciaficcionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.policialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cienciaFicciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escolarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alianzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.harperCollinsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.houghtonMifflinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penguinGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomHouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenarTSB = new System.Windows.Forms.ToolStripSplitButton();
            this.actualizarTSB = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalirTSB = new System.Windows.Forms.ToolStripButton();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRegistrosLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ascendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NuevoTSB,
            this.BorrarTSB,
            this.EditarTSB,
            this.toolStripSeparator1,
            this.toolStripSplitButton1,
            this.OrdenarTSB,
            this.actualizarTSB,
            this.toolStripSeparator2,
            this.SalirTSB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(636, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NuevoTSB
            // 
            this.NuevoTSB.Image = ((System.Drawing.Image)(resources.GetObject("NuevoTSB.Image")));
            this.NuevoTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NuevoTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NuevoTSB.Name = "NuevoTSB";
            this.NuevoTSB.Size = new System.Drawing.Size(46, 55);
            this.NuevoTSB.Text = "Nuevo";
            this.NuevoTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NuevoTSB.ToolTipText = "Agregar un nuevo libro";
            this.NuevoTSB.Click += new System.EventHandler(this.NuevoTSB_Click);
            // 
            // BorrarTSB
            // 
            this.BorrarTSB.Image = ((System.Drawing.Image)(resources.GetObject("BorrarTSB.Image")));
            this.BorrarTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BorrarTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorrarTSB.Name = "BorrarTSB";
            this.BorrarTSB.Size = new System.Drawing.Size(43, 55);
            this.BorrarTSB.Text = "Borrar";
            this.BorrarTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BorrarTSB.ToolTipText = "Borrar un libro";
            this.BorrarTSB.Click += new System.EventHandler(this.BorrarTSB_Click);
            // 
            // EditarTSB
            // 
            this.EditarTSB.Image = ((System.Drawing.Image)(resources.GetObject("EditarTSB.Image")));
            this.EditarTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EditarTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditarTSB.Name = "EditarTSB";
            this.EditarTSB.Size = new System.Drawing.Size(41, 55);
            this.EditarTSB.Text = "Editar";
            this.EditarTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.EditarTSB.Click += new System.EventHandler(this.EditarTSB_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 58);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cienciaficcionToolStripMenuItem,
            this.editorialToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(53, 55);
            this.toolStripSplitButton1.Text = "Filtrar";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripSplitButton1.ToolTipText = "Filtrar por...";
            // 
            // cienciaficcionToolStripMenuItem
            // 
            this.cienciaficcionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.policialToolStripMenuItem,
            this.novelaToolStripMenuItem,
            this.cienciaFicciónToolStripMenuItem,
            this.romanceToolStripMenuItem,
            this.escolarToolStripMenuItem,
            this.dramaToolStripMenuItem});
            this.cienciaficcionToolStripMenuItem.Name = "cienciaficcionToolStripMenuItem";
            this.cienciaficcionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.cienciaficcionToolStripMenuItem.Text = "Tema";
            // 
            // policialToolStripMenuItem
            // 
            this.policialToolStripMenuItem.Name = "policialToolStripMenuItem";
            this.policialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.policialToolStripMenuItem.Text = "Policial";
            this.policialToolStripMenuItem.Click += new System.EventHandler(this.policialToolStripMenuItem_Click);
            // 
            // novelaToolStripMenuItem
            // 
            this.novelaToolStripMenuItem.Name = "novelaToolStripMenuItem";
            this.novelaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.novelaToolStripMenuItem.Text = "Novela";
            this.novelaToolStripMenuItem.Click += new System.EventHandler(this.novelaToolStripMenuItem_Click);
            // 
            // cienciaFicciónToolStripMenuItem
            // 
            this.cienciaFicciónToolStripMenuItem.Name = "cienciaFicciónToolStripMenuItem";
            this.cienciaFicciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cienciaFicciónToolStripMenuItem.Text = "Ciencia ficción";
            this.cienciaFicciónToolStripMenuItem.Click += new System.EventHandler(this.cienciaFicciónToolStripMenuItem_Click);
            // 
            // romanceToolStripMenuItem
            // 
            this.romanceToolStripMenuItem.Name = "romanceToolStripMenuItem";
            this.romanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.romanceToolStripMenuItem.Text = "Romance";
            this.romanceToolStripMenuItem.Click += new System.EventHandler(this.romanceToolStripMenuItem_Click);
            // 
            // escolarToolStripMenuItem
            // 
            this.escolarToolStripMenuItem.Name = "escolarToolStripMenuItem";
            this.escolarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.escolarToolStripMenuItem.Text = "Escolar";
            this.escolarToolStripMenuItem.Click += new System.EventHandler(this.escolarToolStripMenuItem_Click);
            // 
            // dramaToolStripMenuItem
            // 
            this.dramaToolStripMenuItem.Name = "dramaToolStripMenuItem";
            this.dramaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dramaToolStripMenuItem.Text = "Drama";
            this.dramaToolStripMenuItem.Click += new System.EventHandler(this.dramaToolStripMenuItem_Click);
            // 
            // editorialToolStripMenuItem
            // 
            this.editorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alianzaToolStripMenuItem,
            this.estradaToolStripMenuItem,
            this.harperCollinsToolStripMenuItem,
            this.houghtonMifflinToolStripMenuItem,
            this.penguinGroupToolStripMenuItem,
            this.randomHouseToolStripMenuItem});
            this.editorialToolStripMenuItem.Name = "editorialToolStripMenuItem";
            this.editorialToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editorialToolStripMenuItem.Text = "Editorial";
            // 
            // alianzaToolStripMenuItem
            // 
            this.alianzaToolStripMenuItem.Name = "alianzaToolStripMenuItem";
            this.alianzaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.alianzaToolStripMenuItem.Text = "Alianza";
            this.alianzaToolStripMenuItem.Click += new System.EventHandler(this.alianzaToolStripMenuItem_Click);
            // 
            // estradaToolStripMenuItem
            // 
            this.estradaToolStripMenuItem.Name = "estradaToolStripMenuItem";
            this.estradaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.estradaToolStripMenuItem.Text = "Estrada";
            this.estradaToolStripMenuItem.Click += new System.EventHandler(this.estradaToolStripMenuItem_Click);
            // 
            // harperCollinsToolStripMenuItem
            // 
            this.harperCollinsToolStripMenuItem.Name = "harperCollinsToolStripMenuItem";
            this.harperCollinsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.harperCollinsToolStripMenuItem.Text = "Harper Collins";
            this.harperCollinsToolStripMenuItem.Click += new System.EventHandler(this.harperCollinsToolStripMenuItem_Click);
            // 
            // houghtonMifflinToolStripMenuItem
            // 
            this.houghtonMifflinToolStripMenuItem.Name = "houghtonMifflinToolStripMenuItem";
            this.houghtonMifflinToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.houghtonMifflinToolStripMenuItem.Text = "Houghton Mifflin";
            this.houghtonMifflinToolStripMenuItem.Click += new System.EventHandler(this.houghtonMifflinToolStripMenuItem_Click);
            // 
            // penguinGroupToolStripMenuItem
            // 
            this.penguinGroupToolStripMenuItem.Name = "penguinGroupToolStripMenuItem";
            this.penguinGroupToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.penguinGroupToolStripMenuItem.Text = "Penguin Group";
            this.penguinGroupToolStripMenuItem.Click += new System.EventHandler(this.penguinGroupToolStripMenuItem_Click);
            // 
            // randomHouseToolStripMenuItem
            // 
            this.randomHouseToolStripMenuItem.Name = "randomHouseToolStripMenuItem";
            this.randomHouseToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.randomHouseToolStripMenuItem.Text = "Random House";
            this.randomHouseToolStripMenuItem.Click += new System.EventHandler(this.randomHouseToolStripMenuItem_Click);
            // 
            // OrdenarTSB
            // 
            this.OrdenarTSB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ascendenteToolStripMenuItem,
            this.descendenteToolStripMenuItem});
            this.OrdenarTSB.Image = ((System.Drawing.Image)(resources.GetObject("OrdenarTSB.Image")));
            this.OrdenarTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.OrdenarTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrdenarTSB.Name = "OrdenarTSB";
            this.OrdenarTSB.Size = new System.Drawing.Size(69, 55);
            this.OrdenarTSB.Text = "Ordenar ";
            this.OrdenarTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OrdenarTSB.ToolTipText = "Ordenar por cantidad de páginas";
            // 
            // actualizarTSB
            // 
            this.actualizarTSB.Image = ((System.Drawing.Image)(resources.GetObject("actualizarTSB.Image")));
            this.actualizarTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.actualizarTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.actualizarTSB.Name = "actualizarTSB";
            this.actualizarTSB.Size = new System.Drawing.Size(63, 55);
            this.actualizarTSB.Text = "Actualizar";
            this.actualizarTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.actualizarTSB.ToolTipText = "Muestra los registros en el orden inicial";
            this.actualizarTSB.Click += new System.EventHandler(this.actualizarTSB_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 58);
            // 
            // SalirTSB
            // 
            this.SalirTSB.Image = ((System.Drawing.Image)(resources.GetObject("SalirTSB.Image")));
            this.SalirTSB.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SalirTSB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalirTSB.Name = "SalirTSB";
            this.SalirTSB.Size = new System.Drawing.Size(40, 55);
            this.SalirTSB.Text = "Salir";
            this.SalirTSB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SalirTSB.Click += new System.EventHandler(this.SalirTSB_Click);
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colEditorial,
            this.colTema,
            this.colPaginas,
            this.colISBN,
            this.colAutor});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 58);
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.Size = new System.Drawing.Size(636, 361);
            this.DatosDataGridView.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.HeaderText = "Título";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colEditorial
            // 
            this.colEditorial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEditorial.HeaderText = "Editorial";
            this.colEditorial.Name = "colEditorial";
            this.colEditorial.ReadOnly = true;
            // 
            // colTema
            // 
            this.colTema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTema.HeaderText = "Tema";
            this.colTema.Name = "colTema";
            this.colTema.ReadOnly = true;
            // 
            // colPaginas
            // 
            this.colPaginas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPaginas.HeaderText = "Páginas";
            this.colPaginas.Name = "colPaginas";
            this.colPaginas.ReadOnly = true;
            // 
            // colISBN
            // 
            this.colISBN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.ReadOnly = true;
            // 
            // colAutor
            // 
            this.colAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colAutor.HeaderText = "Autor";
            this.colAutor.Name = "colAutor";
            this.colAutor.ReadOnly = true;
            // 
            // CantidadRegistrosLabel
            // 
            this.CantidadRegistrosLabel.AutoSize = true;
            this.CantidadRegistrosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantidadRegistrosLabel.Location = new System.Drawing.Point(597, 21);
            this.CantidadRegistrosLabel.Name = "CantidadRegistrosLabel";
            this.CantidadRegistrosLabel.Size = new System.Drawing.Size(14, 13);
            this.CantidadRegistrosLabel.TabIndex = 2;
            this.CantidadRegistrosLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(539, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad:";
            // 
            // ascendenteToolStripMenuItem
            // 
            this.ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            this.ascendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ascendenteToolStripMenuItem.Text = "Ascendente";
            this.ascendenteToolStripMenuItem.Click += new System.EventHandler(this.ascendenteToolStripMenuItem_Click);
            // 
            // descendenteToolStripMenuItem
            // 
            this.descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            this.descendenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descendenteToolStripMenuItem.Text = "Descendente";
            this.descendenteToolStripMenuItem.Click += new System.EventHandler(this.descendenteToolStripMenuItem_Click);
            // 
            // FrmLibroPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CantidadRegistrosLabel);
            this.Controls.Add(this.DatosDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmLibroPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLibroPrincipal";
            this.Load += new System.EventHandler(this.FrmLibroPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NuevoTSB;
        private System.Windows.Forms.ToolStripButton BorrarTSB;
        private System.Windows.Forms.ToolStripButton EditarTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SalirTSB;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTema;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAutor;
        private System.Windows.Forms.Label CantidadRegistrosLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSplitButton OrdenarTSB;
        private System.Windows.Forms.ToolStripButton actualizarTSB;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cienciaficcionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem policialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cienciaFicciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escolarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alianzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem harperCollinsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem houghtonMifflinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penguinGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomHouseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descendenteToolStripMenuItem;
    }
}
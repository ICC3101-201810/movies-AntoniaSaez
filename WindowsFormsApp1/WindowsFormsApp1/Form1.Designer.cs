namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.buttonVolverAtras = new System.Windows.Forms.Button();
            this.listBoxListaPeliculas = new System.Windows.Forms.ListBox();
            this.listBoxListaActores = new System.Windows.Forms.ListBox();
            this.listBoxListaDirectores = new System.Windows.Forms.ListBox();
            this.listBoxListaProductores = new System.Windows.Forms.ListBox();
            this.listBoxListaEstudios = new System.Windows.Forms.ListBox();
            this.panelPeliculas = new System.Windows.Forms.Panel();
            this.panelActor = new System.Windows.Forms.Panel();
            this.panelDirector = new System.Windows.Forms.Panel();
            this.panelProductor = new System.Windows.Forms.Panel();
            this.panelEstudio = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.listBoxListaEstudios);
            this.panelMenu.Controls.Add(this.listBoxListaProductores);
            this.panelMenu.Controls.Add(this.listBoxListaDirectores);
            this.panelMenu.Controls.Add(this.listBoxListaActores);
            this.panelMenu.Controls.Add(this.listBoxListaPeliculas);
            this.panelMenu.Controls.Add(this.buttonVolverAtras);
            this.panelMenu.Controls.Add(this.listBoxSearch);
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.buttonEstudios);
            this.panelMenu.Controls.Add(this.buttonProductores);
            this.panelMenu.Controls.Add(this.buttonDirectores);
            this.panelMenu.Controls.Add(this.buttonActores);
            this.panelMenu.Controls.Add(this.buttonPeliculas);
            this.panelMenu.Controls.Add(this.textBoxSearch);
            this.panelMenu.Controls.Add(this.labelSearch);
            this.panelMenu.Location = new System.Drawing.Point(13, 13);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 323);
            this.panelMenu.TabIndex = 0;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(27, 95);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 13);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(80, 92);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(252, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(14, 134);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonPeliculas.TabIndex = 2;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(95, 134);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 23);
            this.buttonActores.TabIndex = 3;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(176, 134);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonDirectores.TabIndex = 4;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(257, 134);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonProductores.TabIndex = 5;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(339, 133);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonEstudios.TabIndex = 6;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(339, 90);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.Location = new System.Drawing.Point(14, 13);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(92, 30);
            this.listBoxSearch.TabIndex = 8;
            this.listBoxSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxSearch_SelectedIndexChanged);
            // 
            // buttonVolverAtras
            // 
            this.buttonVolverAtras.Location = new System.Drawing.Point(339, 267);
            this.buttonVolverAtras.Name = "buttonVolverAtras";
            this.buttonVolverAtras.Size = new System.Drawing.Size(75, 41);
            this.buttonVolverAtras.TabIndex = 9;
            this.buttonVolverAtras.Text = "Volver atras";
            this.buttonVolverAtras.UseVisualStyleBackColor = true;
            this.buttonVolverAtras.Click += new System.EventHandler(this.buttonVolverAtras_Click);
            // 
            // listBoxListaPeliculas
            // 
            this.listBoxListaPeliculas.FormattingEnabled = true;
            this.listBoxListaPeliculas.Location = new System.Drawing.Point(14, 163);
            this.listBoxListaPeliculas.Name = "listBoxListaPeliculas";
            this.listBoxListaPeliculas.Size = new System.Drawing.Size(75, 82);
            this.listBoxListaPeliculas.TabIndex = 10;
            this.listBoxListaPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxListaPeliculas_SelectedIndexChanged);
            // 
            // listBoxListaActores
            // 
            this.listBoxListaActores.FormattingEnabled = true;
            this.listBoxListaActores.Location = new System.Drawing.Point(95, 163);
            this.listBoxListaActores.Name = "listBoxListaActores";
            this.listBoxListaActores.Size = new System.Drawing.Size(75, 82);
            this.listBoxListaActores.TabIndex = 11;
            this.listBoxListaActores.SelectedIndexChanged += new System.EventHandler(this.listBoxListaActores_SelectedIndexChanged);
            // 
            // listBoxListaDirectores
            // 
            this.listBoxListaDirectores.FormattingEnabled = true;
            this.listBoxListaDirectores.Location = new System.Drawing.Point(176, 163);
            this.listBoxListaDirectores.Name = "listBoxListaDirectores";
            this.listBoxListaDirectores.Size = new System.Drawing.Size(75, 82);
            this.listBoxListaDirectores.TabIndex = 12;
            this.listBoxListaDirectores.SelectedIndexChanged += new System.EventHandler(this.listBoxListaDirectores_SelectedIndexChanged);
            // 
            // listBoxListaProductores
            // 
            this.listBoxListaProductores.FormattingEnabled = true;
            this.listBoxListaProductores.Location = new System.Drawing.Point(258, 164);
            this.listBoxListaProductores.Name = "listBoxListaProductores";
            this.listBoxListaProductores.Size = new System.Drawing.Size(74, 82);
            this.listBoxListaProductores.TabIndex = 13;
            this.listBoxListaProductores.SelectedIndexChanged += new System.EventHandler(this.listBoxListaProductores_SelectedIndexChanged);
            // 
            // listBoxListaEstudios
            // 
            this.listBoxListaEstudios.FormattingEnabled = true;
            this.listBoxListaEstudios.Location = new System.Drawing.Point(339, 164);
            this.listBoxListaEstudios.Name = "listBoxListaEstudios";
            this.listBoxListaEstudios.Size = new System.Drawing.Size(75, 82);
            this.listBoxListaEstudios.TabIndex = 14;
            this.listBoxListaEstudios.SelectedIndexChanged += new System.EventHandler(this.listBoxListaEstudios_SelectedIndexChanged);
            // 
            // panelPeliculas
            // 
            this.panelPeliculas.Location = new System.Drawing.Point(260, 13);
            this.panelPeliculas.Name = "panelPeliculas";
            this.panelPeliculas.Size = new System.Drawing.Size(108, 108);
            this.panelPeliculas.TabIndex = 1;
            // 
            // panelActor
            // 
            this.panelActor.Location = new System.Drawing.Point(260, 132);
            this.panelActor.Name = "panelActor";
            this.panelActor.Size = new System.Drawing.Size(108, 114);
            this.panelActor.TabIndex = 2;
            // 
            // panelDirector
            // 
            this.panelDirector.Location = new System.Drawing.Point(375, 13);
            this.panelDirector.Name = "panelDirector";
            this.panelDirector.Size = new System.Drawing.Size(107, 108);
            this.panelDirector.TabIndex = 3;
            // 
            // panelProductor
            // 
            this.panelProductor.Location = new System.Drawing.Point(375, 133);
            this.panelProductor.Name = "panelProductor";
            this.panelProductor.Size = new System.Drawing.Size(117, 113);
            this.panelProductor.TabIndex = 4;
            // 
            // panelEstudio
            // 
            this.panelEstudio.Location = new System.Drawing.Point(260, 266);
            this.panelEstudio.Name = "panelEstudio";
            this.panelEstudio.Size = new System.Drawing.Size(117, 96);
            this.panelEstudio.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 374);
            this.Controls.Add(this.panelEstudio);
            this.Controls.Add(this.panelProductor);
            this.Controls.Add(this.panelDirector);
            this.Controls.Add(this.panelActor);
            this.Controls.Add(this.panelPeliculas);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button buttonVolverAtras;
        private System.Windows.Forms.ListBox listBoxListaEstudios;
        private System.Windows.Forms.ListBox listBoxListaProductores;
        private System.Windows.Forms.ListBox listBoxListaDirectores;
        private System.Windows.Forms.ListBox listBoxListaActores;
        private System.Windows.Forms.ListBox listBoxListaPeliculas;
        private System.Windows.Forms.Panel panelPeliculas;
        private System.Windows.Forms.Panel panelActor;
        private System.Windows.Forms.Panel panelDirector;
        private System.Windows.Forms.Panel panelProductor;
        private System.Windows.Forms.Panel panelEstudio;
    }
}


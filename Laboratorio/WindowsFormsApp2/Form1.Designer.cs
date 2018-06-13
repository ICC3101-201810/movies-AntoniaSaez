namespace WindowsFormsApp2
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
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.listBoxListaEstudios = new System.Windows.Forms.ListBox();
            this.listBoxListaProductores = new System.Windows.Forms.ListBox();
            this.listBoxListaDirectores = new System.Windows.Forms.ListBox();
            this.listBoxListaActores = new System.Windows.Forms.ListBox();
            this.listBoxListaPeliculas = new System.Windows.Forms.ListBox();
            this.buttonVolverAtras = new System.Windows.Forms.Button();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonSalir);
            this.panelMenu.Controls.Add(this.listBoxSearch);
            this.panelMenu.Controls.Add(this.listBoxListaEstudios);
            this.panelMenu.Controls.Add(this.listBoxListaProductores);
            this.panelMenu.Controls.Add(this.listBoxListaDirectores);
            this.panelMenu.Controls.Add(this.listBoxListaActores);
            this.panelMenu.Controls.Add(this.listBoxListaPeliculas);
            this.panelMenu.Controls.Add(this.buttonVolverAtras);
            this.panelMenu.Controls.Add(this.buttonEstudios);
            this.panelMenu.Controls.Add(this.buttonProductores);
            this.panelMenu.Controls.Add(this.buttonDirectores);
            this.panelMenu.Controls.Add(this.buttonActores);
            this.panelMenu.Controls.Add(this.buttonPeliculas);
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.textBoxSearch);
            this.panelMenu.Controls.Add(this.labelSearch);
            this.panelMenu.Location = new System.Drawing.Point(13, 22);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(578, 403);
            this.panelMenu.TabIndex = 0;
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 16;
            this.listBoxSearch.Location = new System.Drawing.Point(34, 14);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.ScrollAlwaysVisible = true;
            this.listBoxSearch.Size = new System.Drawing.Size(349, 244);
            this.listBoxSearch.Sorted = true;
            this.listBoxSearch.TabIndex = 14;
            this.listBoxSearch.SelectedIndexChanged += new System.EventHandler(this.listBoxSearch_SelectedIndexChanged_1);
            // 
            // listBoxListaEstudios
            // 
            this.listBoxListaEstudios.FormattingEnabled = true;
            this.listBoxListaEstudios.ItemHeight = 16;
            this.listBoxListaEstudios.Location = new System.Drawing.Point(438, 208);
            this.listBoxListaEstudios.Name = "listBoxListaEstudios";
            this.listBoxListaEstudios.Size = new System.Drawing.Size(82, 84);
            this.listBoxListaEstudios.TabIndex = 13;
            // 
            // listBoxListaProductores
            // 
            this.listBoxListaProductores.FormattingEnabled = true;
            this.listBoxListaProductores.ItemHeight = 16;
            this.listBoxListaProductores.Location = new System.Drawing.Point(332, 208);
            this.listBoxListaProductores.Name = "listBoxListaProductores";
            this.listBoxListaProductores.Size = new System.Drawing.Size(95, 84);
            this.listBoxListaProductores.TabIndex = 12;
            // 
            // listBoxListaDirectores
            // 
            this.listBoxListaDirectores.FormattingEnabled = true;
            this.listBoxListaDirectores.ItemHeight = 16;
            this.listBoxListaDirectores.Location = new System.Drawing.Point(242, 208);
            this.listBoxListaDirectores.Name = "listBoxListaDirectores";
            this.listBoxListaDirectores.Size = new System.Drawing.Size(83, 84);
            this.listBoxListaDirectores.TabIndex = 11;
            // 
            // listBoxListaActores
            // 
            this.listBoxListaActores.FormattingEnabled = true;
            this.listBoxListaActores.ItemHeight = 16;
            this.listBoxListaActores.Location = new System.Drawing.Point(161, 208);
            this.listBoxListaActores.Name = "listBoxListaActores";
            this.listBoxListaActores.Size = new System.Drawing.Size(74, 84);
            this.listBoxListaActores.TabIndex = 10;
            // 
            // listBoxListaPeliculas
            // 
            this.listBoxListaPeliculas.FormattingEnabled = true;
            this.listBoxListaPeliculas.ItemHeight = 16;
            this.listBoxListaPeliculas.Location = new System.Drawing.Point(75, 208);
            this.listBoxListaPeliculas.Name = "listBoxListaPeliculas";
            this.listBoxListaPeliculas.Size = new System.Drawing.Size(79, 84);
            this.listBoxListaPeliculas.TabIndex = 9;
            // 
            // buttonVolverAtras
            // 
            this.buttonVolverAtras.Location = new System.Drawing.Point(438, 317);
            this.buttonVolverAtras.Name = "buttonVolverAtras";
            this.buttonVolverAtras.Size = new System.Drawing.Size(82, 45);
            this.buttonVolverAtras.TabIndex = 8;
            this.buttonVolverAtras.Text = "Volver Atras";
            this.buttonVolverAtras.UseVisualStyleBackColor = true;
            this.buttonVolverAtras.Click += new System.EventHandler(this.buttonVolverAtras_Click_1);
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(433, 165);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(87, 36);
            this.buttonEstudios.TabIndex = 7;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(331, 165);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(96, 36);
            this.buttonProductores.TabIndex = 6;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(241, 165);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(84, 36);
            this.buttonDirectores.TabIndex = 5;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(160, 165);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(75, 36);
            this.buttonActores.TabIndex = 4;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(75, 165);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(79, 36);
            this.buttonPeliculas.TabIndex = 3;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(433, 111);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 29);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(171, 111);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(247, 29);
            this.textBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(93, 123);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(61, 17);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search :";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(34, 365);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 15;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.ListBox listBoxListaEstudios;
        private System.Windows.Forms.ListBox listBoxListaProductores;
        private System.Windows.Forms.ListBox listBoxListaDirectores;
        private System.Windows.Forms.ListBox listBoxListaActores;
        private System.Windows.Forms.ListBox listBoxListaPeliculas;
        private System.Windows.Forms.Button buttonVolverAtras;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.Button buttonSalir;
    }
}


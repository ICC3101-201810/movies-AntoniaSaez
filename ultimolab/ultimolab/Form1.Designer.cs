namespace ultimolab
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelBienvenido = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxEstudios = new System.Windows.Forms.ListBox();
            this.listBoxProductores = new System.Windows.Forms.ListBox();
            this.listBoxDirectores = new System.Windows.Forms.ListBox();
            this.listBoxActores = new System.Windows.Forms.ListBox();
            this.listBoxPeliculas = new System.Windows.Forms.ListBox();
            this.listBoxSearch = new System.Windows.Forms.ListBox();
            this.buttonEstudios = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.panelPeliculas = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelActores = new System.Windows.Forms.Panel();
            this.panelDirectores = new System.Windows.Forms.Panel();
            this.panelProductores = new System.Windows.Forms.Panel();
            this.panelEstudios = new System.Windows.Forms.Panel();
            this.textBoxNombrePelicula = new System.Windows.Forms.TextBox();
            this.textBoxNombreDirector = new System.Windows.Forms.TextBox();
            this.textBoxFechaEstreno = new System.Windows.Forms.TextBox();
            this.textBoxPresupuesto = new System.Windows.Forms.TextBox();
            this.textBoxEstudio = new System.Windows.Forms.TextBox();
            this.textBoxDescripcionPelicula = new System.Windows.Forms.TextBox();
            this.buttonVolverPeliculas = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxNombreyApellido = new System.Windows.Forms.TextBox();
            this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
            this.textBoxBiografia = new System.Windows.Forms.TextBox();
            this.buttonVolverActores = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxNombreyApellidoD = new System.Windows.Forms.TextBox();
            this.textBoxFechaNacimientoD = new System.Windows.Forms.TextBox();
            this.textBoxBiografiaD = new System.Windows.Forms.TextBox();
            this.buttonVolverDirectores = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNombreApellidoP = new System.Windows.Forms.TextBox();
            this.textBoxFechaNacimientoP = new System.Windows.Forms.TextBox();
            this.textBoxBiografiaP = new System.Windows.Forms.TextBox();
            this.buttonVolverProductores = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxFechaApertura = new System.Windows.Forms.TextBox();
            this.buttonVolverEstudios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelPeliculas.SuspendLayout();
            this.panelActores.SuspendLayout();
            this.panelDirectores.SuspendLayout();
            this.panelProductores.SuspendLayout();
            this.panelEstudios.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelBienvenido);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelBienvenido
            // 
            this.labelBienvenido.AutoSize = true;
            this.labelBienvenido.Location = new System.Drawing.Point(97, 50);
            this.labelBienvenido.Name = "labelBienvenido";
            this.labelBienvenido.Size = new System.Drawing.Size(81, 17);
            this.labelBienvenido.TabIndex = 0;
            this.labelBienvenido.Text = "Bienvenido!";
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxEstudios);
            this.panel2.Controls.Add(this.listBoxProductores);
            this.panel2.Controls.Add(this.listBoxDirectores);
            this.panel2.Controls.Add(this.listBoxActores);
            this.panel2.Controls.Add(this.listBoxPeliculas);
            this.panel2.Controls.Add(this.listBoxSearch);
            this.panel2.Controls.Add(this.buttonEstudios);
            this.panel2.Controls.Add(this.buttonDirectores);
            this.panel2.Controls.Add(this.buttonProductores);
            this.panel2.Controls.Add(this.buttonActores);
            this.panel2.Controls.Add(this.buttonPeliculas);
            this.panel2.Controls.Add(this.buttonSearch);
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.labelSearch);
            this.panel2.Location = new System.Drawing.Point(12, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(56, 59);
            this.panel2.TabIndex = 1;
            // 
            // listBoxEstudios
            // 
            this.listBoxEstudios.FormattingEnabled = true;
            this.listBoxEstudios.ItemHeight = 16;
            this.listBoxEstudios.Location = new System.Drawing.Point(430, 222);
            this.listBoxEstudios.Name = "listBoxEstudios";
            this.listBoxEstudios.Size = new System.Drawing.Size(81, 84);
            this.listBoxEstudios.TabIndex = 13;
            this.listBoxEstudios.SelectedIndexChanged += new System.EventHandler(this.listBoxEstudios_SelectedIndexChanged);
            // 
            // listBoxProductores
            // 
            this.listBoxProductores.FormattingEnabled = true;
            this.listBoxProductores.ItemHeight = 16;
            this.listBoxProductores.Location = new System.Drawing.Point(332, 222);
            this.listBoxProductores.Name = "listBoxProductores";
            this.listBoxProductores.Size = new System.Drawing.Size(92, 84);
            this.listBoxProductores.TabIndex = 12;
            this.listBoxProductores.SelectedIndexChanged += new System.EventHandler(this.listBoxProductores_SelectedIndexChanged);
            // 
            // listBoxDirectores
            // 
            this.listBoxDirectores.FormattingEnabled = true;
            this.listBoxDirectores.ItemHeight = 16;
            this.listBoxDirectores.Location = new System.Drawing.Point(240, 222);
            this.listBoxDirectores.Name = "listBoxDirectores";
            this.listBoxDirectores.Size = new System.Drawing.Size(85, 84);
            this.listBoxDirectores.TabIndex = 11;
            this.listBoxDirectores.SelectedIndexChanged += new System.EventHandler(this.listBoxDirectores_SelectedIndexChanged);
            // 
            // listBoxActores
            // 
            this.listBoxActores.FormattingEnabled = true;
            this.listBoxActores.ItemHeight = 16;
            this.listBoxActores.Location = new System.Drawing.Point(149, 222);
            this.listBoxActores.Name = "listBoxActores";
            this.listBoxActores.Size = new System.Drawing.Size(84, 84);
            this.listBoxActores.TabIndex = 10;
            this.listBoxActores.SelectedIndexChanged += new System.EventHandler(this.listBoxActores_SelectedIndexChanged);
            // 
            // listBoxPeliculas
            // 
            this.listBoxPeliculas.FormattingEnabled = true;
            this.listBoxPeliculas.ItemHeight = 16;
            this.listBoxPeliculas.Location = new System.Drawing.Point(55, 222);
            this.listBoxPeliculas.Name = "listBoxPeliculas";
            this.listBoxPeliculas.Size = new System.Drawing.Size(87, 84);
            this.listBoxPeliculas.TabIndex = 9;
            this.listBoxPeliculas.SelectedIndexChanged += new System.EventHandler(this.listBoxPeliculas_SelectedIndexChanged);
            // 
            // listBoxSearch
            // 
            this.listBoxSearch.FormattingEnabled = true;
            this.listBoxSearch.ItemHeight = 16;
            this.listBoxSearch.Location = new System.Drawing.Point(148, 17);
            this.listBoxSearch.Name = "listBoxSearch";
            this.listBoxSearch.Size = new System.Drawing.Size(399, 84);
            this.listBoxSearch.TabIndex = 8;
            // 
            // buttonEstudios
            // 
            this.buttonEstudios.Location = new System.Drawing.Point(430, 176);
            this.buttonEstudios.Name = "buttonEstudios";
            this.buttonEstudios.Size = new System.Drawing.Size(81, 39);
            this.buttonEstudios.TabIndex = 7;
            this.buttonEstudios.Text = "Estudios";
            this.buttonEstudios.UseVisualStyleBackColor = true;
            this.buttonEstudios.Click += new System.EventHandler(this.buttonEstudios_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(239, 176);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(86, 39);
            this.buttonDirectores.TabIndex = 6;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(331, 176);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(93, 39);
            this.buttonProductores.TabIndex = 5;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(148, 176);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(85, 39);
            this.buttonActores.TabIndex = 4;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(55, 176);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(87, 39);
            this.buttonPeliculas.TabIndex = 3;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(430, 122);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(82, 32);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(148, 123);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(339, 31);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(67, 130);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(75, 24);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Search:";
            // 
            // panelPeliculas
            // 
            this.panelPeliculas.Controls.Add(this.buttonVolverPeliculas);
            this.panelPeliculas.Controls.Add(this.textBoxDescripcionPelicula);
            this.panelPeliculas.Controls.Add(this.textBoxEstudio);
            this.panelPeliculas.Controls.Add(this.textBoxPresupuesto);
            this.panelPeliculas.Controls.Add(this.textBoxFechaEstreno);
            this.panelPeliculas.Controls.Add(this.textBoxNombreDirector);
            this.panelPeliculas.Controls.Add(this.textBoxNombrePelicula);
            this.panelPeliculas.Controls.Add(this.label7);
            this.panelPeliculas.Controls.Add(this.label6);
            this.panelPeliculas.Controls.Add(this.label5);
            this.panelPeliculas.Controls.Add(this.label4);
            this.panelPeliculas.Controls.Add(this.label3);
            this.panelPeliculas.Controls.Add(this.label2);
            this.panelPeliculas.Controls.Add(this.label1);
            this.panelPeliculas.Location = new System.Drawing.Point(112, 18);
            this.panelPeliculas.Name = "panelPeliculas";
            this.panelPeliculas.Size = new System.Drawing.Size(45, 48);
            this.panelPeliculas.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estudio: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Presupuesto: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Estreno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Pelicula:\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peliculas";
            // 
            // panelActores
            // 
            this.panelActores.Controls.Add(this.buttonVolverActores);
            this.panelActores.Controls.Add(this.textBoxBiografia);
            this.panelActores.Controls.Add(this.textBoxFechaNacimiento);
            this.panelActores.Controls.Add(this.textBoxNombreyApellido);
            this.panelActores.Controls.Add(this.label11);
            this.panelActores.Controls.Add(this.label10);
            this.panelActores.Controls.Add(this.label9);
            this.panelActores.Controls.Add(this.label8);
            this.panelActores.Location = new System.Drawing.Point(164, 15);
            this.panelActores.Name = "panelActores";
            this.panelActores.Size = new System.Drawing.Size(78, 53);
            this.panelActores.TabIndex = 3;
            // 
            // panelDirectores
            // 
            this.panelDirectores.Controls.Add(this.buttonVolverDirectores);
            this.panelDirectores.Controls.Add(this.textBoxBiografiaD);
            this.panelDirectores.Controls.Add(this.textBoxFechaNacimientoD);
            this.panelDirectores.Controls.Add(this.textBoxNombreyApellidoD);
            this.panelDirectores.Controls.Add(this.label15);
            this.panelDirectores.Controls.Add(this.label14);
            this.panelDirectores.Controls.Add(this.label13);
            this.panelDirectores.Controls.Add(this.label12);
            this.panelDirectores.Location = new System.Drawing.Point(248, 18);
            this.panelDirectores.Name = "panelDirectores";
            this.panelDirectores.Size = new System.Drawing.Size(71, 57);
            this.panelDirectores.TabIndex = 4;
            // 
            // panelProductores
            // 
            this.panelProductores.Controls.Add(this.buttonVolverProductores);
            this.panelProductores.Controls.Add(this.textBoxBiografiaP);
            this.panelProductores.Controls.Add(this.textBoxFechaNacimientoP);
            this.panelProductores.Controls.Add(this.textBoxNombreApellidoP);
            this.panelProductores.Controls.Add(this.label19);
            this.panelProductores.Controls.Add(this.label18);
            this.panelProductores.Controls.Add(this.label17);
            this.panelProductores.Controls.Add(this.label16);
            this.panelProductores.Location = new System.Drawing.Point(325, 15);
            this.panelProductores.Name = "panelProductores";
            this.panelProductores.Size = new System.Drawing.Size(68, 45);
            this.panelProductores.TabIndex = 5;
            // 
            // panelEstudios
            // 
            this.panelEstudios.Controls.Add(this.buttonVolverEstudios);
            this.panelEstudios.Controls.Add(this.textBoxFechaApertura);
            this.panelEstudios.Controls.Add(this.textBoxDireccion);
            this.panelEstudios.Controls.Add(this.textBoxNombre);
            this.panelEstudios.Controls.Add(this.label23);
            this.panelEstudios.Controls.Add(this.label22);
            this.panelEstudios.Controls.Add(this.label21);
            this.panelEstudios.Controls.Add(this.label20);
            this.panelEstudios.Location = new System.Drawing.Point(421, 14);
            this.panelEstudios.Name = "panelEstudios";
            this.panelEstudios.Size = new System.Drawing.Size(61, 51);
            this.panelEstudios.TabIndex = 6;
            // 
            // textBoxNombrePelicula
            // 
            this.textBoxNombrePelicula.Location = new System.Drawing.Point(167, 53);
            this.textBoxNombrePelicula.Name = "textBoxNombrePelicula";
            this.textBoxNombrePelicula.Size = new System.Drawing.Size(207, 22);
            this.textBoxNombrePelicula.TabIndex = 7;
            // 
            // textBoxNombreDirector
            // 
            this.textBoxNombreDirector.Location = new System.Drawing.Point(167, 83);
            this.textBoxNombreDirector.Name = "textBoxNombreDirector";
            this.textBoxNombreDirector.Size = new System.Drawing.Size(207, 22);
            this.textBoxNombreDirector.TabIndex = 8;
            // 
            // textBoxFechaEstreno
            // 
            this.textBoxFechaEstreno.Location = new System.Drawing.Point(167, 111);
            this.textBoxFechaEstreno.Name = "textBoxFechaEstreno";
            this.textBoxFechaEstreno.Size = new System.Drawing.Size(207, 22);
            this.textBoxFechaEstreno.TabIndex = 9;
            // 
            // textBoxPresupuesto
            // 
            this.textBoxPresupuesto.Location = new System.Drawing.Point(167, 144);
            this.textBoxPresupuesto.Name = "textBoxPresupuesto";
            this.textBoxPresupuesto.Size = new System.Drawing.Size(207, 22);
            this.textBoxPresupuesto.TabIndex = 10;
            // 
            // textBoxEstudio
            // 
            this.textBoxEstudio.Location = new System.Drawing.Point(167, 177);
            this.textBoxEstudio.Name = "textBoxEstudio";
            this.textBoxEstudio.Size = new System.Drawing.Size(207, 22);
            this.textBoxEstudio.TabIndex = 11;
            // 
            // textBoxDescripcionPelicula
            // 
            this.textBoxDescripcionPelicula.Location = new System.Drawing.Point(167, 206);
            this.textBoxDescripcionPelicula.Multiline = true;
            this.textBoxDescripcionPelicula.Name = "textBoxDescripcionPelicula";
            this.textBoxDescripcionPelicula.Size = new System.Drawing.Size(207, 68);
            this.textBoxDescripcionPelicula.TabIndex = 12;
            // 
            // buttonVolverPeliculas
            // 
            this.buttonVolverPeliculas.Location = new System.Drawing.Point(299, 307);
            this.buttonVolverPeliculas.Name = "buttonVolverPeliculas";
            this.buttonVolverPeliculas.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverPeliculas.TabIndex = 13;
            this.buttonVolverPeliculas.Text = "Volver";
            this.buttonVolverPeliculas.UseVisualStyleBackColor = true;
            this.buttonVolverPeliculas.Click += new System.EventHandler(this.buttonVolverPeliculas_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(200, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Actores";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nombre y Apellido:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Fecha de Nacimiento: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Biografia: ";
            // 
            // textBoxNombreyApellido
            // 
            this.textBoxNombreyApellido.Location = new System.Drawing.Point(233, 75);
            this.textBoxNombreyApellido.Name = "textBoxNombreyApellido";
            this.textBoxNombreyApellido.Size = new System.Drawing.Size(173, 22);
            this.textBoxNombreyApellido.TabIndex = 4;
            // 
            // textBoxFechaNacimiento
            // 
            this.textBoxFechaNacimiento.Location = new System.Drawing.Point(233, 120);
            this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            this.textBoxFechaNacimiento.Size = new System.Drawing.Size(173, 22);
            this.textBoxFechaNacimiento.TabIndex = 5;
            // 
            // textBoxBiografia
            // 
            this.textBoxBiografia.Location = new System.Drawing.Point(233, 169);
            this.textBoxBiografia.Multiline = true;
            this.textBoxBiografia.Name = "textBoxBiografia";
            this.textBoxBiografia.Size = new System.Drawing.Size(173, 78);
            this.textBoxBiografia.TabIndex = 6;
            // 
            // buttonVolverActores
            // 
            this.buttonVolverActores.Location = new System.Drawing.Point(331, 270);
            this.buttonVolverActores.Name = "buttonVolverActores";
            this.buttonVolverActores.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverActores.TabIndex = 7;
            this.buttonVolverActores.Text = "Volver";
            this.buttonVolverActores.UseVisualStyleBackColor = true;
            this.buttonVolverActores.Click += new System.EventHandler(this.buttonVolverActores_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(178, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 29);
            this.label12.TabIndex = 0;
            this.label12.Text = "Directores";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre y Apellido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(63, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fecha de Nacimiento: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 17);
            this.label15.TabIndex = 3;
            this.label15.Text = "Biografia: ";
            // 
            // textBoxNombreyApellidoD
            // 
            this.textBoxNombreyApellidoD.Location = new System.Drawing.Point(231, 59);
            this.textBoxNombreyApellidoD.Name = "textBoxNombreyApellidoD";
            this.textBoxNombreyApellidoD.Size = new System.Drawing.Size(181, 22);
            this.textBoxNombreyApellidoD.TabIndex = 4;
            this.textBoxNombreyApellidoD.TextChanged += new System.EventHandler(this.NombreyApellidoD_TextChanged);
            // 
            // textBoxFechaNacimientoD
            // 
            this.textBoxFechaNacimientoD.Location = new System.Drawing.Point(231, 113);
            this.textBoxFechaNacimientoD.Name = "textBoxFechaNacimientoD";
            this.textBoxFechaNacimientoD.Size = new System.Drawing.Size(181, 22);
            this.textBoxFechaNacimientoD.TabIndex = 5;
            // 
            // textBoxBiografiaD
            // 
            this.textBoxBiografiaD.Location = new System.Drawing.Point(232, 158);
            this.textBoxBiografiaD.Multiline = true;
            this.textBoxBiografiaD.Name = "textBoxBiografiaD";
            this.textBoxBiografiaD.Size = new System.Drawing.Size(180, 77);
            this.textBoxBiografiaD.TabIndex = 6;
            // 
            // buttonVolverDirectores
            // 
            this.buttonVolverDirectores.Location = new System.Drawing.Point(337, 258);
            this.buttonVolverDirectores.Name = "buttonVolverDirectores";
            this.buttonVolverDirectores.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverDirectores.TabIndex = 7;
            this.buttonVolverDirectores.Text = "Volver";
            this.buttonVolverDirectores.UseVisualStyleBackColor = true;
            this.buttonVolverDirectores.Click += new System.EventHandler(this.buttonVolverDirectores_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(163, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 29);
            this.label16.TabIndex = 0;
            this.label16.Text = "Productores";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Nombre y Apellido: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(54, 118);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Fecha de Nacimiento: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(56, 159);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 3;
            this.label19.Text = "Biografia";
            // 
            // textBoxNombreApellidoP
            // 
            this.textBoxNombreApellidoP.Location = new System.Drawing.Point(222, 70);
            this.textBoxNombreApellidoP.Name = "textBoxNombreApellidoP";
            this.textBoxNombreApellidoP.Size = new System.Drawing.Size(180, 22);
            this.textBoxNombreApellidoP.TabIndex = 4;
            // 
            // textBoxFechaNacimientoP
            // 
            this.textBoxFechaNacimientoP.Location = new System.Drawing.Point(222, 112);
            this.textBoxFechaNacimientoP.Name = "textBoxFechaNacimientoP";
            this.textBoxFechaNacimientoP.Size = new System.Drawing.Size(179, 22);
            this.textBoxFechaNacimientoP.TabIndex = 5;
            // 
            // textBoxBiografiaP
            // 
            this.textBoxBiografiaP.Location = new System.Drawing.Point(222, 159);
            this.textBoxBiografiaP.Multiline = true;
            this.textBoxBiografiaP.Name = "textBoxBiografiaP";
            this.textBoxBiografiaP.Size = new System.Drawing.Size(180, 76);
            this.textBoxBiografiaP.TabIndex = 6;
            // 
            // buttonVolverProductores
            // 
            this.buttonVolverProductores.Location = new System.Drawing.Point(327, 252);
            this.buttonVolverProductores.Name = "buttonVolverProductores";
            this.buttonVolverProductores.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverProductores.TabIndex = 7;
            this.buttonVolverProductores.Text = "Volver";
            this.buttonVolverProductores.UseVisualStyleBackColor = true;
            this.buttonVolverProductores.Click += new System.EventHandler(this.buttonVolverProductores_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(199, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Estudios";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(58, 70);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 17);
            this.label21.TabIndex = 1;
            this.label21.Text = "Nombre:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(54, 130);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 17);
            this.label22.TabIndex = 2;
            this.label22.Text = "Direccion: ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(54, 178);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 17);
            this.label23.TabIndex = 3;
            this.label23.Text = "Fecha de Apertura: ";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(213, 66);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(156, 22);
            this.textBoxNombre.TabIndex = 4;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(213, 123);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(156, 22);
            this.textBoxDireccion.TabIndex = 5;
            // 
            // textBoxFechaApertura
            // 
            this.textBoxFechaApertura.Location = new System.Drawing.Point(214, 175);
            this.textBoxFechaApertura.Name = "textBoxFechaApertura";
            this.textBoxFechaApertura.Size = new System.Drawing.Size(155, 22);
            this.textBoxFechaApertura.TabIndex = 6;
            // 
            // buttonVolverEstudios
            // 
            this.buttonVolverEstudios.Location = new System.Drawing.Point(275, 217);
            this.buttonVolverEstudios.Name = "buttonVolverEstudios";
            this.buttonVolverEstudios.Size = new System.Drawing.Size(75, 23);
            this.buttonVolverEstudios.TabIndex = 7;
            this.buttonVolverEstudios.Text = "Volver";
            this.buttonVolverEstudios.UseVisualStyleBackColor = true;
            this.buttonVolverEstudios.Click += new System.EventHandler(this.buttonVolverEstudios_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEstudios);
            this.Controls.Add(this.panelProductores);
            this.Controls.Add(this.panelDirectores);
            this.Controls.Add(this.panelActores);
            this.Controls.Add(this.panelPeliculas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPeliculas.ResumeLayout(false);
            this.panelPeliculas.PerformLayout();
            this.panelActores.ResumeLayout(false);
            this.panelActores.PerformLayout();
            this.panelDirectores.ResumeLayout(false);
            this.panelDirectores.PerformLayout();
            this.panelProductores.ResumeLayout(false);
            this.panelProductores.PerformLayout();
            this.panelEstudios.ResumeLayout(false);
            this.panelEstudios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelBienvenido;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonEstudios;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.ListBox listBoxSearch;
        private System.Windows.Forms.ListBox listBoxEstudios;
        private System.Windows.Forms.ListBox listBoxProductores;
        private System.Windows.Forms.ListBox listBoxDirectores;
        private System.Windows.Forms.ListBox listBoxActores;
        private System.Windows.Forms.ListBox listBoxPeliculas;
        private System.Windows.Forms.Panel panelPeliculas;
        private System.Windows.Forms.Panel panelActores;
        private System.Windows.Forms.Panel panelDirectores;
        private System.Windows.Forms.Panel panelProductores;
        private System.Windows.Forms.Panel panelEstudios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescripcionPelicula;
        private System.Windows.Forms.TextBox textBoxEstudio;
        private System.Windows.Forms.TextBox textBoxPresupuesto;
        private System.Windows.Forms.TextBox textBoxFechaEstreno;
        private System.Windows.Forms.TextBox textBoxNombreDirector;
        private System.Windows.Forms.TextBox textBoxNombrePelicula;
        private System.Windows.Forms.Button buttonVolverPeliculas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxBiografia;
        private System.Windows.Forms.TextBox textBoxFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxNombreyApellido;
        private System.Windows.Forms.Button buttonVolverActores;
        private System.Windows.Forms.TextBox textBoxBiografiaD;
        private System.Windows.Forms.TextBox textBoxFechaNacimientoD;
        private System.Windows.Forms.TextBox textBoxNombreyApellidoD;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonVolverDirectores;
        private System.Windows.Forms.TextBox textBoxBiografiaP;
        private System.Windows.Forms.TextBox textBoxFechaNacimientoP;
        private System.Windows.Forms.TextBox textBoxNombreApellidoP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonVolverProductores;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button buttonVolverEstudios;
        private System.Windows.Forms.TextBox textBoxFechaApertura;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}


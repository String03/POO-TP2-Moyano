namespace POO_TP2_Moyano
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_agregar_contenedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_contenedor_a = new System.Windows.Forms.RadioButton();
            this.rdo_contenedor_b = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion_contenedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_fecha_ingreso_contenedor = new System.Windows.Forms.TextBox();
            this.txt_peso_contenedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_legajo_cliente_persona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.btn_agregar_cliente = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_apellido_cliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_legajo_cliente_empresa = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_cliente_razon_social = new System.Windows.Forms.TextBox();
            this.btn_mostrar_contenedores_cliente = new System.Windows.Forms.Button();
            this.rdo_personas = new System.Windows.Forms.RadioButton();
            this.rdo_empresas = new System.Windows.Forms.RadioButton();
            this.txt_id_contenedor = new System.Windows.Forms.MaskedTextBox();
            this.btn_modificar_contenedor = new System.Windows.Forms.Button();
            this.btn_eliminar_contenedor = new System.Windows.Forms.Button();
            this.btn_modificar_cliente = new System.Windows.Forms.Button();
            this.btn_eliminar_cliente = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(589, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-6, 278);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(589, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(777, 25);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(581, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // btn_agregar_contenedor
            // 
            this.btn_agregar_contenedor.Location = new System.Drawing.Point(4, 181);
            this.btn_agregar_contenedor.Name = "btn_agregar_contenedor";
            this.btn_agregar_contenedor.Size = new System.Drawing.Size(115, 24);
            this.btn_agregar_contenedor.TabIndex = 3;
            this.btn_agregar_contenedor.Text = "Cargar Contenedor";
            this.btn_agregar_contenedor.UseVisualStyleBackColor = true;
            this.btn_agregar_contenedor.Click += new System.EventHandler(this.btn_agregar_contenedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contenedores";
            // 
            // rdo_contenedor_a
            // 
            this.rdo_contenedor_a.AutoSize = true;
            this.rdo_contenedor_a.Checked = true;
            this.rdo_contenedor_a.Location = new System.Drawing.Point(6, 19);
            this.rdo_contenedor_a.Name = "rdo_contenedor_a";
            this.rdo_contenedor_a.Size = new System.Drawing.Size(90, 17);
            this.rdo_contenedor_a.TabIndex = 6;
            this.rdo_contenedor_a.TabStop = true;
            this.rdo_contenedor_a.Text = "Contenedor A";
            this.rdo_contenedor_a.UseVisualStyleBackColor = true;
            // 
            // rdo_contenedor_b
            // 
            this.rdo_contenedor_b.AutoSize = true;
            this.rdo_contenedor_b.Location = new System.Drawing.Point(6, 43);
            this.rdo_contenedor_b.Name = "rdo_contenedor_b";
            this.rdo_contenedor_b.Size = new System.Drawing.Size(90, 17);
            this.rdo_contenedor_b.TabIndex = 7;
            this.rdo_contenedor_b.Text = "Contenedor B";
            this.rdo_contenedor_b.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Descripción";
            // 
            // txt_descripcion_contenedor
            // 
            this.txt_descripcion_contenedor.Location = new System.Drawing.Point(284, 238);
            this.txt_descripcion_contenedor.Name = "txt_descripcion_contenedor";
            this.txt_descripcion_contenedor.Size = new System.Drawing.Size(100, 20);
            this.txt_descripcion_contenedor.TabIndex = 10;
            this.txt_descripcion_contenedor.Text = "rosado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(397, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha de Ingreso";
            // 
            // txt_fecha_ingreso_contenedor
            // 
            this.txt_fecha_ingreso_contenedor.Location = new System.Drawing.Point(493, 185);
            this.txt_fecha_ingreso_contenedor.Name = "txt_fecha_ingreso_contenedor";
            this.txt_fecha_ingreso_contenedor.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_ingreso_contenedor.TabIndex = 13;
            this.txt_fecha_ingreso_contenedor.Text = "10/10/1998";
            // 
            // txt_peso_contenedor
            // 
            this.txt_peso_contenedor.Location = new System.Drawing.Point(493, 241);
            this.txt_peso_contenedor.Name = "txt_peso_contenedor";
            this.txt_peso_contenedor.Size = new System.Drawing.Size(100, 20);
            this.txt_peso_contenedor.TabIndex = 14;
            this.txt_peso_contenedor.Text = "7800";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(397, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Peso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Personas";
            // 
            // txt_legajo_cliente_persona
            // 
            this.txt_legajo_cliente_persona.Location = new System.Drawing.Point(245, 466);
            this.txt_legajo_cliente_persona.Name = "txt_legajo_cliente_persona";
            this.txt_legajo_cliente_persona.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo_cliente_persona.TabIndex = 18;
            this.txt_legajo_cliente_persona.Text = "23423";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Legajo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 492);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Nombre";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(245, 492);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_cliente.TabIndex = 21;
            this.txt_nombre_cliente.Text = "ana";
            // 
            // btn_agregar_cliente
            // 
            this.btn_agregar_cliente.Location = new System.Drawing.Point(4, 434);
            this.btn_agregar_cliente.Name = "btn_agregar_cliente";
            this.btn_agregar_cliente.Size = new System.Drawing.Size(115, 23);
            this.btn_agregar_cliente.TabIndex = 22;
            this.btn_agregar_cliente.Text = "Cargar Cliente";
            this.btn_agregar_cliente.UseVisualStyleBackColor = true;
            this.btn_agregar_cliente.Click += new System.EventHandler(this.btn_agregar_cliente_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 529);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Apellido";
            // 
            // txt_apellido_cliente
            // 
            this.txt_apellido_cliente.Location = new System.Drawing.Point(245, 526);
            this.txt_apellido_cliente.Name = "txt_apellido_cliente";
            this.txt_apellido_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_cliente.TabIndex = 24;
            this.txt_apellido_cliente.Text = "laura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Empresas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(403, 463);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Legajo";
            // 
            // txt_legajo_cliente_empresa
            // 
            this.txt_legajo_cliente_empresa.Enabled = false;
            this.txt_legajo_cliente_empresa.Location = new System.Drawing.Point(463, 456);
            this.txt_legajo_cliente_empresa.Name = "txt_legajo_cliente_empresa";
            this.txt_legajo_cliente_empresa.Size = new System.Drawing.Size(100, 20);
            this.txt_legajo_cliente_empresa.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 495);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Razón Social";
            // 
            // txt_cliente_razon_social
            // 
            this.txt_cliente_razon_social.Enabled = false;
            this.txt_cliente_razon_social.Location = new System.Drawing.Point(463, 495);
            this.txt_cliente_razon_social.Name = "txt_cliente_razon_social";
            this.txt_cliente_razon_social.Size = new System.Drawing.Size(100, 20);
            this.txt_cliente_razon_social.TabIndex = 29;
            // 
            // btn_mostrar_contenedores_cliente
            // 
            this.btn_mostrar_contenedores_cliente.Location = new System.Drawing.Point(638, 91);
            this.btn_mostrar_contenedores_cliente.Name = "btn_mostrar_contenedores_cliente";
            this.btn_mostrar_contenedores_cliente.Size = new System.Drawing.Size(121, 39);
            this.btn_mostrar_contenedores_cliente.TabIndex = 30;
            this.btn_mostrar_contenedores_cliente.Text = "Mostrar Contenedores del cliente";
            this.btn_mostrar_contenedores_cliente.UseVisualStyleBackColor = true;
            this.btn_mostrar_contenedores_cliente.Click += new System.EventHandler(this.btn_mostrar_contenedores_cliente_Click);
            // 
            // rdo_personas
            // 
            this.rdo_personas.AutoSize = true;
            this.rdo_personas.Checked = true;
            this.rdo_personas.Location = new System.Drawing.Point(18, 19);
            this.rdo_personas.Name = "rdo_personas";
            this.rdo_personas.Size = new System.Drawing.Size(69, 17);
            this.rdo_personas.TabIndex = 31;
            this.rdo_personas.TabStop = true;
            this.rdo_personas.Text = "Personas";
            this.rdo_personas.UseVisualStyleBackColor = true;
            this.rdo_personas.CheckedChanged += new System.EventHandler(this.rdo_personas_CheckedChanged);
            // 
            // rdo_empresas
            // 
            this.rdo_empresas.AutoSize = true;
            this.rdo_empresas.Location = new System.Drawing.Point(16, 42);
            this.rdo_empresas.Name = "rdo_empresas";
            this.rdo_empresas.Size = new System.Drawing.Size(71, 17);
            this.rdo_empresas.TabIndex = 32;
            this.rdo_empresas.Text = "Empresas";
            this.rdo_empresas.UseVisualStyleBackColor = true;
            // 
            // txt_id_contenedor
            // 
            this.txt_id_contenedor.Location = new System.Drawing.Point(284, 185);
            this.txt_id_contenedor.Mask = "000-LLLL";
            this.txt_id_contenedor.Name = "txt_id_contenedor";
            this.txt_id_contenedor.Size = new System.Drawing.Size(100, 20);
            this.txt_id_contenedor.TabIndex = 33;
            this.txt_id_contenedor.Text = "233sfsd";
            // 
            // btn_modificar_contenedor
            // 
            this.btn_modificar_contenedor.Location = new System.Drawing.Point(4, 208);
            this.btn_modificar_contenedor.Name = "btn_modificar_contenedor";
            this.btn_modificar_contenedor.Size = new System.Drawing.Size(126, 23);
            this.btn_modificar_contenedor.TabIndex = 34;
            this.btn_modificar_contenedor.Text = "Modificar Contenedor";
            this.btn_modificar_contenedor.UseVisualStyleBackColor = true;
            this.btn_modificar_contenedor.Click += new System.EventHandler(this.btn_modificar_contenedor_Click);
            // 
            // btn_eliminar_contenedor
            // 
            this.btn_eliminar_contenedor.Location = new System.Drawing.Point(4, 236);
            this.btn_eliminar_contenedor.Name = "btn_eliminar_contenedor";
            this.btn_eliminar_contenedor.Size = new System.Drawing.Size(115, 23);
            this.btn_eliminar_contenedor.TabIndex = 35;
            this.btn_eliminar_contenedor.Text = "Eliminar Contenedor";
            this.btn_eliminar_contenedor.UseVisualStyleBackColor = true;
            this.btn_eliminar_contenedor.Click += new System.EventHandler(this.btn_eliminar_contenedor_Click);
            // 
            // btn_modificar_cliente
            // 
            this.btn_modificar_cliente.Location = new System.Drawing.Point(1, 458);
            this.btn_modificar_cliente.Name = "btn_modificar_cliente";
            this.btn_modificar_cliente.Size = new System.Drawing.Size(126, 23);
            this.btn_modificar_cliente.TabIndex = 36;
            this.btn_modificar_cliente.Text = "Modificar Cliente";
            this.btn_modificar_cliente.UseVisualStyleBackColor = true;
            this.btn_modificar_cliente.Click += new System.EventHandler(this.btn_modificar_cliente_Click);
            // 
            // btn_eliminar_cliente
            // 
            this.btn_eliminar_cliente.Location = new System.Drawing.Point(4, 482);
            this.btn_eliminar_cliente.Name = "btn_eliminar_cliente";
            this.btn_eliminar_cliente.Size = new System.Drawing.Size(115, 23);
            this.btn_eliminar_cliente.TabIndex = 37;
            this.btn_eliminar_cliente.Text = "Eliminar Cliente";
            this.btn_eliminar_cliente.UseVisualStyleBackColor = true;
            this.btn_eliminar_cliente.Click += new System.EventHandler(this.btn_eliminar_cliente_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_contenedor_a);
            this.groupBox1.Controls.Add(this.rdo_contenedor_b);
            this.groupBox1.Location = new System.Drawing.Point(125, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(109, 60);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_personas);
            this.groupBox2.Controls.Add(this.rdo_empresas);
            this.groupBox2.Location = new System.Drawing.Point(12, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(98, 69);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 605);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_eliminar_cliente);
            this.Controls.Add(this.btn_modificar_cliente);
            this.Controls.Add(this.btn_eliminar_contenedor);
            this.Controls.Add(this.btn_modificar_contenedor);
            this.Controls.Add(this.txt_id_contenedor);
            this.Controls.Add(this.btn_mostrar_contenedores_cliente);
            this.Controls.Add(this.txt_cliente_razon_social);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_legajo_cliente_empresa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_apellido_cliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_agregar_cliente);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_legajo_cliente_persona);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_peso_contenedor);
            this.Controls.Add(this.txt_fecha_ingreso_contenedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion_contenedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar_contenedor);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btn_agregar_contenedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_contenedor_a;
        private System.Windows.Forms.RadioButton rdo_contenedor_b;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion_contenedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_fecha_ingreso_contenedor;
        private System.Windows.Forms.TextBox txt_peso_contenedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_legajo_cliente_persona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Button btn_agregar_cliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_apellido_cliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_legajo_cliente_empresa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_cliente_razon_social;
        private System.Windows.Forms.Button btn_mostrar_contenedores_cliente;
        private System.Windows.Forms.RadioButton rdo_personas;
        private System.Windows.Forms.RadioButton rdo_empresas;
        private System.Windows.Forms.MaskedTextBox txt_id_contenedor;
        private System.Windows.Forms.Button btn_modificar_contenedor;
        private System.Windows.Forms.Button btn_eliminar_contenedor;
        private System.Windows.Forms.Button btn_modificar_cliente;
        private System.Windows.Forms.Button btn_eliminar_cliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}


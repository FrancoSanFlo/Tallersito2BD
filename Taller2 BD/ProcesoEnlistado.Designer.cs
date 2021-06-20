
namespace Taller2_BD
{
    partial class ProcesoEnlistado
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
            this.button_listaNacional = new System.Windows.Forms.Button();
            this.button_listaExtranjero = new System.Windows.Forms.Button();
            this.button_listaGralClientes = new System.Windows.Forms.Button();
            this.button_listaProdAct = new System.Windows.Forms.Button();
            this.datosListas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel_haciaMenu = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.datosListas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_listaNacional
            // 
            this.button_listaNacional.Location = new System.Drawing.Point(45, 61);
            this.button_listaNacional.Name = "button_listaNacional";
            this.button_listaNacional.Size = new System.Drawing.Size(124, 42);
            this.button_listaNacional.TabIndex = 0;
            this.button_listaNacional.Text = "Listado clientes nacionales";
            this.button_listaNacional.UseVisualStyleBackColor = true;
            this.button_listaNacional.Click += new System.EventHandler(this.button_listaNacional_Click);
            // 
            // button_listaExtranjero
            // 
            this.button_listaExtranjero.Location = new System.Drawing.Point(45, 142);
            this.button_listaExtranjero.Name = "button_listaExtranjero";
            this.button_listaExtranjero.Size = new System.Drawing.Size(124, 42);
            this.button_listaExtranjero.TabIndex = 1;
            this.button_listaExtranjero.Text = "Listado clientes extranjeros";
            this.button_listaExtranjero.UseVisualStyleBackColor = true;
            this.button_listaExtranjero.Click += new System.EventHandler(this.button_listaExtranjero_Click);
            // 
            // button_listaGralClientes
            // 
            this.button_listaGralClientes.Location = new System.Drawing.Point(45, 219);
            this.button_listaGralClientes.Name = "button_listaGralClientes";
            this.button_listaGralClientes.Size = new System.Drawing.Size(124, 42);
            this.button_listaGralClientes.TabIndex = 2;
            this.button_listaGralClientes.Text = "Listado general de clientes";
            this.button_listaGralClientes.UseVisualStyleBackColor = true;
            this.button_listaGralClientes.Click += new System.EventHandler(this.button_listaGralClientes_Click);
            // 
            // button_listaProdAct
            // 
            this.button_listaProdAct.Location = new System.Drawing.Point(45, 300);
            this.button_listaProdAct.Name = "button_listaProdAct";
            this.button_listaProdAct.Size = new System.Drawing.Size(124, 42);
            this.button_listaProdAct.TabIndex = 3;
            this.button_listaProdAct.Text = "Listado de productos actuales";
            this.button_listaProdAct.UseVisualStyleBackColor = true;
            this.button_listaProdAct.Click += new System.EventHandler(this.button_listaProdAct_Click);
            // 
            // datosListas
            // 
            this.datosListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosListas.Location = new System.Drawing.Point(39, 49);
            this.datosListas.Name = "datosListas";
            this.datosListas.Size = new System.Drawing.Size(395, 281);
            this.datosListas.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datosListas);
            this.groupBox1.Location = new System.Drawing.Point(318, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 378);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visualizador de listas";
            // 
            // linkLabel_haciaMenu
            // 
            this.linkLabel_haciaMenu.AutoSize = true;
            this.linkLabel_haciaMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_haciaMenu.Location = new System.Drawing.Point(626, 407);
            this.linkLabel_haciaMenu.Name = "linkLabel_haciaMenu";
            this.linkLabel_haciaMenu.Size = new System.Drawing.Size(151, 16);
            this.linkLabel_haciaMenu.TabIndex = 6;
            this.linkLabel_haciaMenu.TabStop = true;
            this.linkLabel_haciaMenu.Text = "Volver al menú principal";
            this.linkLabel_haciaMenu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_haciaMenu_LinkClicked);
            // 
            // ProcesoEnlistado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel_haciaMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_listaProdAct);
            this.Controls.Add(this.button_listaGralClientes);
            this.Controls.Add(this.button_listaExtranjero);
            this.Controls.Add(this.button_listaNacional);
            this.Name = "ProcesoEnlistado";
            this.Text = "ProcesoEnlistado";
            ((System.ComponentModel.ISupportInitialize)(this.datosListas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_listaNacional;
        private System.Windows.Forms.Button button_listaExtranjero;
        private System.Windows.Forms.Button button_listaGralClientes;
        private System.Windows.Forms.Button button_listaProdAct;
        private System.Windows.Forms.DataGridView datosListas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel_haciaMenu;
    }
}

namespace Taller2_BD
{
    partial class EliminarCliente
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
            this.button_clienteNacional = new System.Windows.Forms.Button();
            this.button_clienteExtranjero = new System.Windows.Forms.Button();
            this.comboBox_clienteExtranjero = new System.Windows.Forms.ComboBox();
            this.comboBox_clienteNacional = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_clienteNacional
            // 
            this.button_clienteNacional.Location = new System.Drawing.Point(151, 241);
            this.button_clienteNacional.Name = "button_clienteNacional";
            this.button_clienteNacional.Size = new System.Drawing.Size(116, 49);
            this.button_clienteNacional.TabIndex = 0;
            this.button_clienteNacional.Text = "Eliminar cliente nacional";
            this.button_clienteNacional.UseVisualStyleBackColor = true;
            this.button_clienteNacional.Click += new System.EventHandler(this.button_clienteNacional_Click);
            // 
            // button_clienteExtranjero
            // 
            this.button_clienteExtranjero.Location = new System.Drawing.Point(463, 241);
            this.button_clienteExtranjero.Name = "button_clienteExtranjero";
            this.button_clienteExtranjero.Size = new System.Drawing.Size(116, 49);
            this.button_clienteExtranjero.TabIndex = 1;
            this.button_clienteExtranjero.Text = "Eliminar cliente extranjero";
            this.button_clienteExtranjero.UseVisualStyleBackColor = true;
            this.button_clienteExtranjero.Click += new System.EventHandler(this.button_clienteExtranjero_Click);
            // 
            // comboBox_clienteExtranjero
            // 
            this.comboBox_clienteExtranjero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clienteExtranjero.FormattingEnabled = true;
            this.comboBox_clienteExtranjero.Location = new System.Drawing.Point(463, 72);
            this.comboBox_clienteExtranjero.Name = "comboBox_clienteExtranjero";
            this.comboBox_clienteExtranjero.Size = new System.Drawing.Size(163, 21);
            this.comboBox_clienteExtranjero.TabIndex = 3;
            this.comboBox_clienteExtranjero.DropDown += new System.EventHandler(this.comboBox_clienteExtranjero_DropDown);
            // 
            // comboBox_clienteNacional
            // 
            this.comboBox_clienteNacional.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_clienteNacional.FormattingEnabled = true;
            this.comboBox_clienteNacional.Location = new System.Drawing.Point(141, 72);
            this.comboBox_clienteNacional.Name = "comboBox_clienteNacional";
            this.comboBox_clienteNacional.Size = new System.Drawing.Size(163, 21);
            this.comboBox_clienteNacional.TabIndex = 4;
            this.comboBox_clienteNacional.DropDown += new System.EventHandler(this.comboBox_clienteNacional_DropDown);
            // 
            // EliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_clienteNacional);
            this.Controls.Add(this.comboBox_clienteExtranjero);
            this.Controls.Add(this.button_clienteExtranjero);
            this.Controls.Add(this.button_clienteNacional);
            this.Name = "EliminarCliente";
            this.Text = "Eliminación de cliente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_clienteNacional;
        private System.Windows.Forms.Button button_clienteExtranjero;
        private System.Windows.Forms.ComboBox comboBox_clienteExtranjero;
        private System.Windows.Forms.ComboBox comboBox_clienteNacional;
    }
}
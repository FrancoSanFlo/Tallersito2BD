
namespace Taller2_BD
{
    partial class EliminarProducto
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
            this.comboBox_eliminar = new System.Windows.Forms.ComboBox();
            this.button_eliminarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_eliminar
            // 
            this.comboBox_eliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_eliminar.FormattingEnabled = true;
            this.comboBox_eliminar.Location = new System.Drawing.Point(65, 192);
            this.comboBox_eliminar.Name = "comboBox_eliminar";
            this.comboBox_eliminar.Size = new System.Drawing.Size(166, 21);
            this.comboBox_eliminar.TabIndex = 0;
            this.comboBox_eliminar.DropDown += new System.EventHandler(this.comboBox_eliminar_DropDown);
            this.comboBox_eliminar.SelectedIndexChanged += new System.EventHandler(this.comboBox_eliminar_SelectedIndexChanged);
            // 
            // button_eliminarProducto
            // 
            this.button_eliminarProducto.Location = new System.Drawing.Point(65, 231);
            this.button_eliminarProducto.Name = "button_eliminarProducto";
            this.button_eliminarProducto.Size = new System.Drawing.Size(103, 32);
            this.button_eliminarProducto.TabIndex = 1;
            this.button_eliminarProducto.Text = "Eliminar producto";
            this.button_eliminarProducto.UseVisualStyleBackColor = true;
            this.button_eliminarProducto.Click += new System.EventHandler(this.button_eliminarProducto_Click);
            // 
            // EliminarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_eliminarProducto);
            this.Controls.Add(this.comboBox_eliminar);
            this.Name = "EliminarProducto";
            this.Text = "Eliminar Producto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_eliminar;
        private System.Windows.Forms.Button button_eliminarProducto;
    }
}
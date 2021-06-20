
namespace Taller2_BD
{
    partial class LogInAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_mostrarPass = new System.Windows.Forms.CheckBox();
            this.button_entrarAdmin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_idAdmin = new System.Windows.Forms.TextBox();
            this.textBox_passwordAdmin = new System.Windows.Forms.TextBox();
            this.button_volverMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.checkBox_mostrarPass);
            this.groupBox1.Controls.Add(this.button_entrarAdmin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_idAdmin);
            this.groupBox1.Controls.Add(this.textBox_passwordAdmin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(215, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Administrador";
            // 
            // checkBox_mostrarPass
            // 
            this.checkBox_mostrarPass.AutoSize = true;
            this.checkBox_mostrarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_mostrarPass.Location = new System.Drawing.Point(301, 161);
            this.checkBox_mostrarPass.Name = "checkBox_mostrarPass";
            this.checkBox_mostrarPass.Size = new System.Drawing.Size(64, 17);
            this.checkBox_mostrarPass.TabIndex = 5;
            this.checkBox_mostrarPass.Text = "Mostrar ";
            this.checkBox_mostrarPass.UseVisualStyleBackColor = true;
            this.checkBox_mostrarPass.CheckedChanged += new System.EventHandler(this.checkBox_mostrarPass_CheckedChanged);
            // 
            // button_entrarAdmin
            // 
            this.button_entrarAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrarAdmin.Location = new System.Drawing.Point(147, 208);
            this.button_entrarAdmin.Name = "button_entrarAdmin";
            this.button_entrarAdmin.Size = new System.Drawing.Size(84, 23);
            this.button_entrarAdmin.TabIndex = 4;
            this.button_entrarAdmin.Text = "Entrar";
            this.button_entrarAdmin.UseVisualStyleBackColor = true;
            this.button_entrarAdmin.Click += new System.EventHandler(this.button_entrarAdmin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Administrador";
            // 
            // textBox_idAdmin
            // 
            this.textBox_idAdmin.Location = new System.Drawing.Point(93, 71);
            this.textBox_idAdmin.Name = "textBox_idAdmin";
            this.textBox_idAdmin.Size = new System.Drawing.Size(184, 22);
            this.textBox_idAdmin.TabIndex = 1;
            // 
            // textBox_passwordAdmin
            // 
            this.textBox_passwordAdmin.Location = new System.Drawing.Point(93, 157);
            this.textBox_passwordAdmin.Name = "textBox_passwordAdmin";
            this.textBox_passwordAdmin.Size = new System.Drawing.Size(184, 22);
            this.textBox_passwordAdmin.TabIndex = 0;
            this.textBox_passwordAdmin.TextChanged += new System.EventHandler(this.textBox_passwordAdmin_TextChanged);
            // 
            // button_volverMenu
            // 
            this.button_volverMenu.Location = new System.Drawing.Point(658, 326);
            this.button_volverMenu.Name = "button_volverMenu";
            this.button_volverMenu.Size = new System.Drawing.Size(99, 33);
            this.button_volverMenu.TabIndex = 1;
            this.button_volverMenu.Text = "Volver";
            this.button_volverMenu.UseVisualStyleBackColor = true;
            this.button_volverMenu.Click += new System.EventHandler(this.button_volverMenu_Click);
            // 
            // LogInAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_volverMenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogInAdmin";
            this.Text = "LogInAdmin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_entrarAdmin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_idAdmin;
        private System.Windows.Forms.TextBox textBox_passwordAdmin;
        private System.Windows.Forms.CheckBox checkBox_mostrarPass;
        private System.Windows.Forms.Button button_volverMenu;
    }
}
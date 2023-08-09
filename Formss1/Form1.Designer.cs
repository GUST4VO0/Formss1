namespace Formss1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmessage = new System.Windows.Forms.Button();
            this.lbnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lbprontuario = new System.Windows.Forms.Label();
            this.txtprontuario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnmessage
            // 
            this.btnmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmessage.Location = new System.Drawing.Point(144, 187);
            this.btnmessage.Name = "btnmessage";
            this.btnmessage.Size = new System.Drawing.Size(285, 62);
            this.btnmessage.TabIndex = 0;
            this.btnmessage.Text = "Neymar";
            this.btnmessage.UseVisualStyleBackColor = false;
            this.btnmessage.Click += new System.EventHandler(this.btnmessage_Click);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(144, 92);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(33, 13);
            this.lbnome.TabIndex = 1;
            this.lbnome.Text = "nome";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(144, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(129, 20);
            this.txtnome.TabIndex = 3;
            // 
            // lbprontuario
            // 
            this.lbprontuario.AutoSize = true;
            this.lbprontuario.Location = new System.Drawing.Point(144, 136);
            this.lbprontuario.Name = "lbprontuario";
            this.lbprontuario.Size = new System.Drawing.Size(58, 13);
            this.lbprontuario.TabIndex = 4;
            this.lbprontuario.Text = "Prontuario ";
            // 
            // txtprontuario
            // 
            this.txtprontuario.Location = new System.Drawing.Point(144, 152);
            this.txtprontuario.Name = "txtprontuario";
            this.txtprontuario.Size = new System.Drawing.Size(129, 20);
            this.txtprontuario.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtprontuario);
            this.Controls.Add(this.lbprontuario);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.btnmessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmessage;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lbprontuario;
        private System.Windows.Forms.TextBox txtprontuario;
    }
}


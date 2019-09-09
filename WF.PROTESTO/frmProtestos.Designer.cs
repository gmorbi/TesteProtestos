namespace WF.PROTESTO
{
    partial class frmProtestos
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
            this.gridProtestos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNroProtesto = new System.Windows.Forms.TextBox();
            this.btnLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridProtestos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProtestos
            // 
            this.gridProtestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProtestos.Location = new System.Drawing.Point(12, 62);
            this.gridProtestos.Name = "gridProtestos";
            this.gridProtestos.Size = new System.Drawing.Size(776, 376);
            this.gridProtestos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Localizar Protesto:";
            // 
            // txtNroProtesto
            // 
            this.txtNroProtesto.Location = new System.Drawing.Point(144, 22);
            this.txtNroProtesto.Name = "txtNroProtesto";
            this.txtNroProtesto.Size = new System.Drawing.Size(105, 20);
            this.txtNroProtesto.TabIndex = 2;
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(255, 20);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(44, 23);
            this.btnLocalizar.TabIndex = 3;
            this.btnLocalizar.Text = "OK";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // frmProtestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLocalizar);
            this.Controls.Add(this.txtNroProtesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProtestos);
            this.Name = "frmProtestos";
            this.Text = "Protestos";
            this.Load += new System.EventHandler(this.frmProtestos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProtestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProtestos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNroProtesto;
        private System.Windows.Forms.Button btnLocalizar;
    }
}
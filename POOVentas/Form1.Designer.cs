namespace POOVentas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVentaCredito = new Button();
            btnVentaContado = new Button();
            btnVentaCortesia = new Button();
            SuspendLayout();
            // 
            // btnVentaCredito
            // 
            btnVentaCredito.Location = new Point(180, 153);
            btnVentaCredito.Name = "btnVentaCredito";
            btnVentaCredito.Size = new Size(149, 77);
            btnVentaCredito.TabIndex = 0;
            btnVentaCredito.Text = "VentaCrédito";
            btnVentaCredito.UseVisualStyleBackColor = true;
            btnVentaCredito.Click += btnVentaCredito_Click;
            // 
            // btnVentaContado
            // 
            btnVentaContado.Location = new Point(458, 152);
            btnVentaContado.Name = "btnVentaContado";
            btnVentaContado.Size = new Size(160, 78);
            btnVentaContado.TabIndex = 1;
            btnVentaContado.Text = "VentaContado";
            btnVentaContado.UseVisualStyleBackColor = true;
            btnVentaContado.Click += btnVentaContado_Click;
            // 
            // btnVentaCortesia
            // 
            btnVentaCortesia.Location = new Point(309, 294);
            btnVentaCortesia.Name = "btnVentaCortesia";
            btnVentaCortesia.Size = new Size(149, 77);
            btnVentaCortesia.TabIndex = 2;
            btnVentaCortesia.Text = "VentaCortesía";
            btnVentaCortesia.UseVisualStyleBackColor = true;
            btnVentaCortesia.Click += btnVentaCortesia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVentaCortesia);
            Controls.Add(btnVentaContado);
            Controls.Add(btnVentaCredito);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentaCredito;
        private Button btnVentaContado;
        private Button btnVentaCortesia;
    }
}

namespace TrabalhoT2POO {
	partial class frmTimer {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
			this.imgDespertador = new System.Windows.Forms.PictureBox();
			this.updwnMinutos = new System.Windows.Forms.NumericUpDown();
			this.updwnSegundos = new System.Windows.Forms.NumericUpDown();
			this.btnIniciarParar = new System.Windows.Forms.Button();
			this.lblMinutos = new System.Windows.Forms.Label();
			this.lblSegundos = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgDespertador)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updwnMinutos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.updwnSegundos)).BeginInit();
			this.SuspendLayout();
			// 
			// imgDespertador
			// 
			this.imgDespertador.Dock = System.Windows.Forms.DockStyle.Top;
			this.imgDespertador.Image = ((System.Drawing.Image)(resources.GetObject("imgDespertador.Image")));
			this.imgDespertador.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgDespertador.InitialImage")));
			this.imgDespertador.Location = new System.Drawing.Point(0, 0);
			this.imgDespertador.Name = "imgDespertador";
			this.imgDespertador.Size = new System.Drawing.Size(534, 183);
			this.imgDespertador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.imgDespertador.TabIndex = 0;
			this.imgDespertador.TabStop = false;
			// 
			// updwnMinutos
			// 
			this.updwnMinutos.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updwnMinutos.Location = new System.Drawing.Point(134, 255);
			this.updwnMinutos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.updwnMinutos.Name = "updwnMinutos";
			this.updwnMinutos.Size = new System.Drawing.Size(120, 86);
			this.updwnMinutos.TabIndex = 1;
			// 
			// updwnSegundos
			// 
			this.updwnSegundos.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.updwnSegundos.Location = new System.Drawing.Point(276, 255);
			this.updwnSegundos.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
			this.updwnSegundos.Name = "updwnSegundos";
			this.updwnSegundos.Size = new System.Drawing.Size(120, 86);
			this.updwnSegundos.TabIndex = 2;
			// 
			// btnIniciarParar
			// 
			this.btnIniciarParar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnIniciarParar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIniciarParar.Location = new System.Drawing.Point(0, 464);
			this.btnIniciarParar.Name = "btnIniciarParar";
			this.btnIniciarParar.Size = new System.Drawing.Size(534, 47);
			this.btnIniciarParar.TabIndex = 3;
			this.btnIniciarParar.Text = "Iniciar";
			this.btnIniciarParar.UseVisualStyleBackColor = true;
			this.btnIniciarParar.Click += new System.EventHandler(this.btnIniciarParar_Click);
			// 
			// lblMinutos
			// 
			this.lblMinutos.AutoSize = true;
			this.lblMinutos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMinutos.Location = new System.Drawing.Point(130, 232);
			this.lblMinutos.Name = "lblMinutos";
			this.lblMinutos.Size = new System.Drawing.Size(61, 20);
			this.lblMinutos.TabIndex = 4;
			this.lblMinutos.Text = "Minutos";
			// 
			// lblSegundos
			// 
			this.lblSegundos.AutoSize = true;
			this.lblSegundos.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSegundos.Location = new System.Drawing.Point(272, 232);
			this.lblSegundos.Name = "lblSegundos";
			this.lblSegundos.Size = new System.Drawing.Size(73, 20);
			this.lblSegundos.TabIndex = 5;
			this.lblSegundos.Text = "Segundos";
			// 
			// frmTimer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 511);
			this.Controls.Add(this.lblSegundos);
			this.Controls.Add(this.lblMinutos);
			this.Controls.Add(this.btnIniciarParar);
			this.Controls.Add(this.updwnSegundos);
			this.Controls.Add(this.updwnMinutos);
			this.Controls.Add(this.imgDespertador);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(550, 550);
			this.MinimumSize = new System.Drawing.Size(550, 550);
			this.Name = "frmTimer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Timer";
			this.Load += new System.EventHandler(this.frmDespertador_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgDespertador)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updwnMinutos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.updwnSegundos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imgDespertador;
		private System.Windows.Forms.NumericUpDown updwnMinutos;
		private System.Windows.Forms.NumericUpDown updwnSegundos;
		private System.Windows.Forms.Button btnIniciarParar;
		private System.Windows.Forms.Label lblMinutos;
		private System.Windows.Forms.Label lblSegundos;
	}
}


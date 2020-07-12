using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoT2POO {
	public partial class frmTimer : Form {
		private Timer timer = new Timer();

		public frmTimer() {
			InitializeComponent();
		}

		private void frmDespertador_Load(object sender, EventArgs e) {
			timer.DispararAlarme += new EventHandler(timer_DispararAlarme); 
		}

		private void setParar() {
			this.btnIniciarParar.Text = "Resetar";
			this.updwnMinutos.Enabled = false;
			this.updwnSegundos.Enabled = false;
		}
		private void setIniciar() {
			this.btnIniciarParar.Text = "Iniciar";
			this.updwnMinutos.Enabled = true;
			this.updwnSegundos.Enabled = true;
		}

		private void btnIniciarParar_Click(object sender, EventArgs e) {
			int minutos = Convert.ToInt32(this.updwnMinutos.Value);
			int segundos = Convert.ToInt32(this.updwnSegundos.Value);

			if (this.btnIniciarParar.Text.Equals("Iniciar")) {
				setParar();
				timer.startTimer(minutos, segundos);
			}
			else {
				setIniciar();
				timer.stopTimer();
			}	
		}

		private void timer_DispararAlarme(object sender, EventArgs e) {
			MessageBox.Show("O alarme disparou!", "Timer", MessageBoxButtons.OK);
		}
	}
}

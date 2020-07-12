using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TrabalhoT2POO {
	class Timer {
		private int tempo;
		private Thread counter;

		public event EventHandler DispararAlarme;

		public void startTimer(int minutos, int segundos) {
			this.tempo = minutos * 60 + segundos;
			this.counter = new Thread(ThreadCounter);
			counter.Start();
		}

		public void stopTimer() {
			counter.Abort();
		}

		private int getSecondsSinceEpoch() {
			TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1); //Epoch
			return (int)t.TotalSeconds;
		}

		private void ThreadCounter() {
			int tempoInicio = getSecondsSinceEpoch();
			int tempoAtual;
			int count = 0;

			while (count < this.tempo) {
				tempoAtual = getSecondsSinceEpoch();
				if (tempoAtual - tempoInicio >= 1) {
					tempoInicio = tempoAtual;
					count += 1;
				}
			}

			if (DispararAlarme != null) {
				DispararAlarme(this, EventArgs.Empty);
			}
		}
	}
}

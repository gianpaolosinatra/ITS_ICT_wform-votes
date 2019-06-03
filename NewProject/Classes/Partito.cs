using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Classes {
    class Partito {

        private string _nome;

        public string Nome {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _voti;

        public int Voti {
            get { return _voti; }
            set { _voti = value; }
        }

        private string _candidato;

        public string Candidato {
            get { return _candidato; }
            set { _candidato = value; }
        }
        
        public Partito(string nome, int voti, string candidato) {
            _nome = nome;
            _voti = voti;
            _candidato = candidato;
        }

        public Partito(string nome, int voti) {
            Nome = nome;
            Voti = voti;
        }
    }
}

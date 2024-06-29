using System;
using Models;

namespace Models{
    public class Reserva {
        
        public Reserva(List<Pessoa> hospede, Suite suite, int diasReservados){
            Hospede = hospede;
            InfoSuite = suite;
            DiasReservados = diasReservados;
        }

        private List<Pessoa> _hospede;

        public List<Pessoa> Hospede{
            get => _hospede;

            set => _hospede = value;
        }

        private Suite _infosuite;

        public Suite InfoSuite{
            get => _infosuite;
            
            set => _infosuite = value;
        }

        private int _diasReservados;

        public int DiasReservados{
            get => _diasReservados;

            set{
                if(value == 0 || value < 0){
                    throw new ArgumentException("O valor de dias reservados tem que ser maior que 0.");
                }

                _diasReservados = value;
            }
        }

        public void CadastrarHospedes (List<Pessoa> hospedes){

          if(InfoSuite.Capacidade >= Hospede.Count && Hospede.Count <= InfoSuite.Capacidade){
            Hospede = hospedes;
          }
          else{
            throw new ArgumentException("A quantidade de hospedes excede a capacidade da suite.");
          }
        }
        public int ObterQuantidadeHospedes()
        {
            return _hospede.Count;
        }

         public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * InfoSuite.ValorDiaria; 

            if(DiasReservados >= 10){
               valor = valor * 0.90m;
            }

            return valor;
        }
        
    }
}
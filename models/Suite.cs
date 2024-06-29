using System;
namespace Models{
    public class Suite{
        public Suite(string tipo, int capacidade, decimal valorDiaria){
            Tipo = tipo;
            Capacidade = capacidade;
            ValorDiaria = valorDiaria;
        }
        private string _tipo;

        public string Tipo { 
            get => _tipo;

            set{
                if(string.IsNullOrEmpty(value)){
                    throw new ArgumentException("O tipo da suite não pode ser nulo.");
                }
                _tipo = value;
            }
        }


        private int _capacidade;

        public int Capacidade {
            get => _capacidade;

            set{
                if(value < 0 || value == 0){
                    throw new ArgumentException("A capacidade tem que ser maior que 0.");
                }
                _capacidade = value;
            }
        }

        private decimal _valorDiaria;

        public decimal ValorDiaria {
            get => _valorDiaria;

            set{
                if(value < 0 || value == 0){
                    throw new ArgumentException("O valor da diaria tem que ser maior que 0");
                }
                _valorDiaria = value;
            }
        }
    }
}
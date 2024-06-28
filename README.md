
# Desafio da DIO, feito pelo [Leonardo](https://github.com/leonardo-buta).

## Descrição do Desafio

O desafio consiste em criar uma aplicação de hospedaria em C#, utilizando três classes principais: `Pessoa`, `Suite` e `Reserva`.

### Classe Pessoa

A classe `Pessoa` representa uma pessoa que pode fazer uma reserva na hospedaria.

```
   public class Pessoa
    {
        public Pessoa(string nome, string sobreNome){
            Nome = nome;
            SobreNome = sobreNome;
        } 

        private string _nome;
        private string _sobreNome;

        public string Nome {
            get => _nome;

            set{
                if(string.IsNullOrEmpty(value)){
                    throw new ArgumentException("O nome não pode estar vazio.");
                }
            
                _nome = value;
            }
        }

        public string SobreNome {
            get => _sobreNome;

            set{
                if(string.IsNullOrEmpty(value)){
                    throw new ArgumentException("O Sobrenome não pode estar vazio.");
                }
                _sobreNome = value;
            }
        }

        public string NomeCompleto => $"{ Nome } { SobreNome }".ToUpper();
    }
}
```

### Classe Suite

A classe `Suite` representa os detalhes da suíte que pode ser escolhida na reserva da hospedaria.
```
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
```
### Classe Reserva

A classe `Reserva` é responsável por gerenciar as reservas feitas na hospedaria, relacionando uma pessoa à suite que ela reservou.
```
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
```

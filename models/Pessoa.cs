using System;

namespace Models{
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
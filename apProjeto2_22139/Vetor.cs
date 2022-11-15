using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Júlia Enriquetto de Brito - 22139
namespace apProjeto2_22139
{
    class Vetor
    {
        //Atributos
        private int tamanho;
        private string[] vetorFrase; 
        private string[] vetorDica;
       
        public Vetor() //Construtor
        {
            tamanho = 30;
            vetorFrase = new string[] {
             "Papai Noel",
             "Buzz Lightyear",
             "Capitão América",
             "Pantera Negra",
             "Tony Stark",
             "Darth Vader",
             "Han Solo",
             "Grogu",
             "Mickey Mouse",
             "Wanda Maximoff",
             "Loki",
             "Daphne Bridgerton",
             "Rory Gilmore",
             "Dr Watson",
             "Blair Waldorf",
             "Jo March",
             "Eleven",
             "Max Mayfield",
             "Rapunzel",
             "Olaf",
             "Harry Potter",
             "Batman",
             "Katniss Everdeen",
             "Thanos",
             "Luke Skywalker",
             "Leia Organa",
             "Evelyn Hugo",
             "Hermione Granger",
             "Percy Jackson",
             "Groot"
            };
            vetorDica = new string[] {
                "Dá presentes às crianças comportadas na noite de véspera de Natal", 
                "Ao infinito e além", 
                "O primeiro vingador",
                "Wakanda forever",
                "Homem de ferro",
                "Quando Jedi, Anakin Skywalker",
                "Piloto da Millennium Falcon",
                "Baby Yoda", 
                "Ratinho da Disney", 
                "Feiticeira Escarlate",
                "Irmão do Thor, Deus da trapaça", 
                "Diamante da 1a temporada de Bridgerton",
                "Estudante de Chilton", 
                "Ex militar e amigo de Sherlock Holmes", 
                "XOXO, gossip girl", 
                "Woman, they have minds and souls as well as just hearts. And they´ve got ambition and talent as well as just beauty. And I'm sick of people saying love is all a woman is fit for!",
                "Friends don't lie",
                "MadMax ruiva", 
                "Princesa que foi presa em uma torre", 
                "Boneco de neve que gosta de abraços quentinhos", 
                "Bruxo e único sobrevivente da Maldição da Morte", 
                "Homem morcego",
                "Voluntária para ir no lugar da irmã Primrose para os Jogos Vorazes", 
                "Supervilão roxo dos vingadores", 
                "O Jedi mais forte e responsável pela queda do Império Galáctico",
                "Princesa de Alderaan, membro do Senado Imperial e General da Aliança pela restauração da República", 
                "Lendária estrela de Hollywood, sempre esteve sob os holofotes seja atuando, protagonizando algum escândalo ou aparecendo com um novo marido...pela sétima vez",
                "A bruxa mais inteligente de Hogwarts",
                "Semideus grego filho de Poseidon",
                "Eu sou o groot."
            };
        }

        //Getters e setters 
        public void setTamanho(int t) { tamanho = t; }
        public int getTamanho() { return tamanho; }

        public void setVetorFrase(string[] vetorFrase) { this.vetorFrase = vetorFrase; }
        public string[] getVetorFrase() { return vetorFrase; }

        public void setVetorDica(string[] vetorDica) { this.vetorDica = vetorDica; }
        public string[] getVetorDica() { return vetorDica; }
    }
}

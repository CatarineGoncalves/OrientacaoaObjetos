namespace OrientaçãoObjetos.Models {
    public class AlunoModel {
        public string nome { get; set; } //public pode puxar em todas as CS criadas no mesmo VStudio

        public string curso { get; set; } //Get e Set seria para Alterar/Cadastrar ou Visualizar

        public int rg { get; set; }  //set altera

        public int idade { get; set; }

        public int nota {get; set;}

    }
}
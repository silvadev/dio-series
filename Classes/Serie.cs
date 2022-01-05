namespace DIO.Series
{
    public class Serie: EntidadeBase
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string str;
            str = $"Gênero: {this.Genero}{Environment.NewLine}";
            str += $"Título: {this.Titulo}{Environment.NewLine}";
            str += $"Descrição: {this.Descricao}{Environment.NewLine}";
            str += $"Ano de Início: {this.Ano}{Environment.NewLine}";
            str += $"Excluído: {this.Excluido}";
            return str;
        }

        public string retornaTitulo() => this.Titulo;

        public int retornaId() => this.Id;

        public Genero retornaGenero() => this.Genero;

        public string retornaDescricao() => this.Descricao;

        public int retornaAno() => this.Ano;

        public bool retornaExcluido() => this.Excluido;

        public void Excluir() => this.Excluido = true;
    }
}
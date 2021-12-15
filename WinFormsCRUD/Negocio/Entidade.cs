namespace WinFormsCRUD.Negocio
{
    public class Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"{Id} | {Nome} | {Cidade} | {Uf} | {Telefone}";
        }

    }
}

using System;
class Cliente
{

    private string nome { get; set; }
    private string email { get; set; }
    private string endereco { get; set; }
    private long cpf { get; set; }

    public Cliente(string nome, string email, string endereco, long cpf)
    {

        this.nome = nome;
        this.email = email;
        this.endereco = endereco;
        this.cpf = cpf;
        Console.WriteLine("O cliente {0} foi registrado, cpf {1}", nome, cpf);
    }

}

class Veiculo
{

    private string placa { get; set; }
    private string tipo { get; set; }
    private string marca { get; set; }
    private string modelo { get; set; }
    private int anomodelo { get; set; }
    private int anofabricacao { get; set; }

    public Veiculo(string placa, string tipo, string marca, string modelo, int anomodelo, int anofabricacao)
    {

        this.placa = placa;
        this.tipo = tipo;
        this.marca = marca;
        this.modelo = modelo;
        this.anomodelo = anomodelo;
        this.anofabricacao = anofabricacao;
        Console.WriteLine("O veiculo {0} foi registrado, placa {1}", modelo, placa);
    }

}

class Servico
{

    private string nomeserv { get; set; }
    private string descricao { get; set; }
    private float valor { get; set; }

    public Servico(string nomeserv, string descricao, float valor)
    {

        this.nomeserv = nomeserv;
        this.descricao = descricao;
        this.valor = valor;
        Console.WriteLine("O serviço {0} foi registrado, valor {1}", nomeserv, valor);
    }

}

class Cadastro
{
    private string nome { get; set; }
    private string email { get; set; }
    private string endereco { get; set; }
    private long cpf { get; set; }
    private string placa { get; set; }
    private string tipo { get; set; }
    private string marca { get; set; }
    private string modelo { get; set; }
    private int anomodelo { get; set; }
    private int anofabricacao { get; set; }
    private string nomeserv { get; set; }
    private string descricao { get; set; }
    private float valor { get; set; }

    public Cadastro()
    {

    }
    static public void CadCliente(string nome, string email, string endereco, long cpf)
    {

        new Cliente(nome, email, endereco, cpf);
    }

    static public void CadVeiculo(string placa, string tipo, string marca, string modelo, int anomodelo, int anofabricacao)
    {

        new Veiculo(placa, tipo, marca, modelo, anomodelo, anofabricacao);
    }

    static public void CadServico(string nomeserv, string descricao, float valor)
    {

        new Servico(nomeserv, descricao, valor);
    }
}



class Teste
{
    public static void Testando()
    {
        Cliente mauro = new Cliente("nome do cliente", "zeca", "avenida", 12354564);
    }
}



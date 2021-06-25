using System;
class Cliente
{

    private string nome { get; set; }
    private string email { get; set; }
    private string endereco { get; set; }
    private long cpf { get; set; }

    public Cliente(string nome, string email, string endereco, long cpf) // contrutor
    {

        this.nome = nome;
        this.email = email;
        this.endereco = endereco;
        this.cpf = cpf;
        Console.WriteLine("O cliente {0} foi registrado, cpf {1}", nome, cpf);
    }
    public string GetNome() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return nome;
    }
    public long GetCpf() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return cpf;
    }
    public string GetEmail() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return email;
    }
    public string GetEndereco() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return endereco;
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
    public string GetPlaca() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return placa;
    }
    public string GetTipo() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return tipo;
    }
    public string GetMarca() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return marca;
    }
    public string GetModelo() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return modelo;
    }
    public int GetAnomodelo() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return anomodelo;
    }
    public int GetAnofabricacao() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return anofabricacao;
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
    public string GetNomeserv() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return nomeserv;
    }
    public string GetDescricao() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return descricao;
    }
    public float GetValor() // Esse método pretente retornar somente o valor de nome do objeto criado, a fim de elaborar uma tabela com todos os atributos de um objeto.
    {
        return valor;
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
    static public Cliente CadCliente(string nome, string email, string endereco, long cpf)
    {

        Cliente Cdt = new Cliente(nome, email, endereco, cpf);
        return Cdt;
    }

    static public Veiculo CadVeiculo(string placa, string tipo, string marca, string modelo, int anomodelo, int anofabricacao)
    {

        Veiculo Veic = new Veiculo(placa, tipo, marca, modelo, anomodelo, anofabricacao);
        return Veic;
    }

    static public Servico CadServico(string nomeserv, string descricao, float valor)
    {

        Servico Serv = new Servico(nomeserv, descricao, valor);
        return Serv;
    }
}



class Teste
{
    public static void Testando()
    {
        Cliente mauro = new Cliente("nome do cliente", "zeca", "avenida", 12354564);
    }
}



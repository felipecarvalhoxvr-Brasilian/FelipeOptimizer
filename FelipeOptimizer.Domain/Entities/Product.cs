namespace FelipeOptimizer.Domain.Entities;

public class Product
{
    public Guid Id { get; private set; }

    public string Nome { get; private set; } = string.Empty;

    public string Descricao { get; private set; } = string.Empty;

    public decimal Preco { get; private set; }

    public int Estoque { get; private set; }

    public DateTime DataCadastro { get; private set; }

    // Necessário para o Entity Framework
    private Product()
    {
    }

    public Product(string nome, string descricao, decimal preco, int estoque)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome é obrigatório.");

        if (string.IsNullOrWhiteSpace(descricao))
            throw new ArgumentException("A descrição é obrigatória.");

        if (preco <= 0)
            throw new ArgumentException("O preço deve ser maior que zero.");

        if (estoque < 0)
            throw new ArgumentException("O estoque não pode ser negativo.");

        Id = Guid.NewGuid();
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        DataCadastro = DateTime.UtcNow;
    }

    public void AtualizarNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O nome é obrigatório.");

        Nome = nome;
    }

    public void AtualizarDescricao(string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
            throw new ArgumentException("A descrição é obrigatória.");

        Descricao = descricao;
    }

    public void AtualizarPreco(decimal preco)
    {
        if (preco <= 0)
            throw new ArgumentException("O preço deve ser maior que zero.");

        Preco = preco;
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade deve ser maior que zero.");

        Estoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
            throw new ArgumentException("A quantidade deve ser maior que zero.");

        if (quantidade > Estoque)
            throw new InvalidOperationException("Estoque insuficiente.");

        Estoque -= quantidade;
    }
}
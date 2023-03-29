namespace exemplo_construtor;
class Produto
{
   //para evitar erros crashar 
   //passar objeto mas so o preco vai falar que nao foi informado o nome mas aparece o preco
   public Produto(){
      this.Nome = "XTPO";
      this.Preco = 1;
   }
   public Produto(double preco){
      this.Nome = "Não Informado";
      this.Preco = preco;
   }
   private string? Nome {get;set;}
   private double Preco {get;set;}
   public void MostraDados(){
            Console.WriteLine ("Nome: " + this.Nome );
            Console.WriteLine ("Preço: " + this.Preco );
   }
   public void AlteraPreco(double preco){
    if(preco >= 0){
    this.Preco = preco;
   }else{
    Console.WriteLine("VALOR INVÁLIDO!");
   }
   }
   public void AlteraNome(string nome){
    this.Nome = nome;
   }
}
//passar objeto mas so o preco vai falar que nao foi informado o nome mas aparece o preco
//se colocar nome e parametro ele vai pegar o nome e o parametro ele vai fazer a conta para tirar o desconto
using System;
using System.Collections.Generic;

namespace ObjetoArgumento.classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }

        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto _produto){
            carrinho.Add(_produto);
        }        

            public void MostrarProdutos(){
                if(carrinho != null){
                    foreach ( var item in carrinho){
                        Console.WriteLine($"-----    {item.Codigo}, {item.Nome}, {item.Preco}");
                        Console.ResetColor();
                    }
                    MostrarTotal();
                }
            }
        public void RemoverProduto(Produto _produto){
            carrinho.Remove(_produto);
        }

        public void MostrarTotal(){
            ValorTotal = 0;
            if(carrinho != null){
                foreach ( var item in carrinho){
                    ValorTotal = ValorTotal + item.Preco;
            }
            Console.WriteLine($"-----    o toltal do carrinho é : R${ValorTotal}");
            }
            else{
                Console.WriteLine("-----    seu carrinho está vazio");
            }
        }
        public void AlterarItem(int _codigo, Produto _novoProduto){
            carrinho.Find(produto => produto.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(Produto => Produto.Codigo == _codigo).Preco = _novoProduto.Preco;
        }
    }
}
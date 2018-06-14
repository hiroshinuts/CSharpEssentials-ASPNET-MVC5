using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Rotas.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Categoria { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Preco { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        public List<Produto> TodosProdutos()
        {
            var produtos = new List<Produto>
            {
               new Produto
                {
                    ProdutoId = 110,
                    Categoria = "Informatica",
                    Nome = "Notebook Acer",
                    Descricao = "E5-571-54MC com Intel Core i5, 4GB de RAM, Windows 8.1",
                    Preco = 1690.00M,
                    Data = new DateTime(2015,7,15)
                },
                new Produto
                {
                    ProdutoId = 120,
                    Categoria = "Informatica",
                    Nome = "Notebook Positivo Premium",
                    Descricao = "TV S6050 LCD 14’’ Processador Intel Core i3, Windows 8, HD 500GB",
                    Preco = 1290.00M,
                    Data = new DateTime(2015,7,1)
                },
                new Produto
                {
                    ProdutoId = 130,
                    Categoria = "Informatica",
                    Nome = "iPad Mini 3",
                    Descricao = "16 GB Wi Fi Dourado MGYE2BR/A Apple",
                    Preco = 1990.00M,
                    Data = new DateTime(2015,7,10)
                },
                new Produto
                {
                    ProdutoId = 210,
                    Categoria = "Eletrodomesticos",
                    Nome = "Ar Condicionado Consul",
                    Descricao = "Portátil 12.000 Btus Frio C1A12AB, 220 V, Branco",
                    Preco = 990.00M,
                    Data = new DateTime(2015,7,11)
                },
                new Produto
                {
                    ProdutoId = 220,
                    Categoria = "Eletrodomesticos",
                    Nome = "Micro-Ondas LG",
                    Descricao = "30 L, EasyClean MH7093R Prata, com Grill, Branco",
                    Preco = 430.00M,
                    Data = new DateTime(2015,7,6)
                },
                new Produto
                {
                    ProdutoId = 230,
                    Categoria = "Eletrodomesticos",
                    Nome = "Refrigerador Electrolux",
                    Descricao = "DF42 382 Litros 2 Portas Frost Free, 220 V , Branco",
                    Preco = 1250.00M,
                    Data = new DateTime(2015,7,7)
                },
                new Produto
                {
                    ProdutoId = 310,
                    Categoria = "Telefonia",
                    Nome = "Samsung Galasy S6",
                    Descricao = "SM-G920I Single Chip, Branco, Processador quad-core",
                    Preco = 2120.00M,
                    Data = new DateTime(2015,7,3)
                },
                new Produto
                {
                    ProdutoId = 320,
                    Categoria = "Telefonia",
                    Nome = "Motorola Moto G",
                    Descricao = "Preto, TV Digital, Dual Chip, Processador Quad Core 1.2GHz, Tela 5",
                    Preco = 870.00M,
                    Data = new DateTime(2015,7,16)
                },
                new Produto
                {
                    ProdutoId = 410,
                    Categoria = "Esporte",
                    Nome = "Bicicleta Colli Bike ",
                    Descricao = "Aro 26 18 Marchas Suspensão Dianteira CBX 750 Preta + Garrafa Térmica",
                    Preco = 380.00M,
                    Data = new DateTime(2015,7,9)
                },
                new Produto
                {
                    ProdutoId = 420,
                    Categoria = "Esporte",
                    Nome = "Tênis Feminino Fila",
                    Descricao = "Kenya Racer, 2.0 W Vermelho/Limão, 38, Palminha durável",
                    Preco = 125.00M,
                    Data = new DateTime(2015,7,10)
                },
                new Produto
                {
                    ProdutoId = 430,
                    Categoria = "Esporte",
                    Nome = "Tênis Diadora",
                    Descricao = "Ghost III Azul e Verde Masculino, número 44",
                    Preco = 65.00M,
                    Data = new DateTime(2015,7,11)
                },
                new Produto
                {
                    ProdutoId = 510,
                    Categoria = "Beleza",
                    Nome = "Barbeador Philips",
                    Descricao = "Aquatouch AT751 Recarregável, 110 V",
                    Preco = 219.00M,
                    Data = new DateTime(2015,7,1)
                },
                new Produto
                {
                    ProdutoId = 520,
                    Categoria = "Beleza",
                    Nome = "Secador Candence",
                    Descricao = "Secador de Cabelo - SEC400 - 1400w, Cabo, 220 V",
                    Preco = 205.00M,
                    Data = new DateTime(2015,7,3)
                },
            };
            return produtos;
        }
    }
}
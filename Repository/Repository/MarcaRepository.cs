﻿using Model;
using Repository.DataBase;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class MarcaRepository : IMarcaRepository
    {
        SistemaContext context;

        public MarcaRepository()
        {
            context = new SistemaContext();
        }

        public bool Apagar(int id)
        {
            Marca marca = (from x in context.Marcas where x.Id == id select x).FirstOrDefault();
            if (marca == null)
            {
                return false;
            }

            marca.RegistroAtivo = false;

            return context.SaveChanges() == 1;
        }

        public bool Atualizar(Marca marca)
        {
            Marca marcaOriginal = (from x in context.Marcas where x.Id == marca.Id select x).FirstOrDefault();
            if (marcaOriginal == null)
            {
                return false;
            }

            marcaOriginal.Id = marca.Id;
            marcaOriginal.Nome = marca.Nome;
            context.SaveChanges();
            return true;
        }

        public List<Marca> ObterTodos()
        {
            return context.Marcas.ToList();
        }

        public List<Marca> ObterTodos(string busca)
        {
            return context.Marcas.
                Where(x=> x.RegistroAtivo && x.Nome.Contains(busca))
                .ToList();
        }

        public int Inserir(Marca marca)
        {
            marca.DataCriacao = DateTime.Now;
            marca.RegistroAtivo = true;
            context.Marcas.Add(marca);
            context.SaveChanges();
            return marca.Id;
        }

        public Marca ObterPeloId(int id)
        {
            return (from x in context.Marcas where x.Id == id select x).FirstOrDefault();
        }

    }
}

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
    public class ClienteRepository : IClienteRepository
    {
        SistemaContext context;

        public ClienteRepository()
        {
            context = new SistemaContext();
        }

        public bool Apagar(int id)
        {
            Cliente cliente = (from x in context.Clientes where x.Id == id select x).FirstOrDefault();
            if (cliente == null)
            {
                return false;
            }

            cliente.RegistroAtivo = false;
            context.SaveChanges();
            return true;
        }

        public bool Atualizar(Cliente cliente)
        {
            Cliente clienteOriginal = (from x in context.Clientes where x.Id == cliente.Id select x).FirstOrDefault();
            if (clienteOriginal == null)
            {
                return false;
            }

            clienteOriginal.Id = cliente.Id;
            clienteOriginal.Nome = cliente.Nome;
            context.SaveChanges();
            return true;
        }

        public int Inserir(Cliente cliente)
        {
            cliente.DataCriacao = DateTime.Now;
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return cliente.Id;
        }

        public Cliente ObterPeloId(int id)
        {
            return (from x in context.Clientes where x.Id == id select x).FirstOrDefault();
        }

        public List<Cliente> ObterTodos(string busca)
        {
            throw new NotImplementedException();
        }
    }
}

using Model;
using Repository.DataBase;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class AdministradorRepository : IAdministradorRepository
    {
        SistemaContext context;

        public AdministradorRepository()
        {
            context = new SistemaContext();
        }

        public bool Apagar(int id)
        {
            Administrador administrador = (from x in context.Administradores where x.Id == id select x).FirstOrDefault();
            if (administrador == null)
            {
                return false;
            }

            administrador.RegistroAtivo = false;

            return context.SaveChanges() == 1;
        }

        public bool Atualizar(Administrador administrador)
        {
            Administrador administradorOriginal = (from x in context.Administradores where x.Id == administrador.Id select x).FirstOrDefault();
            if(administradorOriginal == null)
            {
                return false;
            }
            administradorOriginal.Id = administrador.Id;
            administradorOriginal.Usuario = administrador.Usuario;
            administradorOriginal.Senha = administrador.Senha;

            context.SaveChanges();
            return true;
        }

        public int Inserir(Administrador administrador)
        {
            administrador.DataCriacao = DateTime.Now;
            administrador.RegistroAtivo = true;
            context.Administradores.Add(administrador);
            context.SaveChanges();
            return administrador.Id;
        }
    }
}

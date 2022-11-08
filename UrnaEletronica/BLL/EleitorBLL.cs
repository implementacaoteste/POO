﻿using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class EleitorBLL
    {
        public void Inserir(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O nome do eleitor deve ter mais de 2 caracteres.");

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inseir(_eleitor);
        }
        public void Excluir(Eleitor _eleitor)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Excluir(_eleitor);
        }
        public void Alterar(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O nome do eleitor deve ter mais de 2 caracteres.");

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Alterar(_eleitor);
        }
        public DataTable Buscar(string _titulo)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.Buscar(_titulo);
        }
    }
}

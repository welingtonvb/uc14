﻿using ChapterBET6.Models;

namespace ChapterBET6.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IUsuarioRepository
    {
        List<Usuario> Listar();

        Usuario BuscarPorId(int id);

        void Cadastrar(Usuario usuario);
        void Atualizar(int id, Usuario usuario);
        
        void Deletar(int id);

        Usuario Login(string email, string senha);
    }
}

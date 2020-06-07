﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Turma
{
    public class NodoAluno
    {
        public Aluno item;           // contém os dados do aluno armazenado no nodo da árvore.
        public NodoAluno direita;    // referência ao nodo armazenado, na árvore, à direita do aluno em questão.
        public NodoAluno esquerda;   // referência ao nodo armazenado, na árvore, à esquerda do aluno em questão.

        public NodoAluno(Aluno registro)
        {
            item = registro;
            direita = null;
            esquerda = null;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Turma
{
    public class Aluno
    {
        private int numMatricula; // número de matrícula do aluno.
        private String nome;      // nome do aluno.
        private double nota;      // nota do aluno.

        /// Construtor da classe.
        /// Esse construtor cria um novo objeto da classe Aluno atribuindo a esse objeto os seguintes valores:
        /// - numMatricula recebe o valor que foi passado através do parâmetro matricula.
        /// - nome recebe o valor que foi passado através do parâmetro nome.
        /// - nota recebe o valor que foi passado através do parâmetro nota.
        public Aluno(int matricula, String nome, double nota)
        {
            this.numMatricula = matricula;
            this.nome = nome;
            this.nota = nota;
        }

        public void imprimir()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Número de matrícula: " + numMatricula);
            Console.WriteLine("Nota: " + nota);
        }

      
        public int getNumMatricula()
        {
            return numMatricula;
        }

      
        public void setNumMatricula(int numMatricula)
        {
            this.numMatricula = numMatricula;
        }

       
        public String getNome()
        {
            return nome;
        }

       
        public void setNome(String nome)
        {
            this.nome = nome;
        }

       
        public double getNota()
        {
            return nota;
        }

       
        public void setNota(double nota)
        {
            this.nota = nota;
        }
    }
}


using D12_AccessModifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D12_AccessModifiers
{
    internal class Person // base class
    {
        #region Attributes
        internal string message01; // interno é interno a namespace
        private string message02; // aquilo que é privado é so para ser usado naquela classe, nao se pode usar noutras classes
        public string message03;  // public deve ser usado sempre nos controtors e na classe que implementa o interface e nos membros implementados do interface
        #endregion


        #region properties
        internal string Name { get; set; }
        internal string Address { get; set; }
        #endregion

        #region methods
        internal void WriteResult01()
        {
            message01 = string.Empty;
            message02 = string.Empty;

            int a;// privada ao metedo de declaracao, as variaveis dos metodos sao sempre e so usado no metodo

        }
        internal void WriteResult02()
        {

        }

        internal void Create()
        {

        }
        #endregion


    }

    internal class Student : Person  // derived class
    {
    internal DateTime DataNascimento { get; set; }
    internal string Curso { get; set; }

        internal void InscreverCurso()
        {
        }
    }
 
    internal class Trainer : Person  // derived class
    {
        public bool CCP { get; set; }

        public void DarAula()
        {

        }
    }

    internal class Test
    {
        internal void CheckStatus()
        {
            Person person01 = new Person(); // nao se deve instanciar a base classe deve se uysar as suas heranças


        }

        internal void CheckInheritance()
        {
            Person person02 = new Person(); // nao se deve instanciar a base classe deve se uysar as suas heranças
            Student student01 = new Student();
            Trainer trainer01 = new Trainer();
        }
    }

}

namespace D12_AccessModifiers_V2
{
    internal class Customer
    {
        internal void ReadData()
        {
            Person person01 = new Person();
            person01.Name= string.Empty;
        }
    }
}
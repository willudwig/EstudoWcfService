using System;
using System.Collections.Generic;

namespace EstudoWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public bool SaveCliente(string nome, string cpf)
        {
            try
            {
                bool result = new Cliente { Id = 104, Nome = nome, CPF = cpf }.Salvar();
                return result;
            }
            catch 
            {
                return false; 
            }
        }

        public List<Cliente> GetAllCliente()
        {
            var listaClientes = new List<Cliente>();

            listaClientes.Add( new Cliente() { Id = 100, Nome = "Fulano", CPF = "05165502918" } );
            listaClientes.Add( new Cliente() { Id = 101, Nome = "Beltrano", CPF = "05165502922" } );
            listaClientes.Add( new Cliente() { Id = 102, Nome = "Ciclano", CPF = "05165502930" } );

            return listaClientes;
        }

        public Cliente GetData(int value)
        {
            var cliente = new Cliente()
            {
                Id= 100,
                Nome = "Fulano",
                CPF = "05165502918"
            };

            return cliente;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
       
    }
}

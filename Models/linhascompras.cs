﻿using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace gestaoDeClientesArtigosTheStore.Models
{
    public class linhascompras
    {
        public string numeroCedulaProfissional { get; set; }

        public string nomeAplido { get; set; }

        public string contactoMovel { get; set; }

        public int numeroIdEspecialidade { get; set; }



        public linhascompras(string numeroCedulaProfissional, string nomeAplido, string contactoMovel, int numeroIdEspecialidade)
        //ctor cria construtor prop cria propriedade
        {

            this.numeroCedulaProfissional = numeroCedulaProfissional;
            this.nomeAplido = nomeAplido;
            this.contactoMovel = contactoMovel;
            this.numeroIdEspecialidade = numeroIdEspecialidade;


        }
        public linhascompras()
        {

        }

    }  
}
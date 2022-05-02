using System;

namespace gestaoDeClientesArtigosTheStore.Handlers
{
    public class especialidadeMedicaHander
    {


        Models.artigo especialidadeMedicaModel = new Models.artigo();
        public (int, Models.artigo, string mensagemDeErro) ValidarEspecialidadeMedicaInsert(string description)
        {

            if (description.Length == 0) { return (1, null, "Falta  descricao"); }
            else
            {
                especialidadeMedicaModel.description = description.ToUpper();
                return (0, especialidadeMedicaModel, null);

            }

        }
        public (int, Models.artigo , string mensagemDeErro) ValidarEspecialidadeMedicaUpdate(string numeroId, string description)
        {

            if (numeroId.Length == 0 || numeroId == "0") { return (1, null, "Select one item to update"); }
            else
            {
                if (description.Length == 0) { return (2, null, "Falta  descricao"); }
                else
                {
                    especialidadeMedicaModel.numeroId = Convert.ToInt32(numeroId);
                    especialidadeMedicaModel.description = description.ToUpper();
                    return (0, especialidadeMedicaModel, null);


                }
            }


        }

        public (int, Models.artigo, string mensagemDeErro) ValidarEspecialidadeMedicaDelete(string numeroId )
        {

            if (numeroId.Length == 0 || numeroId == "0") { return (1, null, "Select one item to delete"); }
            else
            {
                especialidadeMedicaModel.numeroId = Convert.ToInt32(numeroId);
                return (0, especialidadeMedicaModel, null);


            }
        }
    }
}

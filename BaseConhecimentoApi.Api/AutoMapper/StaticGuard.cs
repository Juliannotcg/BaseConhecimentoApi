using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseConhecimentoApi.Api.AutoMapper
{
    public static class StaticGuard
    {
        /// <summary>
        ///     Guarda que verifica que objeto não é nulo
        /// </summary>
        /// <param name="object"></param>
        /// <param name="nome"></param>
        public static void IsNotNull(object @object, string nome = "")
        {
            if (@object == null)
                throw new ArgumentNullException(nome);
        }
    }
}

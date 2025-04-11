using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    public static class Constantes
    {
        public const string URI_TOKEN = "https://api-seguridad.sunat.gob.pe/v1/clientesextranet/ce58910f-7676-4431-8019-63b3a07f640d/oauth2/token/";
        public const string URI_CONSULTA = "https://api.sunat.gob.pe/v1/contribuyente/contribuyentes/10161684916/validarcomprobante";
        public const string CONTENT_TYPE = "application/x-www-form-urlencoded";
        public const string GRANT_TYPE = "client_credentials";
        public const string SCOPE = "https://api.sunat.gob.pe/v1/contribuyente/contribuyentes";
        public const string CLIENT_ID = "ce58910f-7676-4431-8019-63b3a07f640d";
        public const string CLIENT_SECRET = "w1ZtI/KoQEc7yIgkEW2zSA==";
    }
}

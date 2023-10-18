using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregador
{
    public class PrinterModel2006: IBasicFunctions,IIntermediateFunctions,IAdvancedFunctions,ICancel
    {
        public void Cancel()
        {
            Console.WriteLine("Printer Model 2006: Operación Cancelada ");
        }

        public void Photocopy()
        {
            Console.WriteLine("Printer Model 2006: Copia Realizada");
        }

        public void Print()
        {
            Console.WriteLine("Printer Model 2006: Impresión Éxitosa");
        }

        public void Scan()
        {
            Console.WriteLine("Printer Model 2006: Documento Escaneado");
        }
        public void SentEmail() {

            Console.WriteLine("Printer Model 2006: Envio Exitoso");
        }

        public void SentFax() {
            Console.WriteLine("Printer Model 2006: Fax Enviado Exitosamente");

        }
    }
}

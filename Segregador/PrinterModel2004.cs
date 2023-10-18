using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregador
{
    public class PrinterModel2004:IBasicFunctions,IIntermediateFunctions,ICancel
    {
        public void Cancel()
        {
            Console.WriteLine("Printer Model 2004: Operación Cancelada");
        }

        public void Photocopy()
        {
            Console.WriteLine("Printer Model 2004: Copia Realizada");
        }

        public void Print()
        {
            Console.WriteLine("Printer Model 2004: Impresión Éxitosa");
        }

        public void Scan() {
            Console.WriteLine("Printer Model 2004: Documento Escaneado");
        }
    }
}

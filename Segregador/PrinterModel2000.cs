using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segregador
{
    public class PrinterModel2000 : IBasicFunctions,ICancel
    {
        public void Cancel()
        {
            Console.WriteLine("Printer Model 2000: Operación Cancelada");
        }

        public void Photocopy()
        {
            Console.WriteLine("Printer Model 2000: Copia Realizada");
        }

        public void Print()
        {
            Console.WriteLine("Printer Model 2000: Impresión Éxitosa");
        }
    }
}

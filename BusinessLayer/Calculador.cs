using System;


namespace BusinessLayer
{
    public class Calculador
    {
        public  double Calcular(double Monto,int tipPrestamo,int cantMeses)
        {
            double MontoTotal = 0;

            switch (tipPrestamo)
            {
                case (int)EnumPrestamo.PERSONAL:
                    MontoTotal = (((Monto * 22) / 100) + Monto) / cantMeses;
                    break;

                case (int)EnumPrestamo.AUTOMOVIL:
                    MontoTotal = ((((Monto * 12) / 100) + Monto) / cantMeses);
                    break;

                case (int)EnumPrestamo.HIPOTECARIO:
                    MontoTotal = ((((Monto * 8) / 100)  + Monto) / cantMeses);
                    break;
            }

            return MontoTotal;
        }
    }
}

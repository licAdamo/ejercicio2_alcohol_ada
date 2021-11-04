using System;
namespace alcohol.Domain.Interface
{
    public class bebida : Icalculoalcohol
    {
        private int _cantidad;
        private int _liquido;
        private int _peso;
        private double alcoholingerido;
        private double sangre;
        private double etanol = 0.789;
        private double resultsangre;
        private double volumenSangre;
        private double sangredealcohol;
        private double medidaAlcohol;
        private string _bebida;
        public void calcularalcoholconsumido(string bebida, int cantidad)
        {
            _cantidad = cantidad;
            _bebida = bebida.ToLower();
            switch (bebida)
            {
                    case "cerveza":
                    _liquido = 330;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 5;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "vino": 
                    _liquido = 100;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 12;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "cava": 
                    _liquido = 100;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 12;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "vermu":
                    _liquido = 70;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 17;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "licor":
                    _liquido = 45;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 23;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "brandy":
                    _liquido = 45;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 38;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
                    case "combinado":
                    _liquido = 50;
                    _cantidad = _cantidad * _liquido;
                    medidaAlcohol = 38;
                    alcoholingerido = medidaAlcohol / 100 * _cantidad;
                    break;
        }
        }

        public void calcularlorestante(int peso)
        {
           _peso = peso;
            sangre = 0.15 * alcoholingerido;
            resultsangre = etanol * sangre;
            volumenSangre = 0.8 * _peso;
            sangredealcohol = resultsangre / volumenSangre;
        
        }
        
        public string respuesta()
        {
                if (sangredealcohol >  0.8)
                {
                    return $" Su nivel de alcohol en la sangre es  de: {sangredealcohol}  Como podemos ver es superior al limite que nos ponen en el reglamento, no es apto para manejar";
                }
                    return $" Su nivel de alcohol en la sangre es  de: {sangredealcohol}  Como podemos ver no es superior al limite que nos ponen en el reglamento,  es apto para manejar, que tenga un buen viaje";
               
        }
    }

    }



    

       
        
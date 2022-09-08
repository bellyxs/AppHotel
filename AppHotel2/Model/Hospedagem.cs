using System;
using System.Collections.Generic;
using System.Text;

namespace AppHotel2.Model
{
    public class Hospedagem
    {
        int qnt_adultos;
        Quarto quarto_escolhido;


        public Quarto QuartoEscolhido
        {
            get => quarto_escolhido;
            set
            {
                if (value == null)
                    throw new Exception("Selecione o seu quarto:");

                quarto_escolhido = value;
            }
        }



        public int QntAdultos
        {
            get => qnt_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Selecione a quantidade de adultos no quarto:");

                qnt_adultos = value;
            }
        }



        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        public double ValorTotal
        {
            get => ((QntAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }

    }
}

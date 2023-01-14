using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal interface iUredjaji
    {
        double Cena { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        double Procesor { get; set; }
        double Ram { get; set; }
        string OperativniSistem { get; set; }
        string NacinUnosa { get; set; }

    }
    interface iDesktop
    {
        int Napajanje { get; set; }
        string Kuciste { get; set; }
    }
    interface iLaptop
    {
        int Baterija { get; set; }
        double Tezina { get; set; }
    }

    interface iTablet
    {
        string Platforma { get; set; }
        double Kamera { get; set; }
        string TipKonekcije { get; set; }
    }
    interface iGamingKonzole
    {
        string TipKonzole { get; set; }
        int BrojDzojstika { get; set; }
    }

    interface iSingleBoard
    {
        string FormFactor { get; set; }
    }
    interface iMobilniTelefon
    {
        int BrojKartica { get; set; }
        int BrojKamera { get; set; }
    }
    interface iPrinter
    {
        double KolicinaBoje { get; set; }
        int BrzinaStampe { get; set; }
    }
}

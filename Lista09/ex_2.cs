using System;

public struct Data
{
    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Ano { get; set; }

    public Data(int dia, int mes, int ano)
    {
        Dia = dia;
        Mes = mes;
        Ano = ano;
    }

    public bool DataValida()
    {
        if (Ano < 1) return false;
        if (Mes < 1 || Mes > 12) return false;

        int[] diasPorMes = { 31, DateTime.IsLeapYear(Ano) ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (Dia < 1 || Dia > diasPorMes[Mes - 1]) return false;

        return true;
    }
}

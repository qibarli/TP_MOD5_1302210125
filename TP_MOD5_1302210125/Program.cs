// See https://aka.ms/new-console-template for more information
using TP_MOD5_130221205;

namespace TP_MOD5_KPL_1302210125
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            HelloGenerics HG = new HelloGenerics();
            HG.SapaUSer<String>("BAR");
        }
    }
}

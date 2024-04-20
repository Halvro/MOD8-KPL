using System;
namespace modul8_1302220098
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UIConfig uiConfig = new UIConfig();
            int jumlahTF, biayaTF;
            string metode, confirm;
            if (uiConfig.bankConfig.lang == "en")
            {
                Console.WriteLine("Please insert the amount of money to transfer: ");
                jumlahTF = Convert.ToInt32(Console.ReadLine());
                if (jumlahTF <= uiConfig.bankConfig.transfer.treshold)
                {
                    biayaTF = uiConfig.bankConfig.transfer.low_fee;
                }
                else
                {
                    biayaTF = uiConfig.bankConfig.transfer.high_fee;
                }
                Console.WriteLine($"Transfer fee = {biayaTF}");
                Console.WriteLine($"Total amount = {jumlahTF + biayaTF}");
                Console.WriteLine("Select transfer method: ");
                for (int i = 0; i < uiConfig.bankConfig.method.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {uiConfig.bankConfig.method[i]}");
                }
            }
        }
    }
}

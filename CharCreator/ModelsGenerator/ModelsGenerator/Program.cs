using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ModelsGenerator
{
    class Program
    {
        const byte W_MAX = 8;
        const byte G_MAX = 1;
        const byte S_MAX = 3;
        const string DECORATE_FILE = "DECORATE.txt";
        const string MODELDEF_FILE = "MODELDEF.txt";

        static public void GenerateDECORATE()
        {
            string sState = "I";
            byte byW = 0;
            byte byG = 0;
            byte byS = 0;
            bool bStop = false;
            string[] asFrames = new string[2];

            Console.WriteLine("Generating DECORATE...\n\n");

            StreamWriter sw = new StreamWriter(DECORATE_FILE);

            // Species
            Console.WriteLine("\tSpawn:");
            for (int iSpecies = S_MAX - 1; iSpecies > 0; iSpecies--)
                Console.WriteLine("\t\tI001 A 0 A_JumpIfInventory(\"pony_species\", " + iSpecies + ", \"" + sState + iSpecies + "\")");
            Console.WriteLine("\t\tGoto " + sState + "0");

            // Genders
            for (int iSpecies = 0; iSpecies < S_MAX; iSpecies++)
            {
                Console.WriteLine("\t" + sState + iSpecies + ":");
                for (int iGenders = 0; iGenders < G_MAX; iGenders++)
                {
                    if (!(iGenders >= G_MAX - 1))
                        Console.WriteLine("\t\tI001 A 0 A_JumpIfInventory(\"pony_gender\", " + ((G_MAX - 1) - iGenders) + ", \"" + sState + iSpecies + "_" + ((G_MAX - 1) - iGenders) + "\")");
                    else
                        Console.WriteLine("\t\tGoto " + sState + iSpecies + "_0");
                }
            }

            // Weapons
            for (int iSpecies = 0; iSpecies < S_MAX; iSpecies++)
            {
                for (int iGenders = 0; iGenders < G_MAX; iGenders++)
                {
                    Console.WriteLine("\t" + sState + iSpecies + "_" + iGenders + ":");
                    for (int iWeapons = 0; iWeapons < W_MAX; iWeapons++)
                    {
                        if (!(iWeapons >= W_MAX - 1))
                            Console.WriteLine("\t\tI001 A 0 A_JumpIfInventory(\"pony_weapon\", " + ((W_MAX - 1) - iWeapons) + ", \"" + sState + iSpecies + "_" + iGenders + "_" + ((W_MAX - 1) - iWeapons) + "\")");
                        else
                            Console.WriteLine("\t\tGoto " + sState + iSpecies + "_" + iGenders + "_0");
                    }
                }
            }

            for (int iNbModels = 1; bStop == false; iNbModels += 2)
            {
                asFrames[0] = sState + iNbModels.ToString("000");
                asFrames[1] = sState + (iNbModels + 1).ToString("000");
                if (byS != S_MAX)
                    Console.WriteLine("\t" + sState + byS + "_" + byG + "_" + byW + ":\n\t\t" + asFrames[0] + " AABBCCDDEEFFGGHHIIJKKLLMMNNOOPPQQRRSSTUUVVWWXXYYZZ 1\n\t\t" + asFrames[1] + " AABBCCDDEEDDCCBBAA 1\n\t\t" + asFrames[0] + " ZZYYXXWWVVUUTSSRRQQPPOONNMMLLKKJIIHHGGFFEEDDCCBBAA 1\n\t\tGoto Spawn");
                else
                    bStop = true;

                if (byS == S_MAX)
                {
                    byS = 0;
                    byG++;
                    if (byG == G_MAX)
                    {
                        byG = 0;
                        byW++;
                        if (byW == W_MAX)
                        {
                            byW = 0;
                            byS++;
                        }
                    }
                }
                else
                    byS++;
            }
            //sw.Flush();
            //sw.Close();
            Console.ReadKey();
        }

        /*
        static public void GenerateMODELDEF()
        {
            string sState = "I";
            byte byFM = 0;
            byte byBM = 0;
            byte byT = 0;
            byte byS = 0;
            char[] acChar = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
            bool bStop = false;
            byte byCharSelecteur = 0;
            string[] asFrames = new string[2];
            string[] asModels = { "manefront", "maneback", "tail", "unicorn", "pegasus", "alicorn" };

            Console.WriteLine("Generating MODELDEF...\n\n");

            StreamWriter sw = new StreamWriter(MODELDEF_FILE);
            for (int iNbModels = 1; bStop == false; iNbModels += 2)
            {
                if (iNbModels >= 1000)
                {
                    byCharSelecteur++;
                    iNbModels = 1;
                    asFrames[0] = acChar[byCharSelecteur] + iNbModels.ToString("000");
                    asFrames[1] = acChar[byCharSelecteur] + (iNbModels + 1).ToString("000");
                }
                else if (iNbModels >= 999)
                {
                    asFrames[0] = acChar[byCharSelecteur] + iNbModels.ToString("000");
                    byCharSelecteur++;
                    iNbModels = 0;
                    asFrames[1] = acChar[byCharSelecteur] + (iNbModels + 1).ToString("000");
                }
                else
                {
                    asFrames[0] = acChar[byCharSelecteur] + iNbModels.ToString("000");
                    asFrames[1] = acChar[byCharSelecteur] + (iNbModels + 1).ToString("000");
                }
                if (byFM != FM_MAX)
                {
                    Console.WriteLine("Model PonyEditor" +
                        "\n{" +
                        "\tPath \"Models\"" +
                        "");
                }
                else
                    bStop = true;

                if (byS == S_MAX)
                {
                    byS = 0;
                    byT++;
                    if (byT == T_MAX)
                    {
                        if (byFM != 6 && byFM != 11)
                        {
                            byT = 0;
                            byBM++;
                            if (byBM == BM_MAX)
                            {
                                byBM = 0;
                                byFM++;
                            }
                        }
                        else
                        {
                            byT = 0;
                            byFM++;
                        }
                    }
                }
                else
                    byS++;
            }
            sw.Flush();
            sw.Close();
        }
        */

        static void Main(string[] args)
        {
            GenerateDECORATE();
            //GenerateMODELDEF();
            //Console.ReadKey();
        }
    }
}

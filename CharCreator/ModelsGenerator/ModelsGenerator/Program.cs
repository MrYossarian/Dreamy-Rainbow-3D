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
        const byte B_MAX = 8;
        const byte FM_MAX = 12;
        const byte BM_MAX = 10;
        const byte T_MAX = 12;
        const byte S_MAX = 3;
        const string DECORATE_FILE = "DECORATE.txt";
        const string MODELDEF_FILE = "MODELDEF.txt";

        static public void GenerateDECORATE()
        {
            string sState = "I";
            byte byB = 0;
            byte byFM = 0;
            byte byBM = 0;
            byte byT = 0;
            byte byS = 0;
            string[] asSpr = { "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV", "IW", "IX", "IY", "IZ", "JA", "JB", "JC", "JD", "JE", "JF", "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "JU", "JV", "JW", "JX", "JY", "JZ", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "KY", "KZ", "LA", "LB", "LC", "LD", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LU", "LV", "LW", "LX", "LY", "LZ", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "NZ", "OA", "OB", "OC", "OD", "OE", "OF", "OG", "OH", "OI", "OJ", "OK", "OL", "OM", "ON", "OO", "OP", "OQ", "OR", "OS", "OT", "OU", "OV", "OW", "OX", "OY", "OZ", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "QA", "QB", "QC", "QD", "QE", "QF", "QG", "QH", "QI", "QJ", "QK", "QL", "QM", "QN", "QO", "QP", "QQ", "QR", "QS", "QT", "QU", "QV", "QW", "QX", "QY", "QZ", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "UA", "UB", "UC", "UD", "UE", "UF", "UG", "UH", "UI", "UJ", "UK", "UL", "UM", "UN", "UO", "UP", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "VA", "VB", "VC", "VD", "VE", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN", "VO", "VP", "VQ", "VR", "VS", "VT", "VU", "VV", "VW", "VX", "VY", "VZ", "WA", "WB", "WC", "WD", "WE", "WF", "WG", "WH", "WI", "WJ", "WK", "WL", "WM", "WN", "WO", "WP", "WQ", "WR", "WS", "WT", "WU", "WV", "WW", "WX", "WY", "WZ", "XA", "XB", "XC", "XD", "XE", "XF", "XG", "XH", "XI", "XJ", "XK", "XL", "XM", "XN", "XO", "XP", "XQ", "XR", "XS", "XT", "XU", "XV", "XW", "XX", "XY", "XZ", "YA", "YB", "YC", "YD", "YE", "YF", "YG", "YH", "YI", "YJ", "YK", "YL", "YM", "YN", "YO", "YP", "YQ", "YR", "YS", "YT", "YU", "YV", "YW", "YX", "YY", "YZ", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT", "ZU", "ZV", "ZW", "ZX", "ZY", "ZZ", "0A", "0B", "0C", "0D", "0E", "0F", "0G", "0H", "0I", "0J", "0K", "0L", "0M", "0N", "0O", "0P", "0Q", "0R", "0S", "0T", "0U", "0V", "0W", "0X", "0Y", "0Z", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q", "2R", "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3X", "3Y", "3Z", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L" };
            bool bStop = false;
            int iCharSelecteur = 0;
            string[] asFrames = new string[2];

            Console.WriteLine("Generating DECORATE...\n\n");

            StreamWriter sw = new StreamWriter(DECORATE_FILE);

            // Bodies
            sw.WriteLine("\tSpawn:");
            for (int iBodies = B_MAX - 1; iBodies > 0; iBodies--)
                sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"body\", " + iBodies + ", \"" + sState + iBodies + "\")");
            sw.WriteLine("\t\tGoto " + sState + "0");

            // Front manes
            for (int iBodies = 0; iBodies < B_MAX; iBodies++)
            {
                sw.WriteLine("\t" + sState + iBodies + ":");
                for (int iFrontManes = 0; iFrontManes < FM_MAX; iFrontManes++)
                {
                    if (!(iFrontManes >= FM_MAX - 1))
                        sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"frontmane\", " + ((FM_MAX - 1) - iFrontManes) + ", \"" + sState + iBodies + "_" + ((FM_MAX - 1) - iFrontManes) + "\")");
                    else
                        sw.WriteLine("\t\tGoto " + sState + iBodies + "_0");
                }
            }

            // Back manes
            for (int iBodies = 0; iBodies < B_MAX; iBodies++)
            {
                for (int iFrontManes = 0; iFrontManes < FM_MAX; iFrontManes++)
                {
                    sw.WriteLine("\t" + sState + iBodies + "_" + iFrontManes + ":");
                    if (iFrontManes != 6 && iFrontManes != 11)
                    {
                        for (int iBackManes = 0; iBackManes < BM_MAX; iBackManes++)
                        {
                            if (!(iBackManes >= BM_MAX - 1))
                                sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"backmane\", " + ((BM_MAX - 1) - iBackManes) + ", \"" + sState + iBodies + "_" + iFrontManes + "_" + ((BM_MAX - 1) - iBackManes) + "\")");
                            else
                                sw.WriteLine("\t\tGoto " + sState + iBodies + "_" + iFrontManes + "_0");
                        }
                    }
                    else
                    {
                        // Tails
                        for (int iTails = 0; iTails < T_MAX; iTails++)
                        {
                            if (!(iTails >= T_MAX - 1))
                                sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"tail\", " + ((T_MAX - 1) - iTails) + ", \"" + sState + iBodies + "_" + iFrontManes + "_0_" + ((T_MAX - 1) - iTails) + "\")");
                            else
                                sw.WriteLine("\t\tGoto " + sState + iBodies + "_" + iFrontManes + "_0_0");
                        }
                    }
                }
            }

            // Tails
            for (int iBodies = 0; iBodies < B_MAX; iBodies++)
            {
                for (int iFrontManes = 0; iFrontManes < FM_MAX; iFrontManes++)
                {
                    if (iFrontManes != 6 && iFrontManes != 11)
                    {
                        for (int iBackManes = 0; iBackManes < BM_MAX; iBackManes++)
                        {
                            sw.WriteLine("\t" + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + ":");
                            for (int iTails = 0; iTails < T_MAX; iTails++)
                            {
                                if (!(iTails >= T_MAX - 1))
                                    sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"tail\", " + ((T_MAX - 1) - iTails) + ", \"" + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + "_" + ((T_MAX - 1) - iTails) + "\")");
                                else
                                    sw.WriteLine("\t\tGoto " + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + "_0");
                            }
                        }
                    }
                }
            }

            // Species
            for (int iBodies = 0; iBodies < B_MAX; iBodies++)
            {
                for (int iFrontManes = 0; iFrontManes < FM_MAX; iFrontManes++)
                {
                    if (iFrontManes != 6 && iFrontManes != 11)
                    {
                        for (int iBackManes = 0; iBackManes < BM_MAX; iBackManes++)
                        {
                            for (int iTails = 0; iTails < T_MAX; iTails++)
                            {
                                sw.WriteLine("\t" + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + "_" + iTails + ":");
                                for (int iSpecies = 0; iSpecies < S_MAX + 1; iSpecies++)
                                {
                                    if (!(iSpecies >= S_MAX))
                                        sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"ponytype\", " + (S_MAX - iSpecies) + ", \"" + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + "_" + iTails + "_" + (S_MAX - iSpecies) + "\")");
                                    else
                                        sw.WriteLine("\t\tGoto " + sState + iBodies + "_" + iFrontManes + "_" + iBackManes + "_" + iTails + "_0");
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int iTails = 0; iTails < T_MAX; iTails++)
                        {
                            sw.WriteLine("\t" + sState + iBodies + "_" + iFrontManes + "_0_" + iTails + ":");
                            for (int iSpecies = 0; iSpecies < S_MAX + 1; iSpecies++)
                            {
                                if (!(iSpecies >= S_MAX))
                                    sw.WriteLine("\t\tAA01 A 0 A_JumpIfInventory(\"ponytype\", " + (S_MAX - iSpecies) + ", \"" + sState + iBodies + "_" + iFrontManes + "_0_" + iTails + "_" + (S_MAX - iSpecies) + "\")");
                                else
                                    sw.WriteLine("\t\tGoto " + sState + iBodies + "_" + iFrontManes + "_0_" + iTails + "_0");
                            }
                        }
                    }
                }
            }

            for (int iNbModels = 1; bStop == false; iNbModels += 2)
            {
                if (iNbModels >= 100)
                {
                    iCharSelecteur++;
                    iNbModels = 1;
                    asFrames[0] = asSpr[iCharSelecteur] + iNbModels.ToString("00");
                    asFrames[1] = asSpr[iCharSelecteur] + (iNbModels + 1).ToString("00");
                }
                else if (iNbModels >= 99)
                {
                    asFrames[0] = asSpr[iCharSelecteur] + iNbModels.ToString("00");
                    iCharSelecteur++;
                    iNbModels = 0;
                    asFrames[1] = asSpr[iCharSelecteur] + (iNbModels + 1).ToString("00");
                }
                else
                {
                    asFrames[0] = asSpr[iCharSelecteur] + iNbModels.ToString("00");
                    asFrames[1] = asSpr[iCharSelecteur] + (iNbModels + 1).ToString("00");
                }
                if (byB != B_MAX)
                    sw.WriteLine("\t" + sState + byB + "_" + byFM + "_" + byBM + "_" + byT + "_" + byS + ":\n\t\t" + asFrames[0] + " AABBCCDDEEFFGGHHIIJKKLLMMNNOOPPQQRRSSTUUVVWWXXYYZZ 1\n\t\t" + asFrames[1] + " AABBCCDDEEDDCCBBAA 1\n\t\t" + asFrames[0] + " ZZYYXXWWVVUUTSSRRQQPPOONNMMLLKKJIIHHGGFFEEDDCCBBAA 1\n\t\tGoto Spawn");
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
                                if(byFM == FM_MAX)
                                {
                                    byFM = 0;
                                    byB++;
                                }
                            }
                        }
                        else
                        {
                            byT = 0;
                            byFM++;
                            if(byFM == FM_MAX)
                            {
                                byFM = 0;
                                byB++;
                            }
                        }
                    }
                }
                else
                    byS++;
            }
            sw.Flush();
            sw.Close();
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

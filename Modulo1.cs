// Decompiled with JetBrains decompiler
// Type: RT.Modulo1
// Assembly: RT, Version=1.0.1.0, Culture=neutral, PublicKeyToken=null
// MVID: A0FA8656-1011-4FD7-A06B-C18464EA6325
// Assembly location: C:\Program Files (x86)\Ritmo Transfer\RT.exe
// XML documentation location: C:\Program Files (x86)\Ritmo Transfer\RT.xml

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;

class Modulo1
  {
    public const string CHR_CMD = "*";
    public const string CHR_END = "#OK!";
    public const string TRASFERIMENTO_TARATURE = "Dz";
    public const string TRASFERIMENTO_CONF_MACH = "At";
    public const string TRASFERIMENTO_NUM_SALD = "wK";
    public const string TRASFERIMENTO_REPORT_N = "Ph";
    public const string CANCELLA_REPORTS_IN_MEMORIA = "Ci";
    public const string CANCELLA_CONTATORE_SALDATURE = "Er";
    public const int COM_FREE = 0;
    public const int COM_OK = 1;
    public const int COM_BUSY = 2;
    public const int COM_TIMEOUT_ERROR = 10;
    public const int TIMEOUT_RIC_SER = 3;
    public const int LUNGHEZZA_TRASF_TARAT = 50;
    public const int LUNGHEZZA_TRASF_CONF = 25;
    public const int LUNGHEZZA_TRASF_NUM_SALD = 17;
    public const int LUNGHEZZA_TRASF_NUM_SALD_MULTIPLA_AND_MORE = 28;
    public const int LUNGHEZZA_TRASF_REPORT_N = 64;
    public const int LUNGHEZZA_TRASF_REPORT_N_MULTIPLA = 25;
    public const int LUNGHEZZA_TRASF_REPORT_N_ELEKTRA = 170;
    public const int LUNGHEZZA_TRASF_REPORT_N_ELEKTRA_LONG = 206;
    public const int LUNGHEZZA_TRASF_REPORT_N_ELEKTRA_LONG2 = 218;
    public const int LUNGHEZZA_TRASF_REPORT_N_GPS = 81;
    public const int LUNGHEZZA_TRASF_REPORT_N_CNC = 139;
    public const int LUNGHEZZA_TRASF_REPORT_N_ELEKTRA_125 = 60;
    public const int LUNGHEZZA_TRASF_REPORT_N_RAM824 = 92;
    public const int LUNGHEZZA_CANC_REPORT = 6;
    public const int LUNGHEZZA_CANC_REPORT_MULTIPLA = 13;
    public const int LUNGHEZZA_CANC_CONTATORE = 6;
    public const string STRINGA_IDENTIF_MULTIPLA = "#OK!000";
    public const string STRINGA_IDENTIF_ELEKTRA = "#OK!100";
    public const string STRINGA_IDENTIF_ELEKTRA_MAN = "#OK!200";
    public const string STRINGA_IDENTIF_RITMO = "RITMO.spa.";
    public const int NUM_REC_PAG = 22;
    public const int NUM_REC_PAG_ELEKTRA = 4;
    public const int NUM_REC_PAG_CNC_FA_SA = 4;
    public const int NUM_REC_PAG_EASYLIFE = 6;
    public const int Yi = 50;
    public const int Xi = 50;
    public const int Xf_landscape = 1125;
    public const int Yf_portrait = 1100;
    public const int Xf_portrait = 780;
    public const int DeltaX_1 = 50;
    public const int DeltaX_2 = 100;
    public const int DeltaX_3 = 150;
    public const int DeltaX_4 = 250;
    public const int DeltaX_5 = 350;
    public const int DeltaX_6 = 450;
    public const int DeltaX_7 = 600;
    public const int DeltaX_8 = 700;
    public const int DeltaX_9 = 800;
    public const int DeltaX_10 = 930;
    public const int Delta_ELK_X_1 = 50;
    public const int Delta_ELK_X_2 = 100;
    public const int Delta_ELK_X_3 = 150;
    public const int Delta_ELK_X_4 = 200;
    public const int Delta_ELK_X_5 = 250;
    public const int Delta_ELK_X_6 = 300;
    public const int Delta_ELK_X_7 = 300;
    public const int Delta_ELK_X_8 = 355;
    public const int Delta_ELK_X_9 = 410;
    public const int Delta_ELK_X_10 = 465;
    public const int Delta_ELK_X_11 = 520;
    public const int Delta_ELK_X_12 = 575;
    public const int Delta_ELK_X_13 = 630;
    public const int Delta_ELK_X_14 = 685;
    public const int Delta_ELK_X_15 = 750;
    public const int Delta_CNC_X_1 = 50;
    public const int Delta_CNC_X_2 = 100;
    public const int Delta_CNC_X_3 = 150;
    public const int Delta_CNC_X_4 = 200;
    public const int Delta_CNC_X_5 = 250;
    public const int Delta_CNC_X_6 = 300;
    public const int Delta_CNC_X_7 = 300;
    public const int Delta_CNC_X_8 = 355;
    public const int Delta_CNC_X_9 = 410;
    public const int Delta_CNC_X_10 = 465;
    public const int Delta_CNC_X_11 = 520;
    public const int Delta_CNC_X_12 = 575;
    public const int Delta_CNC_X_13 = 630;
    public const int Delta_CNC_X_14 = 685;
    public const int Delta_CNC_X_15 = 750;
    public const int Delta_ELTA_X_1 = 4;
    public const int Delta_ELTA_X_2 = 33;
    public const int Delta_ELTA_X_3 = 91;
    public const int Delta_ELTA_X_4 = 120;
    public const int Delta_ELTA_X_5 = 178;
    public const int Delta_ELTA_X_6 = 207;
    public const int Delta_ELTA_X_7 = 265;
    public const int Delta_ELTA_X_8 = 294;
    public const int Delta_ELTA_X_9 = 352;
    public const int Delta_ELTA_X_10 = 381;
    public const int Delta_ELTA_X_11 = 439;
    public const int Delta_ELTA_X_12 = 468;
    public const int Delta_ELTA_X_13 = 526;
    public const int Delta_ELTA_X_14 = 555;
    public const int Delta_ELTA_X_15 = 613;
    public const int Delta_ELTA_X_16 = 642;
    public const int Delta_ELTA_X_17 = 700;
    public const int Delta_ELT_X_1 = 5;
    public const int Delta_ELT_X_2 = 10;
    public const int Delta_ELT_X_3 = 70;
    public const int Delta_ELT_X_4 = 130;
    public const int Delta_ELT_X_5 = 190;
    public const int Delta_ELT_X_6 = 250;
    public const int Delta_ELT_X_7 = 310;
    public const int Delta_ELT_X_8 = 370;
    public const int Delta_ELT_X_9 = 430;
    public const int Delta_ELT_X_10 = 490;
    public const int Delta_ELT_X_11 = 550;
    public const int Delta_ELT_X_12 = 610;
    public const int Delta_ELT_X_13 = 670;
    public const int Delta_ELT_X_14 = 730;
    public const string FIELD1 = "ABSRWIND0001";
    public const string FIELD2 = "ANSDUEHWT";
    public const string FIELD3 = "DDDEHSYSI3323321";
    public const string FIELD3_1 = "DDDEHSYSI5674349";
    public const string FIELD4_0 = "DFHET3526345";
    public const string FIELD4_1 = "dsjgdas6da8nnd09a7";
    public const string NOME_NOSTRA_APPLICAZIONE = "Ritmo Transfer 2008";
    public const string NOME_CNC_FA_SA = "CNC-FA-SA Transfer";
    public const string CNC_VERSIONE = "v. 1.0.4 BETA 05";
    public const string PLAST_NOME_APPLICAZIONE = "PLAST MAX";
    public const string PLAST_VERSIONE = "v. 1.4";
    public const string PLAST_SOCIETA = "PLASTITALIA S.p.A.";
    public const string NOME_EASYLIFE_TRANSFER = "Easylife Transfer";
    public const string ELT_VERSIONE = "v. 2.0.2 BETA 01";
    public const string NOME_EASYLIFE_TRANSFER_AMERICA = "Easylife Transfer America";
    public const string ELTA_VERSIONE = "v. 1.1.4 BETA 02";
    public static byte[] vettore_tx = new byte[301];
    public static byte[] vettore_rx;
    public static byte[] vettore_calibr_e_config = new byte[76];
    public static long Matricola_Macchina_Collegata;
    public static string Versione_fw_macchina_collegata;
    public static bool Elektra_Reports_Long;
    public static short report_disponibili;
    public static bool upload_successful;
    public static string Crea_o_Apri;
    public static string Nome_database_scelto;
    public static string Nome_file_scelto;
    public static int Numero_record_database;
    public static byte[] OutArray = new byte[301];
    public static int Lunghezza_outstring;
    public static byte cks_trasm;
    public static byte cks_ricev;
    public static bool Nuovi_Dati_nel_Log_Nostro_Transfer;
    public static short porta;
    public static string velocita;
    public static string parita;
    public static string bit_dati;
    public static string bit_stop;
    public static string settaggio_com;
    public static string Dispositivo_Collegato;

    public static int Pagina;
    public static int Num_Pagine;
    public static int X;
    public static int Y;
    public static bool Splash_temporizzato;
    public static int Stato_Help;
    public static string Macchina_Scelta;
    public static bool Eseguire_Trova_e_Scarica_report;
    public static bool Converti_file;
    public static string badge_oper;
    public static string badge_scad_mese;
    public static string badge_scad_anno;
    public static string badge_nazione;
    public static string badge_organizzaz;
    public static string badge_skill;
    public static string badge_lingua;
    public static string giunto_case;
    public static string giunto_type;
    public static string giunto_energy_correction;
    public static string giunto_cycle_type;
    public static string giunto_control_type;
    public static string giunto_trademark;
    public static string giunto_cooling_time;
    public static string giunto_diameter;
    public static string giunto_commapos_typereg_K_Kprimo;
    public static string giunto_level_reg;
    public static string giunto_ohmic_value;
    public static string giunto_ohmic_min;
    public static string giunto_ohmic_max;
    public static string giunto_K_Kprimo;
    public static string giunto_En_Corr;
    public static string giunto_time_energy_stoptemp;
    public static string rintrac_supplier;
    public static string rintrac_pipe_type;
    public static string rintrac_diameter;
    public static string rintrac_prod_batch;
    public static string rintrac_prod_site;
    public static string rintrac_SDR;
    public static string rintrac_PE_compound;
    public static string rintrac_material_type;
    public static string rintrac_PE_designation;
    public static string rintrac_MFR;
    public static string rintrac_additional_1;
    public static string rintrac_additional_2;
    public static bool Sblocco_Totale = false;
    public static string Dialog_Result;
    public static string Ordina_per;
    public static bool Esito_query_positivo;
    private static char[] VettoreLettere = new char[30]
    {
      ' ',
      'A',
      'B',
      'C',
      'D',
      'E',
      'F',
      'G',
      'H',
      'I',
      'J',
      'K',
      'L',
      'M',
      'N',
      'O',
      'P',
      'Q',
      'R',
      'S',
      'T',
      'U',
      'V',
      'W',
      'X',
      'Y',
      'Z',
      '+',
      ' ',
      ' '
    };
    public static bool report_elektra_v_1_4;
    public static string Nome_Applicazione;
    public static bool database_con_campi_modificabili = true;
    public static bool Scarico_solo_ultimo_report = false;
    public static bool Effettuare_cancellazione = false;
    public static string TempScale;
    public static string FormatDate;
    public static int Delta_ELK_X_datasald_giorni;
    public static int Delta_ELK_X_datasald__mesi;
    public static int Delta_ELK_X_datasald__anni;
    public static int Delta_ELK_X_databadge__mesi;
    public static int Delta_ELK_X_databadge__anni;
    public static int Delta_ELK_X_datarev__mesi;
    public static int Delta_ELK_X_datarev__anni;
    public static bool Alarm_OFF_mode = false;
    public static bool Flag_RT_log = false;

    public static string GetPath()
    {
      string location = Assembly.GetExecutingAssembly().Location;
      return location.Substring(0, location.LastIndexOf("\\"));
    }

    public static bool Decodifica_badge_operatore(string codice)
    {
      Modulo1.badge_oper = "";
      Modulo1.badge_scad_mese = "";
      Modulo1.badge_scad_anno = "";
      Modulo1.badge_nazione = "";
      Modulo1.badge_organizzaz = "";
      Modulo1.badge_skill = "";
      Modulo1.badge_lingua = "";
      bool flag;
      if (Strings.Len(codice) == 30)
      {
        int num1 = checked (Modulo1.Calcola_CKS_even_odd(codice, (byte) 29) + 2);
        if (num1 > 9)
          checked { num1 -= 10; }
        double num2 = Conversion.Val(Strings.Mid(codice, 21, 10));
        if (Conversion.Val(Strings.Mid(codice, 30, 1)) == (double) num1 & num2 > 0.0)
        {
          int Start1 = 2;
          do
          {
            Modulo1.badge_oper += Conversions.ToString(Strings.Chr(checked ((int) Math.Round(unchecked (Conversion.Val(Strings.Mid(codice, Start1, 2)) + 32.0)))));
            checked { Start1 += 2; }
          }
          while (Start1 <= 12);
          Modulo1.badge_scad_mese = Strings.Mid(codice, 14, 2);
          Modulo1.badge_scad_anno = Strings.Mid(codice, 16, 2);
          Modulo1.badge_nazione = Strings.Mid(codice, 18, 3);
          int Start2 = 21;
          do
          {
            Modulo1.badge_organizzaz += Conversions.ToString(Strings.Chr(checked ((int) Math.Round(unchecked (Conversion.Val(Strings.Mid(codice, Start2, 2)) + 32.0)))));
            checked { Start2 += 2; }
          }
          while (Start2 <= 23);
          Modulo1.badge_skill = Strings.Mid(codice, 25, 3);
          Modulo1.badge_lingua = Strings.Mid(codice, 28, 2);
          flag = true;
        }
        else if (Modulo1.Calcola_CKS_20digit(codice) == checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 19, 2)))))
        {
          Modulo1.badge_oper = Conversions.ToString(Strings.Chr(checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 1, 2)))))) + Conversions.ToString(Strings.Chr(checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 3, 2)))))) + "-";
          if (Conversion.Val(Strings.Mid(codice, 5, 2)) == 9.0)
            Modulo1.badge_oper += "Sup-";
          int Start = 7;
          do
          {
            Modulo1.badge_oper += Conversions.ToString(Strings.Chr(checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, Start, 2))))));
            checked { Start += 2; }
          }
          while (Start <= 17);
          flag = true;
        }
        else
          flag = false;
      }
      else
        flag = false;
      return flag;
    }

    public static int Calcola_CKS_20digit(string cod)
    {
      int num1 = 0;
      int Start = 1;
      do
      {
        num1 = checked ((int) Math.Round(unchecked ((double) num1 + Conversion.Val(Strings.Mid(cod, Start, 1)))));
        checked { ++Start; }
      }
      while (Start <= 18);
      int num2 = checked (num1 + 3);
      if (num2 > 99)
        checked { num2 -= 100; }
      return num2;
    }

    public static RITMOJointData Decodifica_barcode_giunto(string codice, int temperat_celsius)
    {
      bool flag;
      if (Strings.Len(codice) == 24)
      {
        int num = Modulo1.Calcola_CKS_even_odd(codice, (byte) 23);
        if (Conversion.Val(Strings.Mid(codice, 24, 1)) == (double) num)
        {
          return Modulo1.Decodifica24DigitCode(codice, temperat_celsius);
          flag = true;
        }
        else
          flag = false;
      }
      else
        flag = false;
    //   return flag;
        return new RITMOJointData();
    }

    public static RITMOJointData Decodifica24DigitCode(string codice, int temperatura_celsius)
    {

      
      int[] numArray1 = new int[101];
      byte[] numArray2 = new byte[9]
      {
        (byte) 5,
        (byte) 10,
        (byte) 15,
        (byte) 20,
        (byte) 30,
        (byte) 45,
        (byte) 60,
        (byte) 75,
        (byte) 90
      };
      string[] strArray1 = new string[10]
      {
        " IPS",
        " 1/4 IPS",
        " 3/8 IPS",
        " 1/2 IPS",
        " 3/4 IPS",
        " CTS",
        " 1/4 CTS",
        " 3/8 CTS",
        " 1/2 CTS",
        " 3/4 CTS"
      };
      string[] strArray2 = new string[31]
      {
        "20mm",
        "25mm",
        "32mm",
        "40mm",
        "50mm",
        "63mm",
        "75mm",
        "90mm",
        "110mm",
        "125mm",
        "140mm",
        "160mm",
        "180mm",
        "200mm",
        "225mm",
        "250mm",
        "315mm",
        " ",
        " ",
        "1/2 CTS",
        "1 CTS",
        "1'1/4 CTS",
        "1/2 IPS",
        "3/4 IPS",
        "1 IPS",
        "1'1/4 IPS",
        "2 IPS",
        "3 IPS",
        "4 IPS",
        "6 IPS",
        "8 IPS"
      };
      byte[] numArray3 = new byte[10]
      {
        (byte) 2,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 0,
        (byte) 1,
        (byte) 2,
        (byte) 1,
        (byte) 2,
        (byte) 1
      };
      byte[] numArray4 = new byte[10]
      {
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 1,
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 1
      };
      byte[] numArray5 = new byte[10]
      {
        (byte) 1,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 1,
        (byte) 1,
        (byte) 1
      };
      byte[] numArray6 = new byte[9]
      {
        (byte) 0,
        (byte) 6,
        (byte) 8,
        (byte) 10,
        (byte) 12,
        (byte) 15,
        (byte) 19,
        (byte) 24,
        (byte) 30
      };
      byte[] numArray7 = new byte[10]
      {
        (byte) 7,
        (byte) 7,
        (byte) 7,
        (byte) 7,
        (byte) 12,
        (byte) 12,
        (byte) 12,
        (byte) 20,
        (byte) 20,
        (byte) 20
      };
      byte[] numArray8 = new byte[10]
      {
        (byte) 0,
        (byte) 1,
        (byte) 4,
        (byte) 6,
        (byte) 1,
        (byte) 4,
        (byte) 6,
        (byte) 1,
        (byte) 4,
        (byte) 6
      };
      byte[] numArray9 = new byte[10]
      {
        (byte) 0,
        (byte) 0,
        (byte) 0,
        (byte) 3,
        (byte) 6,
        (byte) 10,
        (byte) 15,
        (byte) 20,
        (byte) 25,
        (byte) 30
      };
      int[] numArray10 = new int[100]
      {
        0,
        1,
        2,
        3,
        4,
        5,
        6,
        7,
        8,
        9,
        10,
        11,
        12,
        13,
        14,
        15,
        16,
        17,
        18,
        19,
        20,
        22,
        24,
        26,
        28,
        30,
        32,
        34,
        36,
        38,
        40,
        44,
        48,
        52,
        56,
        60,
        64,
        68,
        72,
        76,
        80,
        90,
        100,
        110,
        120,
        130,
        140,
        150,
        160,
        170,
        190,
        210,
        230,
        250,
        270,
        290,
        310,
        330,
        350,
        370,
        400,
        440,
        480,
        520,
        560,
        600,
        640,
        680,
        720,
        760,
        13,
        14,
        15,
        16,
        18,
        19,
        20,
        21,
        22,
        23,
        24,
        26,
        28,
        30,
        32,
        34,
        36,
        38,
        40,
        42,
        46,
        50,
        54,
        58,
        62,
        66,
        70,
        74,
        78,
        82
      };
      int num1 = Strings.Len(codice);
      int Start = 1;
      while (Start <= num1)
      {
        numArray1[Start] = checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, Start, 1))));
        checked { ++Start; }
      }
      int num2 = numArray1[1] != 9 ? 0 : 1;
      Modulo1.giunto_case = Conversions.ToString(Strings.Chr(checked (65 + num2)));
      int num3 = 0;
      int num4 = 0;
      if (num2 == 0)
      {
        switch (numArray1[1])
        {
          case 0:
          case 1:
          case 2:
            num3 = 20;
            num4 = 0;
            break;
          case 3:
          case 4:
          case 5:
            num3 = 21;
            num4 = 3;
            break;
          case 6:
          case 7:
          case 8:
            num3 = 6;
            num4 = 6;
            break;
        }
      }
      else
        num3 = numArray1[2];
      switch (num3)
      {
        case 0:
          Modulo1.giunto_type = " * FFP";
          break;
        case 1:
          Modulo1.giunto_type = " < ERS";
          break;
        case 2:
          Modulo1.giunto_type = " J TDW";
          break;
        case 3:
          Modulo1.giunto_type = " Y RED";
          break;
        case 4:
          Modulo1.giunto_type = " + SAD";
          break;
        case 5:
          Modulo1.giunto_type = " I CPL";
          break;
        case 6:
          Modulo1.giunto_type = " [ SKT";
          break;
        case 7:
          Modulo1.giunto_type = " T TEE";
          break;
        case 8:
          Modulo1.giunto_type = " C BOW";
          break;
        case 9:
          Modulo1.giunto_type = " WAIT";
          break;
        case 20:
          Modulo1.giunto_type = " + SAD";
          break;
        case 21:
          Modulo1.giunto_type = " I CPL";
          break;
      }
      int num5 = 0;
      int Number1 = 0;
      switch (numArray1[3])
      {
        case 0:
        case 1:
        case 2:
          num5 = 0;
          Number1 = 0;
          break;
        case 3:
        case 4:
        case 5:
          num5 = 3;
          Number1 = 3;
          break;
        case 6:
        case 7:
        case 8:
          num5 = 6;
          Number1 = 6;
          break;
      }
      Modulo1.giunto_energy_correction = "ENERGY CORRECTION " + Conversion.Str((object) Number1);
      int num6 = 0;
      int num7 = 0;
      switch (numArray1[5])
      {
        case 0:
        case 1:
        case 2:
          num6 = 0;
          num7 = 0;
          Modulo1.giunto_cycle_type = "UNIFORM CYCLE";
          break;
        case 3:
        case 4:
        case 5:
          num6 = 3;
          num7 = 3;
          Modulo1.giunto_cycle_type = "SEQUENTIAL CYCLE, AVAILABLE";
          break;
        case 6:
        case 7:
        case 8:
          num6 = 6;
          num7 = 6;
          Modulo1.giunto_cycle_type = "TEMPERATURE CYCLE";
          break;
      }
      int num8 = 0;
      switch (numArray1[7])
      {
        case 0:
        case 1:
        case 2:
          num8 = 0;
          Modulo1.giunto_control_type = "TIME CONTR. NO COOL TIME";
          break;
        case 3:
          num8 = 1;
          Modulo1.giunto_control_type = "TIME CONTR. WITH COOL TIME";
          break;
        case 4:
          num8 = 2;
          Modulo1.giunto_control_type = "ENERGY CONTROL";
          break;
        case 5:
        case 6:
        case 7:
        case 8:
        case 9:
          num8 = 3;
          Modulo1.giunto_control_type = "ENERGY CONTR. WITH COOL TIME";
          break;
      }
      string str1 = num2 != 0 ? Conversions.ToString(Modulo1.VettoreLettere[checked ((numArray1[3] - Number1) * 10 + numArray1[4])]) + Conversions.ToString(Modulo1.VettoreLettere[checked ((numArray1[5] - num7) * 10 + numArray1[6])]) : Conversions.ToString(Modulo1.VettoreLettere[checked ((numArray1[1] - num4) * 10 + numArray1[2])]) + Conversions.ToString(Modulo1.VettoreLettere[checked ((numArray1[3] - Number1) * 10 + numArray1[4])]) + Conversions.ToString(Modulo1.VettoreLettere[checked ((numArray1[5] - num7) * 10 + numArray1[6])]);
      if (numArray1[7] < 3)
        str1 += Conversions.ToString(Modulo1.VettoreLettere[checked (numArray1[7] * 10 + numArray1[8])]);
      Modulo1.giunto_trademark = str1;
      int num9;
      if (num8 == 0)
      {
        num9 = 10;
        Modulo1.giunto_cooling_time = "----";
      }
      else if (numArray1[8] == 9)
      {
        num9 = 11;
        Modulo1.giunto_cooling_time = "SEE ISO 13950:2007";
      }
      else
        Modulo1.giunto_cooling_time = Conversion.Str((object) (int) numArray2[numArray1[8]]) + " minutes";
      int Number2 = checked (numArray1[9] * 100 + numArray1[10] * 10 + numArray1[11]);
      string str2;
      if (num3 == 3 | num3 == 4)
      {
        int index1 = checked ((int) Math.Round(Conversion.Int(unchecked ((double) Number2 / 31.0))));
        int index2 = checked (Number2 - index1 * 31);
        str2 = strArray2[index1] + " --- " + strArray2[index2];
      }
      else
      {
        int num10 = Number2;
        str2 = num10 != 0 ? (num10 < 1 || num10 > 14 ? (num10 < 15 || num10 > 799 ? (num10 < 800 || num10 > 999 ? "null" : Conversion.Str((object) Conversion.Int((double) Number2 / 10.0 - 80.0)) + strArray1[numArray1[11]]) : Conversion.Str((object) Number2) + "mm") : "Reserved") : "Not described by diameter";
      }
      Modulo1.giunto_diameter = str2;
      int num11 = (int) numArray3[numArray1[12]];
      int num12 = (int) numArray4[numArray1[12]];
      int num13 = (int) numArray5[numArray1[12]];
      switch (num11)
      {
        case 0:
          Modulo1.giunto_commapos_typereg_K_Kprimo = "--- ";
          break;
        case 1:
          Modulo1.giunto_commapos_typereg_K_Kprimo = "--,- ";
          break;
        case 2:
          Modulo1.giunto_commapos_typereg_K_Kprimo = "-,-- ";
          break;
      }
      switch (num12)
      {
        case 0:
          Modulo1.giunto_commapos_typereg_K_Kprimo += "V, ";
          break;
        case 1:
          Modulo1.giunto_commapos_typereg_K_Kprimo += "I, ";
          break;
      }
      switch (num13)
      {
        case 0:
          Modulo1.giunto_commapos_typereg_K_Kprimo += "K, ";
          break;
        case 1:
          Modulo1.giunto_commapos_typereg_K_Kprimo += "K', ";
          break;
      }
      if (num5 == 3)
        Modulo1.giunto_commapos_typereg_K_Kprimo += "MODE P";
      int Number3 = checked (numArray1[13] * 10 + numArray1[14]);
      if (num12 == 0)
      {
        if (Number3 == 99)
          Modulo1.giunto_level_reg = "39,5 V";
        else if (Number3 < 99 & Number3 > 89)
          Modulo1.giunto_level_reg = "ERROR";
        else if (Number3 <= 89)
          Modulo1.giunto_level_reg = Conversion.Str((object) Number3) + ".0 V";
      }
      else if (num12 == 1)
        Modulo1.giunto_level_reg = Conversion.Str((object) Number3) + ".0 A";
      long Left1 = (long) checked (numArray1[15] * 100 + numArray1[16] * 10 + numArray1[17]);
      if (Left1 == 0L)
      {
        Modulo1.giunto_ohmic_value = "IGNORE, NO CONTROL";
        Modulo1.giunto_ohmic_min = "IGNORE";
        Modulo1.giunto_ohmic_max = "IGNORE";
      }
      else
      {
        switch (num11)
        {
          case 0:
            checked { Left1 *= 100L; }
            Modulo1.giunto_ohmic_value = Conversion.Str((object) ((double) Left1 / 100.0)) + " ohm";
            break;
          case 1:
            checked { Left1 *= 10L; }
            Modulo1.giunto_ohmic_value = Conversion.Str((object) ((double) Left1 / 100.0)) + " ohm";
            break;
          case 2:
            Left1 = Left1;
            Modulo1.giunto_ohmic_value = Conversion.Str((object) ((double) Left1 / 100.0)) + " ohm";
            break;
        }
      }
      switch (num13)
      {
        case 0:
          switch (numArray1[18])
          {
            case 0:
              Modulo1.giunto_K_Kprimo = "IGNORE, NO CONTROL";
              break;
            case 9:
              Modulo1.giunto_K_Kprimo = "RESERVED, SEE ISO 13950:2007";
              break;
            default:
              int Number4 = (int) numArray6[numArray1[18]];
              long num14 = checked ((long) Math.Round(Math.Round(unchecked ((double) checked (Left1 * (long) (100 - Number4)) / 100.0))));
              long num15 = checked ((long) Math.Round(Math.Round(unchecked ((double) checked (Left1 * (long) (100 + Number4)) / 100.0))));
              Modulo1.giunto_K_Kprimo = " K = ± " + Conversion.Str((object) Number4) + "%";
              Modulo1.giunto_ohmic_min = Conversion.Str((object) ((double) num14 / 100.0)) + " ohm";
              Modulo1.giunto_ohmic_max = Conversion.Str((object) ((double) num15 / 100.0)) + " ohm";
              break;
          }
          break;
        case 1:
          int num16 = (int) numArray7[numArray1[18]];
          int Number5 = (int) numArray8[numArray1[18]];
          int num17 = temperatura_celsius;
          object Left2 = (object) ((double) checked (Number5 * num17 - 20) / 1000.0);
          long num18 = Conversions.ToLong(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[1]
          {
            Operators.DivideObject(Operators.MultiplyObject((object) Left1, Operators.SubtractObject(Operators.AddObject((object) checked (100 - num16), Operators.MultiplyObject(Left2, (object) 100)), Operators.MultiplyObject(Left2, (object) num16))), (object) 100)
          }, (string[]) null, (Type[]) null, (bool[]) null));
          long num19 = Conversions.ToLong(NewLateBinding.LateGet((object) null, typeof (Math), "Round", new object[1]
          {
            Operators.DivideObject(Operators.MultiplyObject((object) Left1, Operators.SubtractObject(Operators.AddObject((object) checked (100 + num16), Operators.MultiplyObject(Left2, (object) 100)), Operators.MultiplyObject(Left2, (object) num16))), (object) 100)
          }, (string[]) null, (Type[]) null, (bool[]) null));
          Modulo1.giunto_K_Kprimo = " K' = ± " + Conversion.Str((object) num16) + "% , " + Conversion.Str((object) Number5) + " *10-3";
          Modulo1.giunto_ohmic_min = Conversion.Str((object) ((double) num18 / 100.0)) + " ohm";
          Modulo1.giunto_ohmic_max = Conversion.Str((object) ((double) num19 / 100.0)) + " ohm";
          break;
      }
      int Number6 = 0;
      int Number7 = 0;
      if (num6 != 6)
      {
        if (numArray1[22] == 1 & numArray1[23] == 1)
        {
          Number6 = 0;
          Number7 = 0;
          Modulo1.giunto_En_Corr = "NO CORRECTION";
        }
        else if (numArray1[22] > 1 & numArray1[23] > 1)
        {
          Number6 = numArray1[23];
          Number7 = numArray1[22];
          Modulo1.giunto_En_Corr = " under=0." + Conversion.Str((object) Number7) + "%/°C,  above=0." + Conversion.Str((object) Number6) + "%/°C";
        }
        else
        {
          Number6 = 0;
          Number7 = 0;
          Modulo1.giunto_En_Corr = "ERROR";
        }
      }
      else
      {
        int index = checked (numArray1[22] * 10 + numArray1[23]);
        Modulo1.giunto_En_Corr = "Holding time= " + Conversion.Str((object) numArray10[index]);
        Modulo1.giunto_En_Corr = index >= 70 ? Modulo1.giunto_En_Corr + " min" : Modulo1.giunto_En_Corr + " s";
      }
      int num20 = temperatura_celsius;
      if (num6 == 6)
      {
        if (numArray1[19] <= 2)
        {
          Modulo1.giunto_time_energy_stoptemp = " Stop Temp.= " + Conversion.Str((object) checked (numArray1[19] * 100 + numArray1[20] * 10 + numArray1[21])) + " °C";
        }
        else
        {
          int Number8 = (int) numArray9[numArray1[19]];
          int Number9 = checked (numArray1[20] * 100 + numArray1[21] * 10);
          Modulo1.giunto_time_energy_stoptemp = "Rise Time=" + Conversion.Str((object) Number8) + " s Stop Temp.= " + Conversion.Str((object) Number9) + " °C";
        }
      }
      else
      {
        switch (num8)
        {
          case 0:
          case 1:
            int Number10 = checked (numArray1[19] * 100 + numArray1[20] * 10 + numArray1[21]);
            if (Number10 == 0)
            {
              Modulo1.giunto_time_energy_stoptemp = " Time = infinity ";
              break;
            }
            if (numArray1[19] == 9)
              Number10 = checked (numArray1[20] * 10 + numArray1[21] * 60);
            if (num20 > 20)
              Number10 = checked ((int) Math.Round(unchecked ((double) Number10 * 1.0 - (double) checked (Number6 * num20 - 20) / 1000.0)));
            else if (num20 < 20)
              Number10 = checked ((int) Math.Round(unchecked ((double) Number10 * 1.0 + (double) checked (Number7 * 20 - num20) / 1000.0)));
            Modulo1.giunto_time_energy_stoptemp = " Time = " + Conversion.Str((object) Number10) + " s";
            break;
          case 2:
            double Number11 = (double) checked (numArray1[19] * 10 + numArray1[20]) * Math.Pow(10.0, (double) numArray1[21]);
            if (num20 > 20)
              Number11 *= 1.0 - (double) checked (Number6 * num20 - 20) / 1000.0;
            else if (num20 < 20)
              Number11 *= 1.0 + (double) checked (Number7 * 20 - num20) / 1000.0;
            Modulo1.giunto_time_energy_stoptemp = " Energy = " + Conversion.Str((object) Number11) + " joule";
            break;
          case 3:
            double Number12 = (double) checked (numArray1[19] * 100 + numArray1[20] * 10 + numArray1[21]) * Math.Pow(10.0, (double) checked (numArray1[7] - 4));
            if (num20 > 20)
              Number12 *= 1.0 - (double) checked (Number6 * num20 - 20) / 1000.0;
            else if (num20 < 20)
              Number12 *= 1.0 + (double) checked (Number7 * 20 - num20) / 1000.0;
            Modulo1.giunto_time_energy_stoptemp = " Energy = " + Conversion.Str((object) Number12) + " joule";
            break;
        }
      }

      return new RITMOJointData{
          Diameter = Modulo1.giunto_diameter,
          Type = Modulo1.giunto_type,
          Trademark = Modulo1.giunto_trademark,
          Cooling = Modulo1.giunto_cooling_time,
          Time = Modulo1.giunto_time_energy_stoptemp,
          Voltage = giunto_level_reg
      };
    }

    // public static bool Decodifica_barcode_rintrac(string codice)
    // {
    //   bool flag;
    //   if (Strings.Len(codice) == 40)
    //   {
    //     if (Conversion.Val(Strings.Mid(codice, 5, 1)) > 4.0 | Conversion.Val(Strings.Mid(codice, 3, 1)) > 2.0)
    //     {
    //       string stringa = "";
    //       int Start = 1;
    //       do
    //       {
    //         stringa = Start == 26 ? stringa + "0" : stringa + Strings.Mid(codice, Start, 1);
    //         checked { ++Start; }
    //       }
    //       while (Start <= 40);
    //       int num = Modulo1.Calcola_CKS_even_odd(stringa, (byte) 40);
    //       if (Conversion.Val(Strings.Mid(codice, 26, 1)) == (double) num)
    //       {
    //         Modulo1.Decodifica_rintracciab(codice);
    //         flag = true;
    //       }
    //       else
    //         flag = false;
    //     }
    //     else
    //     {
    //       Modulo1.Decodifica_rintracciab(codice);
    //       flag = true;
    //     }
    //   }
    //   else
    //     flag = false;
    //   return flag;
    // }

    // public static void Decodifica_rintracciab(string codice)
    // {
    //   ResourceManager resourceManager = new ResourceManager(typeof (Form_Database_MULTIPLA));
    //   string[] strArray1 = new string[31]
    //   {
    //     "16mm",
    //     "20mm",
    //     "25mm",
    //     "32mm",
    //     "40mm",
    //     "50mm",
    //     "63mm",
    //     "75mm",
    //     "90mm",
    //     "110mm",
    //     "125mm",
    //     "140mm",
    //     "160mm",
    //     "180mm",
    //     "200mm",
    //     "225mm",
    //     "250mm",
    //     "280mm",
    //     "315mm",
    //     "355mm",
    //     "400mm",
    //     "450mm",
    //     "500mm",
    //     "560mm",
    //     "630mm",
    //     "710mm",
    //     "800mm",
    //     "900mm",
    //     "1000mm",
    //     "1200mm",
    //     ">=1400mm"
    //   };
    //   string[] strArray2 = new string[31]
    //   {
    //     "1/2 CTS",
    //     "1 CTS",
    //     "1 1/4 CTS",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     ""
    //   };
    //   string[] strArray3 = new string[31]
    //   {
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "1/2 IPS",
    //     "3/4 IPS",
    //     "1 IPS",
    //     "1 1/4 IPS",
    //     "1 1/2 IPS",
    //     "2 IPS",
    //     "3 IPS",
    //     "4 IPS",
    //     "6 IPS",
    //     "8 IPS",
    //     "10 IPS",
    //     "11 IPS",
    //     "12 IPS",
    //     "13 IPS",
    //     "14 IPS",
    //     "",
    //     "",
    //     "",
    //     "",
    //     "",
    //     ""
    //   };
    //   string[] strArray4 = new string[10]
    //   {
    //     ">33",
    //     "33",
    //     "26",
    //     "21",
    //     "17.6",
    //     "17",
    //     "13.6",
    //     "11",
    //     "9",
    //     "<9"
    //   };
    //   string[] strArray5 = new string[3]
    //   {
    //     "Virgin material",
    //     "100% reproces.material",
    //     "Virgin+reprocess.material"
    //   };
    //   string[] strArray6 = new string[10]
    //   {
    //     "Not Used",
    //     "PE63",
    //     "PE80",
    //     "PE100",
    //     "Reserved for future use",
    //     "Reserved for future use",
    //     "1Reserved for future use",
    //     "Reserved for future use",
    //     "Reserved for future use",
    //     "Reserved for future use"
    //   };
    //   string[] strArray7 = new string[10]
    //   {
    //     "MFR value not specified",
    //     "MFR<=5",
    //     "5<MFR<=7",
    //     "7<MFR<=10",
    //     "10<MFR<=15",
    //     "15<MFR<=20",
    //     "20<MFR<=25",
    //     "25<MFR<=32",
    //     "32<MFR<=40",
    //     "MFR>40"
    //   };
    //   string[] strArray8 = new string[30]
    //   {
    //     "00",
    //     "Pipe straight",
    //     "Pipe, coiled",
    //     "Socket",
    //     "Tapping saddle",
    //     "Branching saddle",
    //     "Elbow, 90°",
    //     "Elbow, 45°",
    //     "Elbow, undefined",
    //     "Tee",
    //     "End cap",
    //     "Reducer",
    //     "Swept bend",
    //     "Flange adapter",
    //     "Mechanical fitting",
    //     "PE-body valve, QT",
    //     "PE-body valve, MT",
    //     "Non-PE-body valve, QT",
    //     "Non-PE-body valve, MT",
    //     "Repair fitting",
    //     "Transition fitting",
    //     "Wall channel, rigid",
    //     "Wall channel, flexible",
    //     "Pressure tapping valve",
    //     "Ventilation end cap",
    //     "Stop-off saddle",
    //     "Cap for tapping saddle",
    //     "PE/steel transition fitting",
    //     "PE/brass transition fitting",
    //     "Excess-flow valve"
    //   };
    //   int num1 = Conversion.Val(Strings.Mid(codice, 5, 1)) >= 5.0 ? 2 : 1;
    //   string Left = num1 != 1 ? (Conversion.Val(Strings.Mid(codice, 23, 1)) >= 3.0 ? (Conversion.Val(Strings.Mid(codice, 23, 1)) >= 6.0 ? "1diametro_cm" : "1diametro_mm") : "2diametri") : (Conversion.Val(Strings.Mid(codice, 1, 1)) >= 3.0 ? (Conversion.Val(Strings.Mid(codice, 1, 1)) >= 6.0 ? "1diametro_cm" : "1diametro_mm") : "2diametri");
    //   bool flag = Conversion.Val(Strings.Mid(codice, 3, 1)) >= 3.0;
    //   Modulo1.rintrac_supplier = "";
    //   if (num1 == 1)
    //   {
    //     int Number1 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 1, 2))));
    //     if (Number1 > 59)
    //       checked { Number1 -= 60; }
    //     else if (Number1 > 29)
    //       checked { Number1 -= 30; }
    //     Modulo1.rintrac_supplier = !(Number1 > 0 & Number1 < 30) ? (Number1 >= 10 ? Conversion.Str((object) Number1) : " 0" + Strings.Mid(Conversion.Str((object) Number1), 2, 1)) : Conversions.ToString(Modulo1.VettoreLettere[Number1]);
    //     int Number2 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 3, 2))));
    //     if (Number2 > 29)
    //       checked { Number2 -= 30; }
    //     Modulo1.rintrac_supplier = !(Number2 > 0 & Number2 < 30) ? (Number2 >= 10 ? Modulo1.rintrac_supplier + Conversion.Str((object) Number2) : Modulo1.rintrac_supplier + " 0" + Strings.Mid(Conversion.Str((object) Number2), 2, 1)) : Modulo1.rintrac_supplier + Conversions.ToString(Modulo1.VettoreLettere[Number2]);
    //   }
    //   else
    //     Modulo1.rintrac_supplier = Strings.Mid(codice, 1, 4);
    //   int Number3 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 5, 2))));
    //   if (Number3 > 49)
    //     checked { Number3 -= 50; }
    //   Modulo1.rintrac_pipe_type = !(Number3 > 0 & Number3 < 30) ? Conversion.Str((object) Number3) : strArray8[Number3];
    //   int Number4 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 7, 3))));
    //   if (Operators.CompareString(Left, "1diametro_mm", false) == 0)
    //     Modulo1.rintrac_diameter = Conversion.Str((object) Number4) + " mm";
    //   else if (Operators.CompareString(Left, "1diametro_cm", false) == 0)
    //     Modulo1.rintrac_diameter = Conversion.Str((object) Number4) + " cm";
    //   else if (Number4 == 992)
    //   {
    //     int num2 = 31;
    //     int num3 = 31;
    //     Modulo1.rintrac_diameter = strArray1[checked (num2 - 1)] + " - " + strArray1[checked (num3 - 1)];
    //   }
    //   else
    //   {
    //     int num4 = checked ((int) Math.Round(Conversion.Int(unchecked ((double) Number4 / 31.0))));
    //     int num5 = checked (Number4 - num4 * 31);
    //     if (num4 >= num5)
    //     {
    //       Modulo1.rintrac_diameter = !(num4 > 0 & num4 < 32 & num5 > 0 & num5 < 32) ? resourceManager.GetString("DATA_ERROR") : strArray1[checked (num4 - 1)] + " - " + strArray1[checked (num5 - 1)];
    //     }
    //     else
    //     {
    //       int num6 = checked (num5 - 1);
    //       Modulo1.rintrac_diameter = !(num4 > 0 & num4 < 5 & num6 > 0 & num6 < 5) ? (!(num4 > 10 & num4 < 26 & num6 > 10 & num6 < 26) ? resourceManager.GetString("DATA_ERROR") : strArray3[checked (num6 - 1)] + " - " + strArray3[checked (num4 - 1)]) : strArray2[checked (num6 - 1)] + " - " + strArray2[checked (num4 - 1)];
    //     }
    //   }
    //   Modulo1.rintrac_prod_batch = Strings.Mid(codice, 10, 6);
    //   Modulo1.rintrac_prod_site = Strings.Mid(codice, 16, 2);
    //   Modulo1.rintrac_SDR = strArray4[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 18, 1))))];
    //   if (num1 == 1)
    //   {
    //     Modulo1.rintrac_PE_compound = Conversions.ToString(Modulo1.VettoreLettere[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 19, 2))))]);
    //     Modulo1.rintrac_PE_compound = Conversion.Val(Strings.Mid(codice, 21, 2)) >= 10.0 ? Modulo1.rintrac_PE_compound + Strings.Mid(codice, 21, 2) : Modulo1.rintrac_PE_compound + "0" + Strings.Mid(codice, 22, 1);
    //   }
    //   else
    //     Modulo1.rintrac_PE_compound = Conversion.Val(Strings.Mid(codice, 19, 4)) >= 1000.0 ? Strings.Mid(codice, 19, 4) : "0" + Strings.Mid(codice, 20, 3);
    //   Modulo1.rintrac_material_type = Conversion.Val(Strings.Mid(codice, 23, 1)) >= 3.0 ? Conversion.Str((object) Conversion.Val(Strings.Mid(codice, 23, 1))) : (num1 != 1 ? (Operators.CompareString(Left, "2diametri", false) != 0 ? (Operators.CompareString(Left, "1diametro_mm", false) != 0 ? strArray5[checked ((int) Math.Round(unchecked (Conversion.Val(Strings.Mid(codice, 23, 1)) - 6.0)))] : strArray5[checked ((int) Math.Round(unchecked (Conversion.Val(Strings.Mid(codice, 23, 1)) - 3.0)))]) : strArray5[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 23, 1))))]) : strArray5[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 23, 1))))]);
    //   Modulo1.rintrac_PE_designation = strArray6[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 24, 1))))];
    //   Modulo1.rintrac_MFR = strArray7[checked ((int) Math.Round(Conversion.Val(Strings.Mid(codice, 25, 1))))];
    //   Modulo1.rintrac_additional_1 = Strings.Mid(codice, 27, 10);
    //   Modulo1.rintrac_additional_2 = Strings.Mid(codice, 37, 4);
    // }

    public static int Calcola_CKS_even_odd(string stringa, byte lung_dati)
    {
      int num1 = 0;
      int num2 = 0;
      int num3 = (int) lung_dati;
      int Start = 1;
      while (Start <= num3)
      {
        int num4 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(stringa, Start, 1))));
        num1 = checked ((int) Math.Round(unchecked ((double) num1 + Conversion.Val(Strings.Mid(stringa, Start, 1)) * 3.0)));
        if (checked (Start + 1) <= (int) lung_dati)
          num2 = checked ((int) Math.Round(unchecked ((double) num2 + Conversion.Val(Strings.Mid(stringa, checked (Start + 1), 1)))));
        checked { Start += 2; }
      }
      int num5 = checked (num1 + num2);
      int num6 = 0;
      while ((double) checked (num5 + num6) / 10.0 - Conversion.Int((double) checked (num5 + num6) / 10.0) != 0.0)
      {
        checked { ++num6; }
        if (num6 > 9)
          break;
      }
      return num6;
    }

 

  }


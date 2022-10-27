// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Text.Json;

namespace RITMOConverter
{  

    public class Program
    {
        public static void Main()
        {

            var parser = new Parser();
            
            var reports = parser.convert(@"./ELEKTRA.PEG");
            
            string jsonString = JsonSerializer.Serialize(reports);
            Console.WriteLine(jsonString);
        }
    }
}
  



// void report(byte[] InputData){

//     object sald_a = (object) dec_to_hex(InputData[2]);
//     object sald_h = (object) dec_to_hex(InputData[3]);
//     object sald_m = (object) dec_to_hex(InputData[4]);

//     object job = (object) (Conversions.ToString(Strings.Chr((int) InputData[7]))) + (Conversions.ToString(Strings.Chr((int) InputData[8])));

//     Console.WriteLine("Job" + InputData[7] + sald_a + sald_h + sald_m);
// }

// FileInfo fileInfo = new FileInfo(@"./ELEKTRA.PEG");

// int fileLength = checked ((int) fileInfo.Length);

// int num_rep_in_mem = checked ((int) Math.Round(Conversion.Int(unchecked ((double) checked (fileLength - 256) / 256.0))));

// Console.WriteLine(num_rep_in_mem);

// BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(@"./ELEKTRA.PEG"));

// int num1 = checked(num_rep_in_mem -1);
// int num2 = 0;

// byte[] vx;

// while(num2 <= num1){
//     vx = binaryReader.ReadBytes(214);

//     byte num3 = calc_cks(vx, 201);

//     byte num4 = calc_cks(vx, 213);

//     if((int) num4 == (int) vx[213]){
//         // Console.WriteLine("Checksum first");
//         report(vx);
//     }else if((int) num3 == (int) vx[201]){
//         // Console.WriteLine("Checksum second");
//         report(vx);
//     }else{
//         Console.WriteLine("Checksum third");
//     }

//     vx = binaryReader.ReadBytes(42);


//     checked { ++num2; };
// }

// byte[] num_array = new byte[4];
// num_array[0] = 74;
// num_array[1] = 125;
// num_array[2] = 136;
// num_array[3] = 72;

// float single = BitConverter.ToSingle(num_array, 0);

// Console.WriteLine(single / 1000f);

// Console.WriteLine("Hello, World!");

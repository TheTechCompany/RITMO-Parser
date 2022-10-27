
using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Text.Json;

    public class RITMOReport
    {
        public string? SerialNumber { get; set; }
        public int? Version {get; set;}
        public int? WeldingNumber {get; set;}
        public string? AmbientTemperature {get; set;}
        public string? SuppliedEnergy {get; set;}
        public string? MeasuredResistance {get; set;}
        public string? MaximumTension {get; set;}
        public string? MinimumTension {get; set;}
        public string? TimeElapsed {get; set;}
        public string? TrenchDepth {get; set;}
        public string? Barcode {get; set;}
        
        public RITMOJointData? JointData {get;set;}
        // public string? BarcodeTubo1 {get; set;}
        // public string? BarcodeTubo2 {get; set;}
        // public string? BarcodeTubo3 {get; set;}
    }  

    public class RITMOJointData 
    {
        public string? Type {get; set;}
        public string? Trademark {get; set;}
        public string? Cooling {get; set;}
        public string? Diameter {get; set;}
        public string? Voltage {get; set;}
        public string? Time {get; set;}
    }
    
public class Parser {


        public int calc_cks_even_odd(string inputString, byte DataLength)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = (int) DataLength;
            int Start = 1;

            while (Start <= num3){
                int num4 = checked ((int) Math.Round(Conversion.Val(Strings.Mid(inputString, Start, 1))));
                num1 = checked((int) Math.Round(unchecked ((double) num1 + Conversion.Val(Strings.Mid(inputString, Start, 1)) * 3.0)));
            
                // num1 = checked ((int) Math.Round(unchecked ((double) num1 + Conversion.Val(Strings.Mid(inputString, Start, 1)) * 3.0)));
                if(checked(Start + 1) <= (int) DataLength)
                    num2 = checked((int) Math.Round( unchecked ((double) num2 + Conversion.Val(Strings.Mid(inputString, checked(Start + 1), 1)))));
                // checked { Start += 2};
                checked { Start += 2; } 
            }
            int num5 = checked (num1 + num2);
            int num6 = 0;
            while ((double) checked (num5 + num6) / 10.0 - Conversion.Int((double) checked (num5 + num6) / 10.0) != 0.0)
            {
                checked { ++num6; }
                if(num6 > 9)
                    break;
            }
            return num6;
        }

    public RITMOReport getReport(byte[] InputData){
            byte[] num_array = new byte[4];

            num_array[0] = Conversions.ToByte(InputData[51]);
            num_array[1] = Conversions.ToByte(InputData[52]);
            num_array[2] = Conversions.ToByte(InputData[53]);
            num_array[3] = Conversions.ToByte(InputData[54]);

            float suppliedEnergy = BitConverter.ToSingle(num_array, 0);

            num_array[0] = Conversions.ToByte(InputData[55]);
            num_array[1] = Conversions.ToByte(InputData[56]);
            num_array[2] = Conversions.ToByte(InputData[57]);
            num_array[3] = Conversions.ToByte(InputData[58]);

            float measuredResistance = BitConverter.ToSingle(num_array, 0);

            string ambientTemperature = Conversions.ToString(InputData[5] + InputData[6] * 256); // + " °C";

            string serialNumber = Conversions.ToString((((InputData[197] + (InputData[198] * 256)) + (InputData[199] * 65536)) + (InputData[200] * 16777216)));


            int version = (InputData[21] + InputData[22] * 256);
            int weldNumber = (((InputData[25] + (InputData[26] * 256)) + (InputData[27] * 65536)) + (InputData[28] * 16777216));

            string trenchDepth = Conversions.ToString(InputData[29] + InputData[30] * 256) + " cm";

            string minTension = Conversions.ToString((double) (InputData[41] + InputData[42] * 256) / 10) +" V";
            string maxTension = Conversions.ToString((double) (InputData[43] + InputData[44] * 256) / 10) + " V";

            string timeElapsed = Conversions.ToString(InputData[49] + InputData[50] * 256) + " s";

            string Barcode = this.Conv_vector_to_string(InputData, 76, 87);

            string giunto_diameter;

            RITMOJointData jointData = Modulo1.Decodifica_barcode_giunto(Barcode, (InputData[5] + InputData[6] * 256));


            string BarcodeTubo1 = this.Conv_vector_to_string(InputData, 88, 107);
            string BarcodeTubo2 = this.Conv_vector_to_string(InputData, 108, 127);
            string BarcodeTubo3 = this.Conv_vector_to_string(InputData, 128, 147);

            var report = new RITMOReport{
                SerialNumber = serialNumber,
                Version = version,
                WeldingNumber = weldNumber,
                MinimumTension = minTension,
                MaximumTension = maxTension,
                TimeElapsed = timeElapsed,
                TrenchDepth = trenchDepth,
                Barcode = Barcode,
                JointData = jointData,
                // Diameter = giunto_diameter,
                // BarcodeTubo1 = BarcodeTubo1,
                // BarcodeTubo2 = BarcodeTubo2,
                // BarcodeTubo3 = BarcodeTubo3,
                AmbientTemperature = ambientTemperature + " C",
                MeasuredResistance = Conversions.ToString(measuredResistance) + " Ohm",
                SuppliedEnergy = suppliedEnergy > 1000.0 ? (suppliedEnergy / 1000f).ToString() + " kJ" : suppliedEnergy.ToString() + " J",
            };
            return report;
    }

        public RITMOReport[] convert(string filePath){

                  
            FileInfo fileInfo = new FileInfo(filePath);

            int fileLength = checked ((int) fileInfo.Length);

            int num_rep_in_mem = checked ((int) Math.Round(Conversion.Int(unchecked ((double) checked (fileLength - 256) / 256.0))));

            var reports = new RITMOReport[num_rep_in_mem];

            BinaryReader binaryReader = new BinaryReader((Stream) File.OpenRead(filePath));

            int num1 = checked(num_rep_in_mem -1);
            int num2 = 0;

            byte[] vx;

            while(num2 <= num1){
                vx = binaryReader.ReadBytes(214);

                byte num3 = this.calc_cks(vx, 201);

                byte num4 = this.calc_cks(vx, 213);

                if((int) num4 == (int) vx[213]){
                    // Console.WriteLine("Checksum first");
                    reports[num2] = this.getReport(vx);
                }else if((int) num3 == (int) vx[201]){
                    // Console.WriteLine("Checksum second");
                    reports[num2] = this.getReport(vx);
                }else{
                    Console.WriteLine("Checksum third");
                }

                vx = binaryReader.ReadBytes(42);


                checked { ++num2; };
            }

            return reports;
        }

        public string Conv_vector_to_string(byte[] InputData, byte index_min, byte index_max){
            string str1 = "";
            int num1 = (int) index_min;
            int num2 = (int) index_max;

            int index = num1;
            while(index <= num2)
            {
                string str2 = InputData[index] >= (byte) 10 ? InputData[index] <= (byte) 99 ? Conversions.ToString(InputData[index]) : "00" : "0" + Conversions.ToString(InputData[index]);
                str1 += str2;
                checked { ++index; };
            }
            return str1;
        }


        public byte calc_cks(byte[] InputData, int DataLength){
            int num1 = 0;
            int num2 = checked(DataLength - 1);
            int index = 0;
            while(index <= num2){
                num1 = checked(num1 + (int) InputData[index]) & (int) byte.MaxValue;
                checked {
                    ++index;
                }
            }
            return checked ((byte) num1);
        }

        public byte dec_to_hex(byte val){
            return checked ((byte) Math.Round(unchecked (Conversion.Int((double) val / 16.0) * 10.0 + (double) val - Conversion.Int((double) val / 16.0) * 16.0)));
        }
}
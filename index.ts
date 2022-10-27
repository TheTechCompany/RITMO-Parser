import {readFileSync} from 'fs';

convert(__dirname + '/ELEKTRA.PEG');

function convert(file: string){
    let fileData = readFileSync(file);

    let length = fileData.byteLength;

    let num_rep_in_mem = Math.round((length - 256) / 256)
    
    convert_elektra(fileData, num_rep_in_mem)
}

function convert_elektra(data: Buffer, num_rep_in_mem: number){
    let num1 = num_rep_in_mem - 1;
    let num2 = 0;

    let lastPos = 0;

    while(num2 <= num1){
        let vx = data.slice(lastPos, lastPos + 214)
        lastPos = lastPos+214

        let num3 = calc_cks(vx, 201);

        let num4 = calc_cks(vx, 213);

        if(num4 == vx[213]){
            console.log("First")
            let resp = report(vx, true);
            console.log(resp);
        }else if(num3 == vx[201]){
            console.log("Second")
            let resp = report(vx, false);
            console.log(resp);
        }else{
            // console.log("Third")
           
            // let resp = report(vx, false);
            // console.log(resp);
        }
        vx = data.slice(lastPos, lastPos+42)
        lastPos = lastPos + 42;


        // console.log({vx,num3,num4, lastPos})

      
        num2++;
    }
}

function calc_cks(input: Buffer, length: number){
    let num1 = 0;
    let num2 = length -1;

    let index = 0;

    while(index <= num2){
        num1 = num1 + input[index] & 255;
        ++index;
    }
    return num1;
}

function dec_to_hex(input: number){
    return Math.round( (input / 16) * 10 + input - (input / 16) * 16)
    // return input.toString(16);
}

function vec_to_string(buff: Buffer, start_ix: number, end_ix: number){
    let string1 = "";

    let index = start_ix;

    while(index <= end_ix){
        let str2 = buff[index] >= 10 ? buff[index] <= 99 ? buff[index] : "00" : "0" + buff[index]
        string1 += str2;
        ++index
    }
    return string1;
}

function report(vx: Buffer, v1: boolean){
    let newRow : any = {};

    newRow['sald_g'] = dec_to_hex(vx[0])
    newRow['sald_me'] = dec_to_hex(vx[1])
    newRow['sald_a'] = dec_to_hex(vx[2])
    newRow['sald_h'] = dec_to_hex(vx[3])
    newRow['sald_m'] = dec_to_hex(vx[3])

    newRow['ambient_temperature'] = `${(vx[5] + vx[6] * 256)} °C`
    console.log(vx[7], vx[8], vx[9], vx[10], vx[11], vx[12])

    newRow['job'] = String.fromCharCode(vx[7]) + String.fromCharCode(vx[8]) + String.fromCharCode(vx[9])+ String.fromCharCode(vx[10]) + String.fromCharCode(vx[11]) + String.fromCharCode(vx[12])
    newRow['cant'] = String.fromCharCode(vx[13]) + String.fromCharCode(vx[14]) + String.fromCharCode(vx[15])+ String.fromCharCode(vx[16]) + String.fromCharCode(vx[17]) + String.fromCharCode(vx[18])
    newRow['flag_sald'] = (vx[19] + vx[20] * 256)
    newRow['version'] = (vx[21] + vx[22] * 256)
    newRow['rev_m'] = dec_to_hex(vx[23])
    newRow['rev_a'] = dec_to_hex(vx[24])

    const Left1 = vx[25]
    const Left2 = vx[26]
    const Left3 = vx[27]
    const Left4 = vx[28]

    newRow['welding_number'] = (Left1 + (Left2 * 256) + (Left3 * 65536) + (Left4 * 16777216))

    newRow['deep'] = vx[29] + vx[30] * 256
    
    newRow['v_sald'] = vx[31] + vx[32] * 256
    newRow['a_sald'] = vx[33] + vx[34] * 256

    newRow['time_elapsed'] = vx[35] + vx[36] * 256

    newRow['joul_sald_byte_1'] = vx[37];
    newRow['joul_sald_byte_2'] = vx[38];
    newRow['joul_sald_byte_3'] = vx[39];
    newRow['joul_sald_byte_4'] = vx[40];


    newRow['min_tension'] = `${(vx[41] + vx[42] * 256) / 10} V`;
    newRow['max_tension'] = `${(vx[43] + vx[44] * 256) / 10} V`;

    newRow['a_min_sald'] = (vx[45] + vx[46] * 256);
    newRow['a_max_sald'] = (vx[47] + vx[48] * 256);

    newRow['s_eseguiti'] = (vx[49] + vx[50] * 256);

    newRow['j_erogati_byte_1'] = vx[51];
    newRow['j_erogati_byte_2'] = vx[52];
    newRow['j_erogati_byte_3'] = vx[53];
    newRow['j_erogati_byte_4'] = vx[54];

    const energy_buff =  new ArrayBuffer(4);

    const energy_arr = new DataView(energy_buff);

    energy_arr.setInt8(0, vx[51]);
    energy_arr.setInt8(1, vx[52]);
    energy_arr.setInt8(2, vx[53]);
    energy_arr.setInt8(3, vx[54]);

    // envx[51], vx[52], vx[53], vx[54]]);

    let energy =  energy_arr.getFloat32(0)//. (vx[51] | vx[52] << 8 | vx[53] << 16 | vx[54] << 24) >>> 0
    newRow['supplied_energy'] = energy > 1000 ? `${energy / 1000} kJ` : `${energy} J`


    newRow['r_giunto_byte_1'] = vx[55];    
    newRow['r_giunto_byte_2'] = vx[56];    
    newRow['r_giunto_byte_3'] = vx[57];    
    newRow['r_giunto_byte_4'] = vx[58];    

    newRow['measured_resistance'] = `${((vx[55] | vx[56] << 8 | vx[57] << 16 | vx[58] << 24) >>> 0)} Ohm`

    newRow['errori'] = vx[59] + vx[60] * 256; 

    newRow['operator_badge'] = vec_to_string(vx, 61, 75)

    newRow['barcode_sald'] = vec_to_string(vx, 76, 87)

    newRow['barcode_tubo1'] = vec_to_string(vx, 88, 107)
    newRow['barcode_tubo2'] = vec_to_string(vx, 108, 127)
    newRow['barcode_tubo3'] = vec_to_string(vx, 128, 147)

    newRow['ora_gps'] = vx[148]

    if(vx[148] < 10)
        newRow['ora_gps'] = 0 + vx[148];
    newRow['min_gps'] = vx[149];
    if(vx[149] < 10)
        newRow['min_gps'] = 0 + vx[149]

    newRow['lat_gra'] = vx[150] + vx[151] * 256
    newRow['lat_min'] = vx[152] + vx[153] * 256

    newRow['emi_lat'] = String.fromCharCode(vx[154])

    const Left5 = vx[155];
    const Left6 = vx[156]
    const Left7 = vx[157]
    const Left8 = vx[158]

    newRow['lon_gra'] = (Left5 + (Left6 * 256) + (Left7 * 65536) + (Left8 * 16777216))
    newRow['lon_min'] = vx[159] + vx[160] * 256;
    newRow['emi_lon'] = String.fromCharCode(vx[161])

    newRow['d_gps'] = vx[162];
    if(vx[162] < 10)
        newRow['d_gps'] = 0 + vx[162];
    newRow['m_gps'] = vx[163];
    if(vx[163] < 10)
        newRow['m_gps'] = 0 + vx[163];
    newRow['y_gps'] = vx[164];
    if(vx[164] < 10)
        newRow['y_gps'] = 0 + vx[164];

    let str1 = "";
    let index1 = 165;

    while(index1 <= 180){
        str1 += vx[index1];
        index1++;
    }

    newRow['note_1'] = str1;

    let str2 = "";
    let index2 = 181;
    while(index2 <= 196){
        str2 += vx[index2];
        index2++;
    }
    newRow['note_2'] = str2;

    const Left9 = vx[197]
    const Left10 = vx[198]
    const Left11 = vx[199]
    const Left12 = vx[200]

    console.log({Left9, Left10, Left11, Left12});

    newRow['serial'] = (((Left9 + (Left10 * 256)) + (Left11 * 65536)) + (Left12 * 16777216))

    if(v1){
        let str3 = ""
        let index3 = 201;
        while(index3 <= 208){
            str3 += vx[index3];
            index3++;
        }
        newRow['cantiere'] = str3;

        const Left13 = vx[209];
        const Left14 = vx[210];
        const Left15 = vx[211];
        const Left16 = vx[212];
        newRow['n_sald_cantiere'] = (Left13 + (Left14 * 256) + (Left15 * 65536) + (Left16 * 16777216))
    }else{
        newRow['cantiere'] = "";
        newRow['n_sald_cantiere'] = "";
    }

    return newRow;

}
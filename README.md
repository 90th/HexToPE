# HexToPE
Converts hexadecimal to a byte array that saves into a file.
            
            //Convert an exe into bytes to hex.
            string Filename = @"HelloWorld.exe";
            byte[] Bytes1 = File.ReadAllBytes(Filename);
            Console.WriteLine(ConvertByteToHex(Bytes1));


using System;
using System.IO;

namespace D2MPQ
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                return; // No file input. So, let's exit.
            }

            var FileName = args[0];

            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite))
            {
                string FileExtension = Path.GetExtension(FileName).ToUpper();

                byte M = 0x58; // X
                byte P = 0x4B; // K
                byte Q = 0x4C; // L

                try
                {
                    if (FileExtension == ".MPQ")
                    {
                        fs.Position = 0x0;

                        byte[] Apply = { M, P, Q, 0x1A, 0x20, 0x00, 0x00, 0x00 };
                        fs.Write(Apply, 0, 8);

                        fs.Flush();
                        fs.Close();

                        Console.WriteLine($"{FileName}{"\n"}has been successfully changed!");
                        Console.ReadLine();
                    }
                    if (Path.GetFileName(FileName) == "Storm.dll")
                    {
                        fs.Position = 0x2A338; // 1.13c

                        byte[] Apply = { 0x00, 0x00, 0x81, 0x38, M, P, Q, 0x1A };
                        fs.Write(Apply, 0, 8);

                        fs.Flush();
                        fs.Close();

                        Console.WriteLine($"{FileName}{"\n"}has been successfully changed!");
                        Console.ReadLine();
                    }
                    else
                    {
                        return; // Invaild extension input. So, let's exit.
                    }
                }
                catch (Exception Ex)
                {
                    Console.WriteLine(Ex.Message);
                    Console.ReadLine();
                }
            }
        }
    }
}

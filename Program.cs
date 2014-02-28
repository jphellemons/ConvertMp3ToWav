using NAudio.Wave;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertMp3ToWav
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputDir = @"C:\Sounds\";

            foreach (var file in Directory.GetFiles(inputDir, "*.mp3"))
            {
                using (Mp3FileReader reader = new Mp3FileReader(file))
                {
                    WaveFileWriter.CreateWaveFile(file.Replace(".mp3", ".wav"), reader);
                }
            }
        }
    }
}

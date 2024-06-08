using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace RACE
{
    internal class Music
    {
        // Метод для відтоврення музики в меню
        
        public static void PlayMenuMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.menu_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play(); // Відтоврення музики в меню
        }
        // Метод зупинки музики в меню
        public static void StopMenuMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.menu_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Stop(); // Зупинка музики в меню
        }
        // Метод для відтоврення музики під час гри
        public static void PlayGameMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.game_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play(); // Відтоврення музики під час гри
        }
        // Метод зупинки музики під час гри
        public static void StopGameMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.game_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Stop();// Зупинка музики під час гри
        }
        // Метод для відтоврення музики під час програшу
        public static void PlayCrashMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.crash_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play(); // Відтоврення музики під час програшу
        }
        // Метод зупинки музики під час програшу
        public static void StopCrashMusic()
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.crash_music))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Stop(); // Зупинка музики під час програшу
        }
       
    }
}

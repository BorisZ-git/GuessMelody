using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
    static class Victorina
    {
        static public List<string> list = new List<string>();
        static public int GameDuration = 60;
        static public int MusicDuration = 10;
        static public bool RandomStart = false;
        static public string LastFolder = "";
        static public bool AllDirectories = false;
        static public int timeAnswer = 10;
        static public string Answer = "";

        static public void ReadMusic()
        {
            try
            {
                string[] Music_Files = Directory.GetFiles(LastFolder, "*mp3",
                    AllDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);                
                list.Clear();
                list.AddRange(Music_Files);
            }
            catch
            {

            }
        }
        static public string RegKeyWay = "Software\\NightmareInc\\GuessMelody";

        static public void WriteSettings()
        {
            RegistryKey rKey = null;
            try
            {
                rKey = Registry.CurrentUser.CreateSubKey(RegKeyWay);
                if (rKey == null) return;
                rKey.SetValue("GameDuration", GameDuration);
                rKey.SetValue("MusicDuration", MusicDuration);
                rKey.SetValue("RandomStart", RandomStart);
                rKey.SetValue("LastFolder", LastFolder);
                rKey.SetValue("AllDirectories", AllDirectories);
                rKey.SetValue("TimeAnswer", timeAnswer);
            }
            finally
            {
                if (rKey != null) rKey.Close();
            }
        }
        static public void ReadSettings()
        {
            RegistryKey rKey = null;
            try
            {
                rKey = Registry.CurrentUser.OpenSubKey(RegKeyWay);
                if(rKey != null)
                {
                    GameDuration =(int)rKey.GetValue("GameDuration");
                    MusicDuration =(int)rKey.GetValue("MusicDuration");
                    RandomStart =Convert.ToBoolean(rKey.GetValue("RandomStart"));
                    LastFolder =(string)rKey.GetValue("LastFolder");
                    AllDirectories = Convert.ToBoolean(rKey.GetValue("AllDirectories"));
                    timeAnswer = (int)rKey.GetValue("TimeAnswer");
                }
            }
            finally
            {
                if (rKey != null) rKey.Close();
            }
        }

    }
}

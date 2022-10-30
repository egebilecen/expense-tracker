using System;
using System.Collections.Generic;
using System.IO;

// Type Defines
using SettingPair = System.Collections.Generic.KeyValuePair<string, string>;

namespace EB_Utility
{
    public static class Settings
    {
        public static string settingsFile = "settings.eb";
        public static List<SettingPair> defaultSettings = new List<SettingPair> { };
        private static List<SettingPair> settings = new List<SettingPair>();
		
        public static void Load()
        {
            if(!File.Exists(settingsFile))
            {
                File.Create(settingsFile).Close();

                if(defaultSettings != null)
                {
                    for(int i=0; i < defaultSettings.Count; i++)
                        SetSetting(defaultSettings[i].Key, defaultSettings[i].Value, true);
                }

                return;
            }

            settings.Clear();

            string[] settingsContent = File.ReadAllLines(settingsFile);

            for(int i=0; i < settingsContent.Length; i++)
            {
                string   setting = settingsContent[i];
                string[] settingSplit = setting.Split(new char[] { '=' }, 2);

                SettingPair pair = new SettingPair(settingSplit[0], settingSplit[1]);

                settings.Add(pair);
            }
        }

        public static T GetSetting<T>(string key)
        {
            for(int i=0; i < settings.Count; i++)
            {
                SettingPair pair = settings[i];

                if(pair.Key   == key
                && pair.Value != "")
                {
                    try
                    {
                        return (T)Convert.ChangeType(pair.Value, typeof(T));
                    }
                    catch(InvalidCastException)
                    {
                        return default;
                    }
                }
            }

            return default;
        }

        public static void SetSetting(string key, object value, bool addIfNotExist=false)
        {
            if(value == null) value = "";
            else value = value.ToString();

            List<string> settings_content = new List<string>(File.ReadAllLines(settingsFile));

            for(int i=0; i < settings.Count; i++)
            {
                SettingPair setting = settings[i];

                if(setting.Key == key)
                {
                    settings_content[i] = key + "=" + value;
                    File.WriteAllLines(settingsFile, settings_content.ToArray());
                    
                    Load();
                    return;
                }
            }

            if(addIfNotExist)
            {
                settings_content.Add(key + "=" + value);
                File.WriteAllLines(settingsFile, settings_content.ToArray());
                    
                Load();
                return;
            }
        }
    }
}

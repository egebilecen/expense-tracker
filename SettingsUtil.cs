using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EB_Utility;

namespace GroceryExpenseTracker
{
    public static class SettingsUtil
    {
        public static string GetCurrencySettingStr()
        {
            return "CurrencySymbol";
        }

        public static string GetCurrencySymbol()
        {
            return Settings.GetSetting<string>(GetCurrencySettingStr());
        }
    }
}

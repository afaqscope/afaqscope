using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace AccessDB_Test
{
    class JSON
    {
        string jsonFile = AppDomain.CurrentDomain.BaseDirectory + "data.json";
        dynamic data;
        public JSON()
        {
            if (File.Exists(jsonFile))
            {
                string json = File.ReadAllText(jsonFile);
                data = JsonConvert.DeserializeObject(json);
            }
        }
        private List<SelectListItem> getBeneficiaryTypes()
        {
            for (int index = 0; index < data.settings.householdForm.beneficiaryType.choices.length; index++)
            {
                List<SelectListItem> beneficiaryTypes = new List<SelectListItem>();
                beneficiaryTypes.Add(new SelectListItem
                {
                    Text = data.settings.householdForm.beneficiaryType.choices[index],
                    Value = index
                });
            }
            return beneficiaryTypes;
        }
    }
}

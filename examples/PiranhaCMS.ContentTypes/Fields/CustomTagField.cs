

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha;
using Piranha.Extend;
using Piranha.Models;

namespace PiranhaCMS.Models.Fields
{
    [FieldType(Name = "Custom Tag", Component = "custom-tag")]
    public class CustomTagField : IField
    {
        // The selected value. This will be stored in the database.
        public string Value { get; set; }

        // The previously created options from other posts.
        public IList<string> Options { get; set; } = new List<string>();

        // The title when used in a list region.
        public string GetTitle()
        {
            return Value;
        }

        // Initializes the field
        public async Task Init(IApi api)
        {
            // Get the options param
            var param = await api.Params.GetByKeyAsync("CustomTagFieldOptions");

            if (param != null)
            {
                // We found the param, let's split the string value and assign
                // the options if it's not empty.
                if (!string.IsNullOrEmpty(param.Value))
                {
                    Options = param.Value.Split(';', options: StringSplitOptions.RemoveEmptyEntries)
                        .OrderBy(s => s).ToList();
                }
            }
            else 
            {
                // No existing param, let's create it.
                param = new Param
                {
                    Key = "CustomTagFieldOptions"
                };
            }

            // Check that the selected value exists in the options,
            // if it doesn't, let's add it
            if (!string.IsNullOrEmpty(Value) && !Options.Contains(Value))
            {
                Options.Add(Value);
                Options = Options.OrderBy(s => s).ToList();
                param.Value += $";{ Value }";
                await api.Params.SaveAsync(param);
            }
        }
    }

    public class CustomTagFieldSerializer : ISerializer
    {
        // When we serialize, ONLY store the selected option
        public string Serialize(object obj)
        {
            if (obj is CustomTagField)
            {
                return ((CustomTagField)obj).Value;
            }
            throw new ArgumentException();
        }

        // Create a new field from the given string
        public object Deserialize(string str)
        {
            return new CustomTagField
            {
                Value = str
            };
        }
    }
}


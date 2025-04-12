using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;
using PiranhaCMS.Models;
namespace PiranhaCMS.ContentTypes.Regions
{
    public class CounterInfo
    {
        public CounterInfo()
        {
            CssClass = new SelectField<CounterIconCssClass>
            {
                Value = CounterIconCssClass.industry
            };
        }

        [Field(Title = "Título")]
        public StringField Title { get; set; }

            [Field(Title = "Número")]
        public StringField Number { get; set; }

        [Field(Title = "Icon")]
        public SelectField<CounterIconCssClass> CssClass { get; set; }



        public string GetCssClass()
        {
            switch (CssClass?.Value)
            {
                case CounterIconCssClass.industry:
                    return "flaticon-industry";
                case CounterIconCssClass.clients:
                    return "flaticon-avatar";
                          case CounterIconCssClass.repair:
                    return "flaticon-repair";
                            case CounterIconCssClass.world:
                    return "flaticon-global";
                        case CounterIconCssClass.machine:
                    return "flaticon-robotic-arm";
                        case CounterIconCssClass.layers:
                    return "flaticon-layers";
                           case CounterIconCssClass.history:
                    return "flaticon-history";
                default:
                    return "icon";
            }
        }

    }
}